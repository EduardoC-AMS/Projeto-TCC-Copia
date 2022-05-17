using Microsoft.AspNetCore.Mvc;

namespace AMSIterface_22.Controllers
{

    [Route("API/[Controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IServiceBase<Produto> service;
        public ProductController(IServiceBase<Produto> service)
        {
            this.service = service;

        }

        public Task<ActionResult> GetAll()
        {
            var entity= this.service.GetAll(); 
            
            return Ok();

        }
    }
}