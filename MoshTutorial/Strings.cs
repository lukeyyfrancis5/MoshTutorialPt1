using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoshTutorial
{
    class Strings
    {
        /*1- Write a program and ask the user to enter a few numbers separated by a hyphen.
         Work out if the numbers are consecutive. For example, if the input is "5-6-7-8-9" or 
         "20-19-18-17-16", display a message: "Consecutive"; otherwise, display "Not Consecutive".
         */

        public void Problem1()
        {
            Console.WriteLine("Please enter a few numbers (ex. 5-4-6-7-3): ");

            var input = Console.ReadLine();

            var numbers = new List<int>();

            foreach (var number in input.Split('-'))
                numbers.Add(Convert.ToInt32(number));

            numbers.Sort();

            var iConsec = true;

            for (var i = 1; i < numbers.Count; i++)
            {
                if (numbers[i] != numbers[i - 1] + 1)
                {
                    iConsec = false;
                    break;
                }

            }

            var message = iConsec ? "Consecutive" : "Not Consecutive";
            Console.WriteLine(message);



        }

        /*
        2- Write a program and ask the user to enter a few numbers separated by a hyphen.If the 
        user simply presses Enter, without supplying an input, exit immediately; otherwise, check 
        to see if there are duplicates.If so, display "Duplicate" on the console.
        */

        public void Problem2()
        {
            Console.WriteLine("Please enter a few numbers (ex. 2-3-4-4-2): ");

            var input = Console.ReadLine();

            if (String.IsNullOrWhiteSpace(input))

                return;

            var numbers = new List<int>();

            foreach (var number in input.Split('-'))

                numbers.Add(Convert.ToInt32(number));


            var uniques = new List<int>();

            var includesDupes = false;

            foreach (var number in numbers)
            {
                if (!uniques.Contains(number))
                    uniques.Add(number);

                else
                {
                    includesDupes = true;
                    break;
                }
            }

            if (includesDupes)
                Console.WriteLine("Duplicate");

        }

        /*
        Write a program and ask the user to enter a time value in the 24-hour time format(e.g. 19:00). 
        A valid time should be between 00:00 and 23:59. If the time is valid, display "Ok"; otherwise, 
        display "Invalid Time". If the user doesn't provide any values, consider it as invalid time.
        */

        public void Problem3()
        {
            Console.WriteLine("Enter time: ");

            var input = Console.ReadLine();

            if (String.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Sorry invalid time");
                return;
            }

            var components = input.Split(':');
            if (components.Length != 2)
            {
                Console.WriteLine("Sorry invalid time");
                return;
            }

            try
            {
                var hour = Convert.ToInt32(components[0]);
                var minute = Convert.ToInt32(components[1]);

                if (hour >= 0 && hour <= 23 && minute >= 0 && minute <= 50)
                    Console.WriteLine("This works !");
                else
                    Console.WriteLine("Invalid time");
            }
            catch
            {
                Console.WriteLine("Invalid time !");
            }
        }

        /*
        Write a program and ask the user to enter a few words separated by a space. 
        Use the words to create a variable name with PascalCase. For example, if the 
        user types: "number of students", display "NumberOfStudents". Make sure that 
        the program is not dependent on the input. So, if the user types "NUMBER OF 
        STUDENTS", the program should still display "NumberOfStudents".
        */

        public void Problem4()
        {
            Console.WriteLine("Please enter a few words: ");

            var input = Console.ReadLine();

            if (String.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Error !");
                return;
            }

            var varName = "";
            foreach (var word in input.Split(' '))
            {
                var pascWord = char.ToUpper(word[0]) + word.ToLower().Substring(1);
                varName += pascWord;
            }

            Console.WriteLine(varName);
        }

        /*
        Write a program and ask the user to enter an English word. Count the number of vowels 
        (a, e, o, u, i) in the word. So, if the user enters "inadequate", the program should 
        display 6 on the console.
        */

        public void Problem5()
        {
            Console.WriteLine("Please enter a word: ");

            var input = Console.ReadLine().ToLower();

            var vowels = new List<char>(new char[] { 'a', 'e', 'i', 'o', 'u' });

            var vowelCount = 0;

            foreach (var character in input)
            {
                if (vowels.Contains(character))
                    vowelCount++;
            }

            Console.WriteLine(vowelCount);
        }


    }
}
