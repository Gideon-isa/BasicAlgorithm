using System.Text;
using System.Text.RegularExpressions;

namespace BasicAlgorithm;

class Program
{


    static void Main(string[] args)
    {
        System.Console.WriteLine("Enter all the numbers with a space seperated and press enter");

        //
        string userString = ProjectLibrary.collectUsersInput();

        //
        double[] numberArray = ProjectLibrary.ConvertToDoubleArray(userString);

        // 
        ProjectLibrary.CompareArray(numberArray);
        
    }

}
