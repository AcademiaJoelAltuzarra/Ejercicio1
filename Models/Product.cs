namespace TodoApi.Models;

public class Product
{
  public Product()
  {
    this.Id = -1;
    this.Name = string.Empty;
  }

  public int Id { get; set; }
  public string Name { get; set; }
}