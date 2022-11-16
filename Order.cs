// See https://aka.ms/new-console-template for more information
public class Order
{
    public int Id { get; set; }

    public DateTime Data { get; set; }

    public double Amount { get; set; }

    public bool Status { get; set; }

    //relazione con customer
    public int? CustomerID { get; set; }
    public Customer Customer { get; set; }


    //relazione con employee
    public int? EmployeeID { get; set; }
    public Employee Employee { get; set; }


    //relazione con payment

    public List<Payment> Payments { get; set; }

    //relazione prodotti
    public List<Product> Products { get; set; }

}
