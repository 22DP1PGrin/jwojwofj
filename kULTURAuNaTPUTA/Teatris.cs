using System;
using System.Collections.Generic;
using System.Reflection;
using System.Xml.Serialization;
public class Teatris : Izklaide   //klase Teatris, kas manto Izklaide klasi
{
    //Konstruktors
    public Teatris(string name, string date, string location, string time, double price)
    {
        Name = name;
        Date = date;
        Location = location;
        Time = time;
        Price = price;
        Izklaides.Add(this);
    }

    //Metodes
    
    //Izklaides saraksta izdrukāšana
    public override void PrintIzklaides()
    {
        Console.WriteLine("To spend your holiday in a great mood, you are offered a choice of several performances: ");
        Console.WriteLine();

        foreach (var izklaide in Izklaides)
        {
            if (izklaide is Teatris)    //ja izklaide ir teatris klasē
            {
                Console.WriteLine("Play \"" + izklaide.name + "\" will be on " + izklaide.date + " in " + izklaide.location + " at " + izklaide.time + ". Ticket price " + izklaide.price);
            }
        }
            Console.WriteLine();
    }

    //Izklaides izvēle pēc mēneša. Šī virtuālā metode netiek pārrakstīta, bet gan paplašināta
    public override void HolidayTime()
    {
            Console.WriteLine("All tickets are valid for 2024!");
            Console.WriteLine("Enter the day of the month when your vacation begins and the day of the month when it ends: ");
            base.HolidayTime();
    }
    //Izklaides izvēle pēc budžeta. Šī virtuālā metode pārrakstīta
    public override void Budget()
    {
        Console.WriteLine();
        Console.WriteLine("Do you want to go to the theater?");
        string choise = Console.ReadLine();
        Console.WriteLine();
        if (choise.ToLower() == "yes")
        {
            Console.WriteLine("Enter the amount of money you are willing to spend on the theater: ");
            double Money = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
                foreach (var budget in MonthIzklaides)
                {
                    if (budget is Teatris && budget.price <= Money)
                    {
                        budgetList.Add(budget);
                        Console.WriteLine("You can afford to visit " + budget.name + " in " + budget.location + " on " + budget.date + " at " + budget.time+". Ticket price: "+budget.price); 
                    }
                }
        }
        else
        {
            Console.WriteLine("No problem!");
        }
    }
    
    //Izklaides rezervācija. Šī virtuālā metode pārrakstīta
    public override void SeatReservation()
    {
        if(budgetList.Count == 0)
        {
            Console.WriteLine("You have not chosen a play! Therefore you cannot make reservations");
            Console.WriteLine();
        }
        else
        { 
            Console.WriteLine();
            Console.WriteLine("Would you like to choose a play from the list according to your budget?");
            string choise = Console.ReadLine();
            Console.WriteLine();
            if (choise.ToLower() == "yes")
            {

                foreach (var izklaide in budgetList)
                {
                    if (izklaide is Teatris)
                    {
                        Console.WriteLine(izklaide.name + " in " + izklaide.location + " at " + izklaide.time + ". Ticket price: " + izklaide.price);
                    }
                }
                Console.WriteLine();
                Console.WriteLine("Which play would you like to attend?");
                string choice2 = Console.ReadLine();
                Console.WriteLine();
                bool found = false;
                foreach (var izklaide in budgetList)
                {
                    if (choice2 == izklaide.name)
                    {
                        Console.WriteLine("You have successfully booked a ticket for the play " + izklaide.name + " in " + izklaide.location + "!");
                        found = true;
                        break;
                    }
                }
                if (!found)
                {
                    Console.WriteLine("No such play in the list!");
                }
                string choice3;
                bool found2 = false;
                do
                {
                    Console.WriteLine();
                    Console.WriteLine("Want to book another place?");
                    choice3 = Console.ReadLine();
                    Console.WriteLine();
                    if (choice3.ToLower() == "yes")
                    {
                        Console.WriteLine("Which play would you like to attend?");
                        string choice4 = Console.ReadLine();
                        foreach (var izklaide in budgetList)
                        {
                            if (choice4 == izklaide.name)
                            {
                                Console.WriteLine("You have successfully booked a ticket for the play " + izklaide.name + " in " + izklaide.location + "!");
                                found2 = true;
                                break;
                            }
                        }
                        if (!found2)
                        {
                            Console.WriteLine("No such play in the list!");
                        }
                        
                    }

                } while (choice3.ToLower() == "yes");
            }
            else
            {
                Console.WriteLine("We provide a choice of list according to your vacation time: ");
                foreach (var izklaide in MonthIzklaides)
                {
                    if (izklaide is Teatris)
                    {
                        Console.WriteLine(izklaide.name + " in " + izklaide.location + " at " + izklaide.time + ". Ticket price: " + izklaide.price);
                    }
                }
                Console.WriteLine("Which play would you like to attend?");
                string choice5 = Console.ReadLine();
                bool found3 = false;
                foreach (var izklaide in MonthIzklaides)
                {
                    if (choice5 == izklaide.name)
                    {
                        Console.WriteLine("You have successfully booked a ticket for the play " + izklaide.name + " in " + izklaide.location + "!");
                        found3 = true;
                        break;
                    }
                }
                if (!found3)
                {
                    Console.WriteLine("No such play in the list!");
                }
                string choice6;
                bool found4 = false;
                do
                {
                    Console.WriteLine("Want to book another place?");
                    choice6 = Console.ReadLine();
                    if (choice6.ToLower() == "yes")
                    {
                        Console.WriteLine("Which play would you like to attend?");
                        string choice7 = Console.ReadLine();
                        foreach (var izklaide in budgetList)
                        {
                            if (choice7 == izklaide.name)
                            {
                                Console.WriteLine("You have successfully booked a ticket for the play " + izklaide.name + " in " + izklaide.location + "!");
                                found4 = true;
                                break;
                            }
                        }
                        if (!found4)
                        {
                            Console.WriteLine("No such play in the list!");
                        }
                    }

                } while (choice6.ToLower() == "yes");
            }

        }
    }
}