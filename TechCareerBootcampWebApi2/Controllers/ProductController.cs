using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TechCareerBootcampWebApi2.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ProductController : ControllerBase
	{
		[HttpGet]
		public IActionResult GetAll()
		{
			return Ok("Get all products");
		}

		[HttpGet("{id}")]
		public IActionResult GetById(int id)
		{
			return Ok($"Get product with id {id}");
		}

		[HttpPost]
		public IActionResult Create()
		{
			return Ok("Add a new product");
		}

		[HttpDelete("{id}")]
		public IActionResult Delete(int id)
		{
			return Ok($"Delete product with id {id}");
		}	
	}
}
