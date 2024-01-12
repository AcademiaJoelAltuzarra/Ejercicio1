using TodoApi.Models;

namespace TodoApi.Repositories;

public class ProductDummyRepository
{
  private List<Product> listProducts;

  public ProductDummyRepository()
  {
    // Product product1 = new Product();
    // product1.Id = 1;
    // product1.Name = "Algo";

    // Product product2 = new Product(){
    //   Id = 1,
    //   Name = "Algo"
    // };

    // listProducts.Add(product1);
    // listProducts.Add(product2);
    listProducts = new List<Product>();
    listProducts.Add(new Product()
    {
      Id = 1,
      Name = "Algo"
    });

    listProducts.Add(new Product()
    {
      Id = 2,
      Name = "Algo 2"
    });

    listProducts.Add(new Product()
    {
      Id = 3,
      Name = "Algo 3"
    });
  }

  public List<Product> GetAll()
  {
    return listProducts;
  }

  public Product FindById(int id)
  {
    //logica para buscar
    //Product productFind = new Product();

    // for (int i = 0; i < listProducts.Count; i++)
    // {
    //   Product product = listProducts[i];
    //   if (product.Id == id)
    //   {
    //     productFind = product;
    //   }
    // }

    foreach (Product product in listProducts)
    {
      if (product.Id == id)
      {
        //productFind = product;
        return product;
      }
    }

    return new Product();
    //return productFind;
  }

  public Product Create(Product product)
  {
    return product;
  }

  public Product Update(Product product, int id)
  {
    return product;
  }

  public int Remove(int id)
  {
    return id;
  }
}
