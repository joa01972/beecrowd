using System; 
using System.Globalization;

class URI {

    static void Main(string[] args) { 

        double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        double pi = 3.14159;

        double area = pi * raio * raio;

        Console.WriteLine($"A={area.ToString("F4", CultureInfo.InvariantCulture)}");

    }

}
