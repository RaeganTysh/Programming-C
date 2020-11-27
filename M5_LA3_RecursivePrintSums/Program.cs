using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M5_LA3_RecursivePrintSums
{
    class Program
    {
        //Write a recursive function that prints a pyramid of numbers found by adding adjacent numbers in a List. Each line of the pyramid should contain a set of numbers that are the sum of the 2 numbers
        //above it in the pyramid. For example, if you were given a list containing the numbers {1, 3, 5, 2, 4}, the second line of the pyramid would be {4, 8, 7, 6} (i.e., 1+3=4, 3+5=8, 5+2=7, and 2+4=6). 
        //Use recursion to repeat this process using the new data as the input. The full output for the program given these numbers would be:
        //Hint- recursive methods using lists- first list, 2nd list cretes and calculation on the newlist...and so on true until list has only 1 item
        static void DisplayList(List<int> myList, int space)

        {
           
            List<int> newList = new List<int>();                    //create a new list
            for (int i = 0; i < myList.Count - 1; i++)              //index access over the previous loop-this allows us to create a new list that has one less item
            {
                newList.Add(myList[i] + myList[i + 1]);     //the first item plus the second item in the first list become the new item in the second list then the second item plus the 3rd item in the 
                                                               //olde list become the second value in the new list ect..
            }
            if(newList.Count>=1)                            //make a recursive condition with the new list- needs to be conditional (do not what an infinite recursive condition) at least one item
            {
                DisplayList(newList, space+1);                       //if at least one item then call function again.
            }
            if (myList.Count >= 1)                     //check to make sure the list has at least one item -set up recursive branch 
            {
                for (int i = 0; i < space; i++)              //this loop is to incoproatet the space in the formatting 
                {
                    Console.Write("  ");
                }
                foreach (var item in myList)
                {
                    //Console.Write(item + " ");                               //this just prints the first line with spaces
                    Console.Write(string.Format("{0,3}", item) + " ");              //add the formatting- first line no space
                }
                Console.WriteLine();                            //ensures that each is printed on a new line          
            }
        }
    
       
        static void Main(string[] args)
        {

            List<int> myList = new List<int>() { 1, 3, 5, 2, 4 };
            DisplayList(myList, 0);                         //0 is the space parameter for the loop to create formatting
            Console.Read();


        }
    }
}
