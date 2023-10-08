using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BasicAlgorithm
{
    public class ProjectLibrary
    {
        public static void CompareArray(double[] userNumberArray) 
        {
            double min = userNumberArray[0]; 
            double max = userNumberArray[0];

        for (int i = 0; i < userNumberArray.Length; i++)
        {
                for (int j = 1; j < userNumberArray.Length; j++)
                {
                    
                    if (userNumberArray[j] < min) 
                    {
                        min = userNumberArray[j];
                    }

                    if (userNumberArray[j] > max) 
                    {
                        max = userNumberArray[j];
                    }
                }
            }

            System.Console.WriteLine("minimum is: {0}", min);
            System.Console.WriteLine("maximum is: {0} ", max);
        }

        public static double[] ConvertToDoubleArray(string userString) 
        {
            string[] usersArray = userString.Split(" ");
            double[] userNumberArray = new double[usersArray.Length];

            for (int i = 0; i < usersArray.Length; i++)
            {
                try
                {
                    userNumberArray[i] = double.Parse(usersArray[i]);
                }
                catch (System.Exception e)
                {
                    
                    System.Console.WriteLine(e.Message);
                    System.Console.WriteLine("Please enter valid numbers with a space between them");
                    collectUsersInput();
                    
                }
                
            }

            return userNumberArray;
        }

        public static string collectUsersInput() 
        {
            repeat:
            string? userInput = Console.ReadLine();

            if ((userInput is not null) && !userInput.Equals("")) {
                userInput = userInput.Trim();
                userInput = Regex.Replace(userInput, "\\s{2,}", " "); 
            } 
            else 
            {
                Console.WriteLine("Kindly enter valid numbers");
                goto repeat;
            }

            return userInput;
        }
    }

    

}