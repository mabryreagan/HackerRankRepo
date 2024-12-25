// See https://aka.ms/new-console-template for more information
using System.ComponentModel;
using System.Diagnostics;
using System.Numerics;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;




internal class Solutuon
{
    public static void Main()
    {

        string time = "12:15:32:AM";
        Result.TimeConverter(time);
      
    }

}



public class Result
{
    internal static void TimeConverter(string time)
    {
        string meridum = time.Substring(time.Length - 2);
        string timePart = time.Substring(0, time.Length - 2);
        var hourMinSec = timePart.Split(':');

        string hours = hourMinSec[0];
        string min = hourMinSec[1];
        string sec = hourMinSec[2];

        if (int.TryParse(hours, out int intHours))
        {
            if (meridum == "AM" && intHours == 12)
            {
                intHours = 0;
            }

            else if (meridum == "PM")
            {
                intHours += 12;
            }

            hours = intHours.ToString("D2");
           
        }

        Console.Write($"{hours}:{min}:{sec}");
    }
    
    

}