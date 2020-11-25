using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_MOD1_4_4_class__properties__constructor
{
    class Program
    {
        enum GoggleType { Foam, Swedish }
        static void Main(string[] args)
        {
            Aquaholics evan = new Aquaholics(34);
            evan.FinSize = 12;
            evan.GogglePreference = Convert.ToString(GoggleType.Swedish);
            evan.Name = "Evan";
            evan.Print();
        }
    }
    //Create a class with a handful of properties and a single constructor that has default values for all but one of the properties.
    //Make sure that each property only accepts a restricted range of values.In your comments tell what ranges you properties accept
    public class Aquaholics
    {

        // Name property is the only property that I did not set a range for.
        public string Name { get; set; }
        //suit size limit between 26 and 40 inclusive.
        private int suitSize;
        public int SuitSize
        {
            get { return suitSize; }
            set 
            {
                if (value >= 26 && value <= 40)
                {

                suitSize = value; 
                }
                else
                {
                    throw new ArgumentOutOfRangeException("range 26-40");
                }
            }
        }

        //fin size limit between 6 and 14 inclusive.       
        private int finSize;
        public int FinSize
        {
            get { return finSize; }
            set
            {
                if (value >= 6 && value <= 14)
                {

                    finSize = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("range 6-14");
                }
            }
        }

        
        // goggle choice limited to foam or swedish.
        private string gogglePreference;
        public string GogglePreference
        {
            get { return gogglePreference; }
            set
            {
                if (value == "Foam" || value == "Swedish")
                {

                    gogglePreference = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("GoggleType Foam or Swedish");
                }
            }
        }

        // behavior - method
        public void Print()
        {
            Console.WriteLine($"Name: {Name}, Suit Size: {SuitSize}, Fin Size: {FinSize}, Goggle Preference: {GogglePreference}");
        }

        // constructor to initialize the data
        public Aquaholics(int suitSize)
        {
            SuitSize = suitSize;
        }
    }
    
}
