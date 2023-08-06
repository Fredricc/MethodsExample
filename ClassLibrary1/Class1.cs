﻿public class Product
{
    //fields
    public int productID;
    public string productName;
    public double cost;
    public double tax;
    public int quantityInStock;
    public static int TotalNoProducts;
    public const string CategoryName = "Electronics";
    public readonly string dateOfPurchase;

    //constructor
    public Product()
    {
        dateOfPurchase = System.DateTime.Now.ToShortDateString();
    }

    //Set method for productID
    public void SetProductID(int value)
    {
        productID = value;
    }

    //Get Method for productId
    public int GetProductID()
    {
        return productID;
    }

    //Set method for productName
    public void SetProductName(string value)
    {
        productName = value;
    }

    //Get Method for productName
    public string GetProductName()
    {
        return productName;
    }

    //Set method for Cost
    public void SetCost(double value)
    {
        cost = value;
    }

    //Get Method for Cost
    public double GetCost()
    {
        return cost;
    }

    //Set method for tax
    public void SetTax(double value)
    {
        tax = value;
    }

    //Get Method for Tax
    public double GetTax()
    {
        return tax;
    }

    //Set method for quantityInStock
    public void SetQuantityInStock(int value)
    {
        quantityInStock = value;
    }

    //Get Method for quantityInStock
    public int GetQuantityInStock()
    {
        return quantityInStock;
    }

    //Get Method for dateOfPurchase
    public string GetDateOfPurchase()
    {
        return dateOfPurchase;
    }

    //method
    /*cost <= 20000  then  tax = 10%
    cost > 20000 then  tax = 12.5%*/
    public void CalculateTax()
    {
        //create local variable
        double t;

        //calculate tax
        if (cost <= 20000)
        {
            t = cost * 10 / 100;
        }
        else
        {
            t = cost * 12.5 / 100;
        }
        tax = t;
    }
}

