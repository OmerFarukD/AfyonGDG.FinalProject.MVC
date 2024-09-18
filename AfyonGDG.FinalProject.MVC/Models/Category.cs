namespace AfyonGDG.FinalProject.MVC.Models;

public sealed class Category : Entity
{
    public string Name { get; set; }

    public List<Product> Products { get; set; }
}
