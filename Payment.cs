// See https://aka.ms/new-console-template for more information
public class Payment
{

    public int Id { get; set; }

    public DateTime Date { get; set; }

    public double Amount { get; set; }

    public bool Status { get; set; }


    //relazione order
    public int OrderID { get; set; }
    public Order Order { get; set; }
   
   
}
