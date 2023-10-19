
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Address[] addresses =  new Address[2];
        Customer[] customers =  new Customer[2];
        List<Product>[] productsLists = new List<Product>[2];
        Order[] orders = new Order[2];

        //ORDER 1 (USA)
        addresses[0] = new Address("123 Main St", "Anytown", "Utah", "USA");
        customers[0] =  new Customer("John Doe",addresses[0]);
        productsLists[0] = new List<Product>();
        productsLists[0].Add(new Product("Hersy Kisses 16oz","H142342343465",4.99f,1));
        productsLists[0].Add(new Product("PB M&M 6oz","mars3kk34",2.50f,1));
        orders[0] = new Order(customers[0],productsLists[0]);

        //ORDER 2 (NOT USA)
        addresses[1] = new Address("99456 High strasse", "West", "Hamburg", "Germany");
        customers[1] =  new Customer("Fritz Dietz",addresses[1]);
        productsLists[1] = new List<Product>();
        productsLists[1].Add(new Product("Freeze Dried Taffy", "F1324564",12.99f,1));
        productsLists[1].Add(new Product("Cocoa Beans","C45844",25.49f,2));
        productsLists[1].Add(new Product("Confection Sugar","P11256",16.99f,2));
        orders[1] = new Order(customers[1],productsLists[1]);

        for(int i = 0; i < 2; i++)
        {
            Console.WriteLine($"\n-----CUSTOMER N°{i+1} ORDER-----");
            Console.WriteLine($"PACKING LABEL:\n{orders[i].GetPackingLabel()}"); 
            Console.WriteLine($"SHIPPING LABEL\n{orders[i].GetShippingLabel()}");
            Console.WriteLine($"TOTAL COST: ${orders[i].GetTotalCost()}");
        }
    }
}