// See https://aka.ms/new-console-template for more information
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;



ECommerceDbContext db = new ECommerceDbContext();

Product pen = new Product { Name = "penna", Description="bello", Price=2.10};
Product paper = new Product { Name = "carta", Description = "bello", Price = 2.10 };
Product pc = new Product { Name = "pc", Description = "bello", Price = 2.10 };
Product alexa = new Product { Name = "alexa", Description = "bello", Price = 2.10 };
Product tastiera = new Product { Name = "tastiera", Description = "bello", Price = 2.10 };
Product mouse = new Product { Name = "mouse", Description = "bello", Price = 2.10 };
Product evidenziatore = new Product { Name = "evidenziatore", Description = "bello", Price = 2.10 };
Product schedaVideo = new Product { Name = "schedaVid", Description = "bello", Price = 2.10 };
Product processore = new Product { Name = "processore", Description = "bello", Price = 2.10 };
Product schedaMadre = new Product { Name = "schedaMadre", Description = "bello", Price = 2.10 };

List<Product> productList = new List<Product> { pen, paper, pc, alexa, tastiera, mouse, evidenziatore, schedaVideo, processore, schedaMadre};

foreach (Product product in productList)
{
    db.Products.Add(product);
    db.SaveChanges();
}