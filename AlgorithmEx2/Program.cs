using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmEx2
{
    //Algorithms: Consider the set A = { 2 ^ a * 3 ^ b * 5 ^ c * 7 ^ d | a, b, c, d are integers and a, b, c, d >= 0 } where ^ denotes exponentiation.
    //Write a program to output A in increasing order in language you that you most wanted to learn. Explain why the language used is good or bad for the problem
    class Program
    {           
        static void Main(string[] args)
        {
            Console.WriteLine("This program will calculate the Algorithm A= 2^a * 3^b * 5*c *7*d where a, b, c, d are integers and are greater than or equal to zero. " +
                "The program will ask the user how many times to calculate the value A and then output the values in increaisng order. Values a, b, c, d will be randomly" +
                "generated for the values of a, b, c, d between (0-5)\n");
            Console.WriteLine("Please enter the how many time's to calulate the value A");   //ask user for input
            int n = int.Parse(Console.ReadLine());
            
            int a, b, c, d;                             //initialise variables
            Random robj = new Random();                //porogram will select 3 random variables
                                          
            StringBuilder ValueA = new StringBuilder();  //string builder
                      
            for (int i = 1; i <= n; i++)
            {
                a = robj.Next(0, 5);
                b = robj.Next(0, 5);
                c = robj.Next(0, 5);
                d = robj.Next(0, 5);
                double pow_a = Math.Pow(2, a);
                double pow_b = Math.Pow(3, b);
                double pow_c = Math.Pow(5, c);
                double pow_d = Math.Pow(7, d);
                double A = pow_a * pow_b * pow_c * pow_d;

                Console.WriteLine("The randomly generated values of a, b, c, d are:");
                Console.WriteLine("a=={0}, b=={1}, c=={2}, and d=={3}", a, b, c, d);
                Console.WriteLine(A);
                
                ValueA.Append(A + " ");         //string builder
               
            }
                      
            Console.WriteLine("\nThe unsorted values of A are: "+ ValueA.ToString());  //stringbuilder= object to string
            var words = ValueA.ToString();                                      //convert from object to string
            //Console.WriteLine(words);                                         //test
            //Console.WriteLine(words.GetType());                               //confirm datatype
            string[] wordsplit = words.Split(' ');                              //system string need foreach to view
            //Console.WriteLine(wordsplit);                                       //system string[] need foreach to view
            /*foreach (string var in wordsplit)                                   //split numbers into seperate strings test
            {
                                Console.WriteLine("{0}", var);
            }*/

            List<int> IntList = new List<int>();                                //create a list for number after converted

            foreach (string var in wordsplit)                               //for each string variable test to convert to number 
            {
                int number;
                

                bool success = Int32.TryParse(var, out number);
                if (success)
                {
                    IntList.Add(number);                                            //if test converts add number to the list
                    Console.WriteLine("Converted '{0}' to {1}.", var, number);
                                        
                }
                else
                {
                    Console.WriteLine("Attempted conversion of '{0}' failed.",
                                       var ?? "<null>");
                }
                   
                 //Console.WriteLine(IntList);                                      //testing
                //Console.WriteLine(IntList.GetType());                             //testing
            }
            IntList.Sort();                                                     //sort the list integer list                        

            Console.WriteLine("\nThe sorted list is: ");
            foreach (int li in IntList)                                         //need foreach to see data type list
            {
                Console.WriteLine(li);
            }

            Console.Read();

        }
        
    }
}
