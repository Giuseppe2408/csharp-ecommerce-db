// See https://aka.ms/new-console-template for more information
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
//connessione db
ECommerceDbContext db = new ECommerceDbContext();


Console.WriteLine("sei un dipendente o un cliente?");
string ruoloUtente = Console.ReadLine();

switch(ruoloUtente)
{
    case "dipendente":
        Console.WriteLine("digita 1 per creare un prodotto");
        Console.WriteLine("digita 2 per vedere i tuoi prodotti");
        Console.WriteLine("digita 3 per modificare un prodotto");
        Console.WriteLine("digita 4 per cancellare un prodotto");
        int sceltaDipendente = Convert.ToInt32(Console.ReadLine());

        switch (sceltaDipendente)
        {
            case 1:
                CreateOrder();
                break;
        }
        break;




    case "cliente":
        break;


}








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
    if(product.Id != product.Id)
    {
        db.Products.Add(product);
        db.SaveChanges();
    }  
}

void CreateOrder()
{
    Order order = new Order();
}