namespace StaticExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            var celcius = TempConverter.FahrenheitToCelcius(68);
            var fahrenheit = TempConverter.CelsiusToFahrenheit(20);

            Console.WriteLine("After Conversion:");
            Console.WriteLine("--------------------");
            Console.WriteLine($"Celcius: {celcius}");
            Console.WriteLine($"Fahrenheit: {fahrenheit}");

        }
    }
}
