// See https://aka.ms/new-console-template for more information
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
//connessione db
ECommerceDbContext db = new ECommerceDbContext();


Console.WriteLine("sei un dipendente o un cliente?");
string ruoloUtente = Console.ReadLine();

switch (ruoloUtente)
{
    case "dipendente":
        Console.WriteLine("digita 1 per creare un ordine");
        Console.WriteLine("digita 2 per vedere i tuoi ordini");
        Console.WriteLine("digita 3 per modificare un ordine");
        Console.WriteLine("digita 4 per cancellare un ordine");
        int sceltaDipendente = Convert.ToInt32(Console.ReadLine());

        switch (sceltaDipendente)
        {
            case 1:
                CreateOrder();
                break;

            case 2:
                Console.WriteLine("Ecco la lista di ordini:");
                List<Order> orders = OrderList(); 
                foreach (Order order in orders)
                {
                    Console.Write(order.Id + " ordine");
                    Console.WriteLine(" data: " + order.Data + " prezzo: " + order.Amount);    
                }

                break;

            case 3:
                EditOrder();
                break;

            case 4:
                DeleteOrder();
                break;
        }
        break;




    case "cliente":
        Console.WriteLine("scegli un id tra la lista degli ordini");
        
        List<Order> ordersList = OrderList();
        foreach(Order order in ordersList)
        {
            Console.Write(order.Id + " ordine");
            Console.WriteLine(" data: " + order.Data + " prezzo: " + order.Amount);
        }
        int sceltaID = Convert.ToInt32(Console.ReadLine());
        foreach (Order order in ordersList)
        {
            if (order.Id == sceltaID)
            {
                Console.WriteLine("ok per acquistare l'ordine numero {0} inserisci i tuoi dati", order.Id);
            }
        }

        break;


}








Product pen = new Product { Name = "penna", Description = "bello", Price = 2.10 };
Product paper = new Product { Name = "carta", Description = "bello", Price = 2.10 };
Product pc = new Product { Name = "pc", Description = "bello", Price = 2.10 };
Product alexa = new Product { Name = "alexa", Description = "bello", Price = 2.10 };
Product tastiera = new Product { Name = "tastiera", Description = "bello", Price = 2.10 };
Product mouse = new Product { Name = "mouse", Description = "bello", Price = 2.10 };
Product evidenziatore = new Product { Name = "evidenziatore", Description = "bello", Price = 2.10 };
Product schedaVideo = new Product { Name = "schedaVid", Description = "bello", Price = 2.10 };
Product processore = new Product { Name = "processore", Description = "bello", Price = 2.10 };
Product schedaMadre = new Product { Name = "schedaMadre", Description = "bello", Price = 2.10 };

List<Product> productList = new List<Product> { pen, paper, pc, alexa, tastiera, mouse, evidenziatore, schedaVideo, processore, schedaMadre };

foreach (Product product in productList)
{
    if (product.Id != product.Id)
    {
        db.Products.Add(product);
        db.SaveChanges();
    }
}



//create
void CreateOrder()
{
    Console.WriteLine("quanti ordini vuoi creare?");
    int n = 0;
    int numOrdine = Convert.ToInt32(Console.ReadLine());

    while (n < numOrdine)
    {
        Console.WriteLine("inserisci data");
        DateTime data = Convert.ToDateTime(Console.ReadLine());
        Console.WriteLine("inserisci prezzo");
        double amount = Convert.ToDouble(Console.ReadLine());
        //int randCustomer = new Random().Next(1, 5);
        //int randEmployee = new Random().Next(1, 5);

        Order order = new Order { Data = data, Amount = amount, Status = false };

        db.Orders.Add(order);
        db.SaveChanges();
        n++;
    }
}

List<Order> OrderList()
{
    List<Order> orderList = db.Orders.ToList<Order>();
    return orderList;
}

void EditOrder()
{
    Console.WriteLine("inserisci l'id dell'ordine che vuoi modificare?");
    int idOrdine = Convert.ToInt32(Console.ReadLine());
    List<Order> orderList = OrderList();
    foreach (Order order in orderList)
    {
        if (idOrdine == order.Id)
        {
            Console.WriteLine("inserisci data da modificare");
            DateTime data = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("inserisci prezzo da modificare");
            double amount = Convert.ToDouble(Console.ReadLine());
            order.Data = data;
            order.Amount = amount;
            db.SaveChanges();
        }
    }


}

void DeleteOrder()
{
    Console.WriteLine("inserisci l'id dell'ordine che vuoi eliminare");
    int idOrdine = Convert.ToInt32(Console.ReadLine());
    List<Order> orderList = OrderList();
    foreach (Order order in orderList)
    {
        if (idOrdine == order.Id)
        {
            Console.WriteLine("sicuro di voler eliminare? inserisci si/no");
            string sceltaUtente = Console.ReadLine();

            switch (sceltaUtente)
            {
                case "si":
                    db.Remove(order);
                    db.SaveChanges();
                    break;

                case "no":
                    Console.WriteLine("ok vabene");     
                    break;
            }

            
        }
    }


}




//Customer pep = new Customer { Name = "peppe", Surname = "bello", Email = "pep@mail.it" };
//Customer giov = new Customer { Name = "giovanni", Surname = "bello", Email = "pep@mail.it" };
//Customer ale = new Customer { Name = "alessio", Surname = "bello", Email = "pep@mail.it" };
//Customer manuel = new Customer { Name = "manuel", Surname = "bello", Email = "pep@mail.it" };
//Customer paolo = new Customer { Name = "paolo", Surname = "bello", Email = "pep@mail.it" };
//Customer nirua = new Customer { Name = "nirua", Surname = "bello", Email = "pep@mail.it" };

//db.Add(pep);
//db.Add(giov);
//db.Add(ale);
//db.Add(manuel);
//db.Add(paolo);
//db.Add(nirua);

//db.SaveChanges();

//Employee rossana = new Employee { Name = "rossana", Surname = "bello" };
//Employee simone = new Employee { Name = "simone", Surname = "bello" };
//Employee anguo = new Employee { Name = "anguo", Surname = "bello" };
//Employee stefano = new Employee { Name = "stefano", Surname = "bello" };
//Employee katia = new Employee { Name = "katia", Surname = "bello" };
//Employee rossi = new Employee { Name = "rossi", Surname = "bello" };

//db.Add(rossana);
//db.Add(simone);
//db.Add(anguo);
//db.Add(stefano);
//db.Add(katia);
//db.Add(rossi);

//db.SaveChanges();