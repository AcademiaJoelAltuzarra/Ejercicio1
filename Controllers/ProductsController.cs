using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TodoApi.Models;
using TodoApi.Repositories;

namespace TodoApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ProductsController : ControllerBase
{
    private ProductDummyRepository productRepository;

    //constructor
    public ProductsController()
    {
        this.productRepository = new ProductDummyRepository();
    }

    [HttpGet]
    //get all
    public List<Product> Get()
    {
        List<Product> products = this.productRepository.GetAll();
        return products;
    }

    [HttpGet("{id}")]
    //get one   http://localhost:7150/api/products/:id
    public Product Get(int id)
    {
        Product product = this.productRepository.FindById(id);
        return product;
    }

    [HttpPost]
    //insert
    public Product Post(Product product)
    {
        // llamar a la BD para crear producto
        return product;
    }

    [HttpPut]
    //update
    public Product Put(Product product, int id)
    {
        return product;
    }

    [HttpDelete]
    public int Delete(int id)
    {
        return id;
    }
}
