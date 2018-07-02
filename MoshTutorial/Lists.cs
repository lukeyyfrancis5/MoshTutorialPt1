using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoshTutorial
{
    class Lists
    {
             /*
             Write a program and continuously ask the user to enter different names, 
             until the user presses Enter(without supplying a name). Depending on the 
             number of names provided, display a message based on the above pattern.
             */
             
             public void Problem1()
             {
                 var names = new List<string>();
     
                 while (true)
                 {
                     Console.Write("Please type name or ENTER to quit:");
     
                     var input = Console.ReadLine();
                     if (string.IsNullOrWhiteSpace(input))
                         break;
                     names.Add(input);
     
                     if (names.Count > 2)
                         Console.WriteLine("{0}, {1}, {2}", names[0], names[1], names.Count - 2);
     
                     if (names.Count == 2)
                         Console.WriteLine("{0}, {1}, liked your post !", names[0], names[1]);
     
                     if (names.Count == 1)
                         Console.WriteLine("{0}, liked your post !", names[0]);
                     else
                         Console.WriteLine();
                     
                 }
             }
             

        /*
        Write a program and ask the user to enter their name.Use an array to reverse the name 
        and then store the result in a new string. Display the reversed name on the console.
        */

        public void Problem2()
        {
            Console.Write("Please Enter Name !");

            var name = Console.ReadLine();

            var array = new char[name.Length];
            for (var i = name.Length; i > 0; i--)
            {
                array[name.Length - 1] = name[i - 1];

                var reversed = new string(array);
                Console.WriteLine("Reversed Name:" + reversed);
            }
        }

        /*
        Write a program and ask the user to enter 5 numbers.If a number has been previously 
        entered, display an error message and ask the user to re-try. Once the user successfully 
        enters 5 unique numbers, sort them and display the result on the console.
        */

        public void Problem3()
        {
            var numbers = new List<int>();

            while (numbers.Count < 5)
            {

                Console.Write("Please enter 5 numbers: ");

                var number = Convert.ToInt32(Console.ReadLine());


                if (numbers.Contains(number))
                {
                    Console.WriteLine("Sorry you already entered:" + number);
                    continue;
                }


                numbers.Add(number);
            }

            numbers.Sort();

            foreach (var blah in numbers)

                Console.WriteLine(blah);
        }

        /*
        Write a program and ask the user to continuously enter a number or type "Quit" 
        to exit. The list of numbers may include duplicates. Display the unique numbers 
        that the user has entered.
        */


            public void Problem4()
            {
                var numberss = new List<int>();

                while (true)
                {
                    Console.WriteLine("Please enter number (or press 'Quit' to exit): ");
                    var input = Console.ReadLine();

                    if (input.ToLower() == "quit")
                        break;
                    numberss.Add(Convert.ToInt32(input));

                }

                var unique = new List<int>();
                foreach (var number in numberss)
                {
                    if (!unique.Contains(number))
                        unique.Add(number);
                }

                Console.WriteLine("Unique Numbers:");
                foreach (var number in unique)
                {
                    Console.WriteLine(number);
                }

            }

            /*
            Write a program and ask the user to supply a list of comma separated numbers(e.g 5, 1, 9, 2, 10). 
            If the list is empty or includes less than 5 numbers, display "Invalid List" and ask the user 
            to re-try; otherwise, display the 3 smallest numbers in the list.
            */

            public void Problem5()
            {
                string[] elements;

                while (true)
                {
                    Console.WriteLine("Please enter a list of comma- seperated numbers: ");
                    var input = Console.ReadLine();

                    if (!String.IsNullOrWhiteSpace(input))
                    {
                        elements = input.Split(',');
                        if (elements.Length >= 5)
                            break;
                    }

                    Console.WriteLine("Sorry this is an invalid list !");
                }

                var numbersLists = new List<int>();
                foreach (var number in elements)

                    numbersLists.Add(Convert.ToInt32(number));

                var smallests = new List<int>();
                while (smallests.Count < 3)
                {
                    // Assuming first number is smallest
                    var min = numbersLists[0];

                    foreach (var number in numbersLists)
                    {
                        if (number < min)
                            min = number;
                    }

                    smallests.Add(min);

                    numbersLists.Remove(min);
                }

                Console.WriteLine("The 3 smallest numbers are: ");

                foreach (var number in smallests)
                    Console.WriteLine(number);


            }


    }
}

