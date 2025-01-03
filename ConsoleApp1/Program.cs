// See https://aka.ms/new-console-template for more information
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;


public class Program
{
    static void Main()
    {
        int targetSize = 32;

        int num = 1001;
        string numString = num.ToString();

        int zeroToAppend = targetSize - numString.Length;

        while (zeroToAppend > 0)
        {
            numString = '0' + numString;

            zeroToAppend--;
        }


        Results.FlipBits(numString);
       
       
    }

}


public static class Results
{

    public static void FlipBits(string num)
    {

        string flippedNum = string.Empty;

        foreach (var c in num)
        {
            if (c == '0')
            {
                flippedNum = flippedNum + '1';
            }
            else
            {
                flippedNum = flippedNum + '0';
            }
        }

        Converter.ConvertString(flippedNum);

    }

}


public static class Converter
{

    public static void ConvertString(string stringToConvert)
    {
        int exp = 0;
        long sum = 0;

        foreach(var c in stringToConvert)
        {
         
            sum += (c - '0') * (long)Math.Pow(2 ,exp);
            exp++;
        }

        

    }


}













