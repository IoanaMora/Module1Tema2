using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        #region Enum

        public enum Gender
        {
            NONE = 0,
            M = 1,
            F = 2,
        }

        #endregion Enum

        #region Variable

        private static int? genderIndexNullable;
        private static Gender genderEnum = Gender.NONE;
        public const int womanRetirementAge = 63;
        private const int maleRetirementAge = 65;

        #endregion Variable

        static void Main(string[] args)
        {
            #region DateTime
            var correctDayInput = false;
            int day = 0;
            while (!correctDayInput)
            {
                try
                {
                    Console.WriteLine("Plese enter you birthdate Day");
                    day = int.Parse(Console.ReadLine());
                    correctDayInput = true;
                }
                catch
                {
                    Console.WriteLine("Invalid input.Plase enter you birthdate Day (dd format)");
                    correctDayInput = false;
                }
            }

            var correctMonthInput = false;
            int month = 0;
            while (!correctMonthInput)
            {
                try
                {
                    Console.WriteLine("Plese enter you birthdate Month (two digits format)");
                    month = int.Parse(Console.ReadLine());
                    correctMonthInput = true;
                }
                catch
                {
                    Console.WriteLine("Invalid input.Plase enter you birthdate Month (mm format)");
                    correctMonthInput = false;
                }

            }

            var correctYearInput = false;
            int year = 0;
            while (!correctYearInput)
            {
                try
                {
                    Console.WriteLine("Plese enter you birthdate Year (yyyy format)");
                    year = int.Parse(Console.ReadLine());
                    correctYearInput = true;
                }
                catch
                {
                    Console.WriteLine("Invalid Input. Plese enter you birthdate Year (yyyy format)");
                    correctYearInput = false;
                }
            }

            DateTime birthdate = new DateTime(year, month, day);

            Console.WriteLine("You birthdate is" + " " + birthdate);

            #endregion DateTime

            #region Age

            var today = DateTime.Now;

            var age = today.Year - birthdate.Year;

            if (today.Month < birthdate.Month || (today.Month == birthdate.Month && today.Day < birthdate.Day))
                age--;

            Console.WriteLine("your age is" + " " + age);

            #endregion Age

            #region Gender

            do
            {
                Console.WriteLine("Please enter your gender. Use M for Male and F for Female.");
                var gender = Console.ReadLine();


                if (gender == "M" || gender == "m")
                {
                    Console.WriteLine("Your gender is : " + gender);
                    genderEnum = Gender.M;
                    genderIndexNullable = (int)genderEnum;
                    Console.WriteLine("Your genderIndexNullable is : " + genderEnum);
                }
                else if (gender == "F" || gender == "f")
                {
                    Console.WriteLine("Your gender is : " + gender);
                    Gender genderEnum = Gender.F;
                    genderIndexNullable = (int)genderEnum;
                    Console.WriteLine("Your genderIndexNullable is : " + genderEnum);
                }
                else
                {
                    Console.WriteLine("Invalid Input. Please enter a valid option. Use M for Male and F for Female.");
                    genderIndexNullable = null;
                }
            } while (genderIndexNullable == null);

            #endregion Gender

            #region RetirementAge

            if (age >= maleRetirementAge)
            {
                Console.WriteLine("You shall be already retired.");
            }
            else if ((age >= womanRetirementAge) && (age < maleRetirementAge))
            {
                if (genderEnum == Gender.F)
                {
                    Console.WriteLine("You are retired.");
                }
                else
                {
                    Console.WriteLine("You will be retired when you are 65 years old.");
                }

            }
            else if (age < womanRetirementAge)
            {
                if (genderEnum == Gender.F)
                {
                    Console.WriteLine("YYou will be retired when you are 63 years old.");
                }
                else
                {
                    Console.WriteLine("You will be retired when you are 65 years old.");
                }
            }

            #endregion RetirementAge

            #region String
            string givenString = "This is exercice number two from PentaStagiu Module01 Week02 ";

            Console.Write("Enter a few words: ");
            var inputString = Console.ReadLine();

            if (String.IsNullOrWhiteSpace(inputString))
            {
                Console.WriteLine("Error");
                return;
            }

            if (string.Compare(givenString, inputString) == 0)
            {
                Console.WriteLine("Cele doua string-uri sunt identice");
            }
            else
            {
                Console.WriteLine("Cele doua string-uri sunt diferite");
            }

            var trimedString = givenString.Trim();
            Console.WriteLine("Trim givenString: " +  trimedString);

            string upperCase = givenString.ToUpper();
            Console.WriteLine("Upper case string:" + upperCase);
        

            #endregion String

            Console.ReadKey();
        }
    }
}
