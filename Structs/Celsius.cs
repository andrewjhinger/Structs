using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structs
{
    public struct Celsius
{
    // Public field
    public float Temperature;
    // Constructor
    public Celsius(float temperature)
    {
        Temperature = temperature;
    }
    // Implicit cast from float to Celsius
    public static implicit operator Celsius(float temperature)
    {
        return new Celsius(temperature);
    }
    // Implicit cast from Fahrenheit to Celsius
    public static implicit operator Celsius(Fahrenheit fahrenheit)
    {
        return new Celsius((fahrenheit.Temperature - 32.0F) * (5.0F / 9.0F));
    }
    // Explicit cast from Celsius to long
    public static explicit operator long(Celsius celsius)
    {
            return (long)Math.Round(celsius.Temperature, 0);
    }
    // Method to return Celsius to Fahrenheit conversion
    public float Fahrenheit()
    {
        return ((Temperature * (9.0F / 5.0F)) + 32);
    }
    // Display Celsius value as a string
    public override string ToString()
    {
        return Temperature.ToString();
    }
    }
}
