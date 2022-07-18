using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace StaticExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TempConverter converter = new TempConverter();

            //!=======================
            bool isValid_1;
            double Input_1;
            //!=======================
            //!=======================//!=======================//!=======================
            do
            {//todo==============================================================
                //!=======================
                Console.WriteLine("Convert Temperature Fahrenheit to Celcius:");
                Console.WriteLine("Please enter a number.");
                isValid_1 = Double.TryParse(Console.ReadLine(), out Input_1);
                //!=======================
                if (!isValid_1)
                {//?============================= 
                    Console.WriteLine("You didn't type a number, Please try again");
                    isValid_1 = false;
                }//?============================= 
            }//todo==============================================================
            while (!isValid_1);
            //!=======================


            var CEltemp = TempConverter.FahrenheitToCelcius(Input_1);
            Console.WriteLine($"Your Temp for Celcius is {CEltemp} You entered in Fahrenheit {Input_1}");


            //!=======================
            bool isValid_2;
            double Input_2;
            //!=======================
            //!=======================//!=======================//!=======================
            do
            {//todo==============================================================
                //!=======================
                Console.WriteLine("Convert Temperature Celcius to Fahrenheit:");
                Console.WriteLine("Please enter a number.");
                isValid_2 = Double.TryParse(Console.ReadLine(), out Input_2);
                //!=======================
                if (!isValid_2)
                {//?============================= 
                    Console.WriteLine("You didn't type a number, Please try again");
                    isValid_2 = false;
                }//?============================= 
            }//todo==============================================================
            while (!isValid_2);
            //!======================

            var FERNtemp = TempConverter.CelciusToFahrenheit(Input_2);
            Console.WriteLine($"Your temp for Farrenheit {FERNtemp} You entered in Celcius {Input_2}");
        }
    }
}