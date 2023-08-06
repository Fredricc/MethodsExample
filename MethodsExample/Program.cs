class Sample
{
    static void Main()
    {
        //local constant
        const string developerName = "harsha";

        //create reference variables
        Product product1, product2, product3;

        //create objects
        product1 = new Product();
        Product.TotalNoProducts++; //1
        product2 = new Product();
        Product.TotalNoProducts++; //2
        product3 = new Product();
        Product.TotalNoProducts++; //3

        //initIalize fields
        product1.SetProductID(1001);
        product1.SetProductName("Mobile");
        product1.SetCost(20000;
        product1.SetQuantityInStock(1200);
        product2.SetProductID(1003);
        product2.SetProductName("Laptop");
        product2.SetCost(45000);
        product2.SetQuantityInStock(3400);
        product3.SetProductID(1003);
        product3.SetProductName("Speakers");
        product3.SetCost(36000);
        product3.SetQuantityInStock(800);

        //call methods
        product1.CalculateTax();
        product2.CalculateTax();
        product3.CalculateTax();

        //get values from fields
        System.Console.WriteLine(developerName);

        System.Console.WriteLine("Product 1:");
        System.Console.WriteLine("Product ID: " + product1.productID);
        System.Console.WriteLine("Product Name: " + product1.productName);
        System.Console.WriteLine("Cost: " + product1.cost);
        System.Console.WriteLine("Quantity in Stock: " + product1.quantityInStock);
        System.Console.WriteLine("Date of Purchase: " + product1.dateOfPurchase);
        System.Console.WriteLine("Tax: " + product1.tax);

        System.Console.WriteLine("\nProduct 2:");
        System.Console.WriteLine("Product ID: " + product2.productID);
        System.Console.WriteLine("Product Name: " + product2.productName);
        System.Console.WriteLine("Cost: " + product2.cost);
        System.Console.WriteLine("Quantity in Stock: " + product2.quantityInStock);
        System.Console.WriteLine("Date of Purchase: " + product2.dateOfPurchase);
        System.Console.WriteLine("Tax: " + product2.tax);

        System.Console.WriteLine("\nProduct 3:");
        System.Console.WriteLine("Product ID: " + product3.productID);
        System.Console.WriteLine("Product Name: " + product3.productName);
        System.Console.WriteLine("Cost: " + product3.cost);
        System.Console.WriteLine("Quantity in Stock: " + product3.quantityInStock);
        System.Console.WriteLine("Date of Purchase: " + product3.dateOfPurchase);
        System.Console.WriteLine("Tax: " + product3.tax);

        int totalQuantity = product1.quantityInStock + product2.quantityInStock + product3.quantityInStock;
        System.Console.WriteLine("Total Quantity: " + totalQuantity);
        System.Console.WriteLine("Total no. of products: " + Product.TotalNoProducts);  //Output: 3
        System.Console.WriteLine("Category of products: " + Product.CategoryName);  //Output: Electronics

        System.Console.ReadKey();
    }
}

