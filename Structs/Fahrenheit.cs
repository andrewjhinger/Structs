using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structs
{
    public struct Fahrenheit
{
    // Public field
    public float Temperature;
    // Constructor
    public Fahrenheit(float temperature)
    {
        Temperature = temperature;
    }
    // Implicit cast from float to Fahrenheit
    public static implicit operator Fahrenheit(float temperature)
    {
        return new Fahrenheit(temperature);
    }
    // Implicit cast from Celsius to Fahrenheit
    public static implicit operator Fahrenheit(Celsius celsius)
    {
        return new Fahrenheit((celsius.Temperature * (5.0F / 9.0F)) + 32.0F);
    }
    // Explicit cast from Fahrenheit to long
    public static explicit operator long(Fahrenheit fahrenheit)
    {
        return (long)Math.Round(fahrenheit.Temperature, 0);
    }
    // Method to return Fahrenheit to Celsius conversion
    public float Celsius()
    {
        return ((Temperature - 32.0F) * (5.0F / 9.0F));
    }
    // Display Fahrenheit value as a string
    public override string ToString()
    {
        return Temperature.ToString();
    }
}
}
