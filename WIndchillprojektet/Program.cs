namespace WIndchillprojektet;

class Program
{
    static void Main(string[] args)
    {
        /*
         Vi har menyn i en while-loop för att kunna använda kalkylatorn obegränsat med gånger.
         Så länge användaren inte trycker Avsluta så fortsätter programmet.
         Vi börjar med att deklarera en bool "isRunning" (true) som blir villkor till while-loopen.
         */
        bool isRunning = true;
        while (isRunning)
        {            
            Console.WriteLine("\nHej och välkommen till Windchillkalkylatorn!");
            Console.WriteLine("\n1. Beräkna windchill-faktor.");
            Console.WriteLine("2. Avsluta.");
            // Vi spar input från användaren i variabeln "userChoice"
            string userChoice = (Console.ReadLine());

            // Använder switch-satsen för att selektera menyvalen.
            switch (userChoice)
            {
                case "1":                   
                        Console.Clear();
                        Console.Write("Skriv in temperaturen i grader Celsius: ");
                        double userTemp = double.Parse(Console.ReadLine());

                        Console.Write("Skriv vindhastigheten i m/s: ");
                        double userWindSpeedMs = double.Parse(Console.ReadLine());
                        
                        // Omvandlar m/s till km/h och tilldelar den variabeln userWindSpeedKmh.
                        double userWindSpeedKmh = userWindSpeedMs * 3.6;

                        double wct = 13.12 + 0.6215 * userTemp - 11.37 * Math.Pow(userWindSpeedKmh, 0.16) +
                                     0.3965 * userTemp * Math.Pow(userWindSpeedKmh, 0.16);


                        
                        if (wct > -25)
                        {                              
                            Console.WriteLine("\n" + wct.ToString("0.0"));
                            Console.WriteLine("Kallt");
                            Thread.Sleep(1750);
                            Console.Clear();
                            break;
                        }
                        
                        else if (wct <= -25 && wct >= -35)
                        {                         
                            Console.WriteLine("\n" + wct.ToString("0.0"));
                            Console.WriteLine("Mycket kallt");
                            Thread.Sleep(1750);
                            Console.Clear();
                            break;
                        }
                        
                        else if (wct < -35 && wct >= -60)
                        {                            
                            Console.WriteLine("\n" + wct.ToString("0.0"));
                            Console.WriteLine("Risk för frostskada.");
                            Thread.Sleep(1750);
                            Console.Clear();
                            break;
                        }

                        else
                        {
                            Console.WriteLine("\n" + wct.ToString("0.0"));
                            Console.WriteLine("Stor risk för frostskada.");
                            Thread.Sleep(1750);
                            Console.Clear();
                            break;
                        }                                                     
                case "2":                   
                        Console.Clear();
                        Console.WriteLine("\nDu valde att avsluta.");
                        Thread.Sleep(1750);
                        isRunning = false;
                        break;                   
                default:                      
                        Console.WriteLine("\nFel! Välj alternativ 1 eller 2");
                        Thread.Sleep(1500);
                        Console.Clear();
                        break;
                    
                    

                

            }
            
                
                
                
            
                
                
        }



    }
}