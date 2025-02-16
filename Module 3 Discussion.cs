using System;

public class Football    //Declaring a public class named Football.
{
    public string Color { get; set; }
    public int Size { get; set; }
    public string Brand { get; set; }

    public Football(string color, int size, string brand)  //Constructor initializing the color, size, and brand properties.
    {
        Color = color;  //Sets Color to equal color parameter
        Size = size;    // Sets Size to size parameter
        Brand = brand;  //Sets Brand to brand parameter
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"The football is {Color}, its size is {Size}, and the brand is {Brand}.");
    }
    public static void Main(string[] args)  //Entry point of the program
    {
        Football myFootball = new Football("brown", 5, "Nike");
        myFootball.DisplayInfo();
    }
}
