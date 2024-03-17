using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

class Program
{
    public static void Main(string[] args)
    {
        Teatris play1 = new Teatris("The Little Prince", "17.03.2024", "Riga Russian Theatre", "14:00", 10.50);
        Teatris play2 = new Teatris("Robin Hood", "14.07.2024", "Riga Russian Theatre", "19:00", 12.75);
        Teatris play3 = new Teatris("BOYS ARE NOT GIRLS", "09.04.2024", "Daile Theater Great Hall", "18:00", 30.00);
        Teatris play4 = new Teatris("LULLABY FOR THE LITTLE HALL", "27.03.2024", "Daile Theater Great Hall", "21:00", 30.00);
        Teatris play5 = new Teatris("Jakub Jozef Orlinski", "09.09.2024", "Riga National Theatre", "19:00", 89.30);
        Teatris play6 = new Teatris("Oh, no. I did it again!", "19.10.2024", "Daile Theater Great Hall", "11:00", 12.00);
        Teatris play7 = new Teatris("I love you", "17.03.2024", "Daile Theater Great Hall", "21:00", 34.00);
        Teatris play8 = new Teatris("Ho-oh-ho-oh", "26.11.2024", "Riga National Theatre", "12:00", 71.76);
        Teatris play9 = new Teatris("Death ot live?", "19.04.2024", "Daile Theater Great Hall", "18:00", 30.67);
        Teatris play10 = new Teatris("You and me", "17.06.2024", "Riga Russian Theatre", "20:00", 16.00);
        Teatris play11 = new Teatris("I wanna die", "10.09.2024", "Riga Russian Theatre", "23:00", 12.50);

        Koncerts concert1 = new Koncerts("Thomas Anders. 40 years of Modern Talking", "23.12.2024", "Arena Riga", "14:00", 43.94);
        Koncerts concert2 = new Koncerts("The World of Hans Zimmer", "14.06.2024", "Arena Riga", "21:00", 34.84);
        Koncerts concert3 = new Koncerts("Someone Like You The Adele Songbook", "14.04.2024", "Arena Riga", "21:00", 34.84);
        Koncerts concert4 = new Koncerts("Concert at Pavel Volya", "03.12.2024", "Arena Riga", "18:00", 93.94);
        Koncerts concert5 = new Koncerts("My world is your world", "14.06.2024", "Arena Riga", "15:00", 35.94);
        Koncerts concert6 = new Koncerts("Concert at Neoni", "14.04.2024", "Arena Riga", "13:00", 54.04);
        Koncerts concert7 = new Koncerts("Concert for no reason", "14.05.2024", "Arena Riga", "21:00", 00.00);
        Koncerts concert8 = new Koncerts("Concert at Blackpink", "10.10.2024", "Arena Riga", "21:00", 34.84);

        play1.PrintIzklaides();
        concert1.PrintIzklaides();
        play1.HolidayTime();
        play1.Budget();
        concert1.Budget();
        play1.SeatReservation();
        concert1.SeatReservation();
        concert2.GoodBue();
    }
}