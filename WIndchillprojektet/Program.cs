namespace WIndchillprojektet;

class Program
{
    static void Main(string[] args)
    {

        bool isRunning = true;

        while (isRunning)
        {
            
            Console.WriteLine("\nHej och välkommen till Windchillkalkylatorn!");
            Console.WriteLine("\n1. Vill du beräkna windchill-faktor?");
            Console.WriteLine("2. Avsluta");
            // Ändra så att man kan skriva in en bokstav.
            int userChoice = int.Parse(Console.ReadLine());


            switch (userChoice)
            {
                case 1:
                    Console.Clear();
                    Console.Write("Skriv in temperaturen i grader Celsius: ");
                    double userTemp = double.Parse(Console.ReadLine());

                    Console.Write("Skriv vindhastigheten i m/s: ");
                    double userWindSpeedMs = double.Parse(Console.ReadLine());

                    double userWindSpeedKmh = userWindSpeedMs * 3.6;

                    double wct = 13.12 + 0.6215 * userTemp - 11.37 * Math.Pow(userWindSpeedKmh, 0.16) +
                                 0.3965 * userTemp * Math.Pow(userWindSpeedKmh, 0.16);

                    
                    Console.Write("\n" + wct.ToString("0.0"));
                    Thread.Sleep(1750);
                    Console.WriteLine();
                    
                    break;
                
                case 2:
                    
                    Console.Clear();
                    Console.WriteLine("\nDu valde att avsluta.");
                    isRunning = false;
                    break;
                
            }
            
                
                
                
            
                
                
        }



    }
}