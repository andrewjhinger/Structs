using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Structs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            UsingStructs();
            Enums();
            Casting();
        }


        private void Casting()
        {
            // Create a degree character
            char degree = (char)176;

            // Declare Fahrenheit struct using implicit float cast for assignment
            Fahrenheit fahrenheit = 44.0F;
            Console.WriteLine("{0:F}" + degree + "F is {1:F}" + degree + "C", fahrenheit, fahrenheit.Celsius());

            // Output: 44°F is 6.67°C

            // Declare Fahrenheit struct using new operator
            fahrenheit = new Fahrenheit(35.75F);

            // Cast Fahrenheit to Celsius using implicit Fahrenheit to Celsius cast
            Celsius celsius = fahrenheit;
            Console.WriteLine("{0:F}" + degree + "C is {1:F}" + degree + "F", celsius, celsius.Fahrenheit());

            // Output: 2.083333°C is 35.75°F

            long currentTemp = (long)fahrenheit;
            Console.WriteLine(fahrenheit + degree.ToString() + "F is approximately " + currentTemp + degree.ToString() + "F");

            // Output: 35.75°F is approximately 36°F 
        } 


        private enum DaysOfWeek { Sun = 1, Mon, Tue, Wed, Thu, Fri, Sat };
        private enum Vote { Yes, No, Abstained };

        private void Enums()
        {
            // Cast a vote on a certain day, if possible
            string voteResult = myVote(DaysOfWeek.Tue, Vote.Abstained);
        }

        private string myVote(DaysOfWeek dayOfWeek, Vote myChoice)
        {
            string voteResult = "";
            switch (dayOfWeek)
            {
                case DaysOfWeek.Sat:
                    voteResult = "Closed!";
                    break;
                case DaysOfWeek.Sun:
                    voteResult = "Closed!";
                    break;
                default:
                    voteResult = "Open";
                    break;
            }
            return voteResult;
        }

        private void UsingStructs()
        {
            // Without new keyword
            Person studentName;
            studentName.First = "Mary";
            studentName.Middle = "Ann";
            studentName.Last = "Geewillickers";
            Console.WriteLine(studentName.FullName());

            // With new keyword
            Person instructorName = new Person("Thomas", "Edward", "Peachy");
            Console.WriteLine(instructorName.FullName());
        }
    }
}
