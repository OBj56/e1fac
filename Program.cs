using System;
using System.ComponentModel.Design;
using System.Text.RegularExpressions;
using static System.Console;
using static System.Math;

class Hurricane
{
    static void Main()
    {
        Write("Enter wind speed in Miles Per Hour: ");
        string input = ReadLine();

        string winds = Regex.Match(input, @"\d+").Value;

        if (int.TryParse(winds, out int windSpeed))
        {


            if (windSpeed >= 157)
            {
                Write("Category Five Hurricane");
            }
            else if (windSpeed >= 130)
            {
                Write("Category Four Hurricane");
            }
            else if (windSpeed >= 111)
            {
                Write("Category Three Hurricane");
            }
            else if (windSpeed >= 96)
            {
                Write("Category Two Hurricane");
            }
            else if (windSpeed >= 74)
            {
                Write("Category One Hurricane");
            }
            else
            {
                Write("Not a Hurricane");
            }
        }


       
    }
}
    
