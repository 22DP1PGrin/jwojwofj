using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Text.RegularExpressions;
public abstract class Izklaide
{
    //Saraksta eksemplāru saglabāšanai
    protected static List <Izklaide> Izklaides = new List<Izklaide>();
    protected static List<Izklaide> MonthIzklaides = new List<Izklaide>();
    protected static List<Izklaide> budgetList = new List<Izklaide>();

    //Lauki
    protected string Name;
    protected string Date;
    protected string Location;
    protected string Time;
    protected double Price;


    //GET pieejamu mainīgo izmantošanu
    public string name
    {
        get{return Name;}
    }
    public string date
    {
        get{return Date;}
    }
    public string location
    {
        get{return Location;}
    }
    public string time
    {
        get{return Time;}
    }
    public double price
    {
        get{return Price;}
    }
    
    //Metodes
    
    //Izklaides saraksta izdrukāšana
    public abstract void PrintIzklaides();

    //Izklaides izvēle pēc mēneša
    public virtual void HolidayTime()
    {
        int month1 = Convert.ToInt32(Console.ReadLine());
        int month2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();

        if (month1 <= 12 && month1 >= 3 && month2 <= 12 && month2 >= 3)
        {
            foreach (var izklaide in Izklaides)
            {
                string[] monthParts = izklaide.date.Split('.');  //datuma sadalīšana pēc punktiem
                int[] monthInts = new int[monthParts.Length];    //jauna masīva izveide ar tadu pašu garumu kā monthParts
                for (int i = 0; i < monthParts.Length; i++)      //cikls, kas pārveido stringu masīvu par int masīvu
                {
                    monthInts[i] = int.Parse(monthParts[i]);     //pārveido stringu masīvu par int masīvu
                }

                if (monthInts[1] >= month1 && monthInts[1] <= month2)
                {
                    MonthIzklaides.Add(izklaide);
                    Console.WriteLine("You can visit " + izklaide.name + " in " + izklaide.location + " at " + izklaide.time + " on "+izklaide.date+". Ticket price: " + izklaide.price);
                }
            }
        }
        else
        {
            Console.WriteLine("Invalid month!");
        }
    }

    //Izklaides izvēle pēc budžeta
    public virtual void Budget()
    {
        double Money = Convert.ToDouble(Console.ReadLine());
        foreach (var budget in MonthIzklaides)
        {
            if (budget.price <= Money)
            {
                Console.WriteLine("You can afford to visit " + budget.name + " in " + budget.location + " on " + budget.date + " at " + budget.time+". Ticket price: "+budget.price);
                budgetList.Add(budget);
            }
        }
    }
    //Izklaides rezervācija
    public abstract void SeatReservation();
}