using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3x_1LearningProgress
{
    public class My3XPlus1
    {
        /// <summary>
        /// list holds the data generated 
        /// </summary>

        private readonly List<long> DataList; //after calculation 

        private Form1 Form1;

        public List<long> DataListPublic => this.DataList;

        /// <summary>
        /// default constructor 
        /// </summary>
        public My3XPlus1()
        {
            this.DataList = new List<long>(); //ignore

        }
        //------------------------------------------------------------------------------------------
        /// <summary>
        /// 
        /// </summary>
        /// basically the disctionary helps store and move the saved number (calculated) 
        /// <summary>
        /// Calculates the 3x + 1 sequence for each number in the provided list.
        /// </summary>
        public Dictionary<int, List<int>> CalculateForList(List<int> numbers)
        {
            var results = new Dictionary<int, List<int>>();

            foreach (var number in numbers)
            {
                results[number] = Calculate(number);
            }

            return results; 
        }

        //----------------------------------------------------------------------------------------
        /// <summary>
        /// Method that takes in number from data structure (textbox input) and sends it to formula method
        /// Calculate
        /// </summary>
        /// <summary>
        /// Calculates the 3x + 1 sequence for a single number.
        /// </summary>
        public List<int> Calculate(int number)
        {
            List<int> results = new List<int>(); //adds final answer to data structure

            while (number != 1) //this is when the famous calculation starts
            {
                results.Add(number);
                if (number % 2 == 0) //if the number is even , divide
                {
                    number /= 2;
                }
                else
                {
                    number = 3 * number + 1; //else , if odd , multiple by 3
                }
            }
            results.Add(1); // Add the final 1 to the list

            return results; //returns the answer for graph displaying
        }

        

        
    }
}

  

   

