namespace WIndchillprojektet;

class Program
{
    static void Main(string[] args)
    {
        /*
         Vi har menyn i en "while-loop" för att kunna använda kalkylatorn flera gånger utan begränsning.
         Så länge användaren inte trycker Avsluta så fortsätter programmet.
         Vi deklarerar datatypen "bool" till identifierare/variabelnamnet "isRunning" och tilldelar den "true".
         isRunning fungerar som villkor för "while-loopen".
         */
        bool isRunning = true;
        while (isRunning)
        {            
            // Meny med tillhörande menyval, inuti en while-loop.
            Console.WriteLine("\nHej och välkommen till Windchillkalkylatorn!");
            Console.WriteLine("\n1. Beräkna windchill-faktor.");
            Console.WriteLine("2. Avsluta.");
            // Vi spar input från användaren i variabelnamnet/identifieraren "userChoice".
            string userChoice = (Console.ReadLine());
            // Använder switch-satsen för att selektera menyvalen.
            switch (userChoice)
            {
                case "1":                   
                        // Använder metoden Clear för att rensa konsolfönstret.
                        Console.Clear();
                        Console.Write("Skriv in temperaturen i grader Celsius: ");
                        // Använder metoden Parse för att konvertera från en string till datatypen "double" och spar den inuti "userTemp".
                        double userTemp = double.Parse(Console.ReadLine());
                        
                        Console.Write("Skriv vindhastigheten i m/s: ");
                        // Lika som ovan, metoden "Parse", datatypen "double", inuti "userWindSpeedMs".
                        double userWindSpeedMs = double.Parse(Console.ReadLine());
                        
                        // Omvandlar m/s till km/h och tilldelar den variabeln "userWindSpeedKmh".
                        double userWindSpeedKmh = userWindSpeedMs * 3.6;
                        // Använder formeln för windchill för att räkna ut vindkylfaktorn och spar den i variabeln "wct". 
                        // Använder metoden Pow i klassen Math för att räkna upphöjt till.
                        double wct = 13.12 + 0.6215 * userTemp - 11.37 * Math.Pow(userWindSpeedKmh, 0.16) +
                                     0.3965 * userTemp * Math.Pow(userWindSpeedKmh, 0.16);


                        // Om "wct" är under -25.
                        if (wct > -25)
                        {   
                            // Använder metoden ToString för att formatera svaret till en decimal, och konverterar till en string.
                            Console.WriteLine("\n" + wct.ToString("0.0"));
                            Console.WriteLine("Kallt");
                            // Använder metoden Sleep för att låta användaren avläsa svaret innan konsolfönstret rensas.
                            Thread.Sleep(1750);
                            Console.Clear();
                            
                        }
                        // Om "wct" är mellan -25 och -35 eller lika med dessa temperaturer, skrivs "Mycket kallt" ut.
                        else if (wct <= -25 && wct >= -35)
                        {                         
                            Console.WriteLine("\n" + wct.ToString("0.0"));
                            Console.WriteLine("Mycket kallt");
                            Thread.Sleep(1750);
                            Console.Clear();
                            
                        }
                        // Lika som ovan fast annat temperaturspann.
                        else if (wct < -35 && wct >= -60)
                        {                            
                            Console.WriteLine("\n" + wct.ToString("0.0"));
                            Console.WriteLine("Risk för frostskada.");
                            Thread.Sleep(1750);
                            Console.Clear();
                            
                        }
                        // Ifall wct är kallare än -60 skrivs "Stor risk för frostskada" ut.
                        else
                        {
                            Console.WriteLine("\n" + wct.ToString("0.0"));
                            Console.WriteLine("Stor risk för frostskada.");
                            Thread.Sleep(1750);
                            Console.Clear();
                            
                        }
                        break;
                // Ifall användaren väljer alternativ 2 för att avsluta.
                case "2":                   
                        Console.Clear();
                        Console.WriteLine("\nDu valde att avsluta.");
                        Thread.Sleep(1750);
                        // Avslutar while-loopen genom att vi tilldelar "isRunning" "false".
                        isRunning = false;
                        break;                   
                // Ifall användaren skriver in fel, så loopas man tillbaka till menyn.
                default:                      
                        Console.WriteLine("\nFel! Välj alternativ 1 eller 2");
                        Thread.Sleep(1500);
                        Console.Clear();
                        break;

            }
            
                
                
                
            
                
                
        }



    }
}