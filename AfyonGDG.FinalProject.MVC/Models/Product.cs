﻿namespace AfyonGDG.FinalProject.MVC.Models;

public sealed class Product : Entity
{
    public string Name { get; set; }
    public decimal Price { get; set; }
    public int Stock { get; set; }
    public string Description { get; set; }

    public int CategoryId { get; set; }
    public Category? Category { get; set; }
}
