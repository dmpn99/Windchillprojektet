namespace WIndchillprojektet;

class Program
{
    static void Main(string[] args)
    {

        bool isRunning = true;

        while (isRunning)
        {            
            Console.WriteLine("\nHej och välkommen till Windchillkalkylatorn!");
            Console.WriteLine("\n1. Beräkna windchill-faktor.");
            Console.WriteLine("2. Avsluta.");
            // Ändra så att man kan skriva in en bokstav.
            string userChoice = (Console.ReadLine());


            switch (userChoice)
            {
                case "1":                   
                        Console.Clear();
                        Console.Write("Skriv in temperaturen i grader Celsius: ");
                        double userTemp = double.Parse(Console.ReadLine());

                        Console.Write("Skriv vindhastigheten i m/s: ");
                        double userWindSpeedMs = double.Parse(Console.ReadLine());

                        double userWindSpeedKmh = userWindSpeedMs * 3.6;

                        double wct = 13.12 + 0.6215 * userTemp - 11.37 * Math.Pow(userWindSpeedKmh, 0.16) +
                                     0.3965 * userTemp * Math.Pow(userWindSpeedKmh, 0.16);


                        // Gjorde ett försök att lägga in en if-sats. 
                        if (wct > -25)
                        {

                            Console.WriteLine("\n" + wct.ToString("0.0"));
                            Console.WriteLine("Kallt");
                            Thread.Sleep(1750);
                            break;

                        }
                        // Tror att det finns risk att problem uppstår ifall värdet blir exakt -35
                        else if (wct <= -25 && wct >= -35)
                        {
                            Console.WriteLine("\n" + wct.ToString("0.0"));
                            Console.WriteLine("Mycket kallt");
                            Thread.Sleep(1750);
                            break;
                        }
                        // Tror att det finns risk att problem uppstår ifall värdet blir exakt -35
                        else if (wct < -35 && wct >= -60)
                        {
                            Console.WriteLine("\n" + wct.ToString("0.0"));
                            Console.WriteLine("Risk för frostskada.");
                            Thread.Sleep(1750);
                            break;
                        }

                        else
                        {
                            Console.WriteLine("\n" + wct.ToString("0.0"));
                            Console.WriteLine("Stor risk för frostskada.");
                            Thread.Sleep(1750);
                            break;
                        }                                                     
                case "2":                   
                        Console.Clear();
                        Console.WriteLine("\nDu valde att avsluta.");
                        Thread.Sleep(1500);
                        isRunning = false;
                        break;                   
                default:                      
                        Console.WriteLine("\nVänligen tryck alternativ 1-2");
                        Thread.Sleep(1500);
                        Console.Clear();
                        break;
                    
                    

                

            }
            
                
                
                
            
                
                
        }



    }
}