// See https://aka.ms/new-console-template for more information
using System.ComponentModel;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;




internal class Solutuon
{
    public static void Main()
    {

        string time = "12:15:32:PM";

        Result.timeConverter(time);

    }

}



internal class Result
{
    public static void timeConverter(string time)
    {
        const int timeToAdd = 12;

        string hours;
        string minutes;
        string seconds;
        string meridium;

        List<String> hoursMinSec = time.Split(':').ToList();

        hours = hoursMinSec[0];
        minutes = hoursMinSec[1];
        seconds = hoursMinSec[2];
        meridium = hoursMinSec[3];


        if (meridium[0] != 'P')
        {
            Console.WriteLine($"{hours}:{minutes}:{seconds}:{meridium}");
        }
        else
        {
            if(int.TryParse(hours, out int hourTime))
            {
                hourTime += timeToAdd;
                if(hourTime == 24) { hourTime = 00; }
                meridium = "PM";
            }
            Console.WriteLine($"{hourTime}:{minutes}:{seconds}:{meridium}");
        }

    }
}