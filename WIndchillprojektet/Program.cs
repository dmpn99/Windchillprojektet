namespace WIndchillprojektet;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hej och välkommen till Windchillkalkylatorn!");
        Console.Write("Skriv in temperaturen i grader Celsius: ");
        double userTemp = double.Parse(Console.ReadLine());
        
        Console.Write("Skriv vindhastigheten i m/s: ");
        double userWindSpeedMs = double.Parse(Console.ReadLine());
        
        double userWindSpeedKmh = userWindSpeedMs * 3.6;
        
        double wct = 13.12 + 0.6215 * userTemp - 11.37 * Math.Pow(userWindSpeedKmh, 0.16) + 0.3965 * userTemp * Math.Pow(userWindSpeedKmh, 0.16);
        
        Console.Write(wct);
        
        
        
        
    }
}