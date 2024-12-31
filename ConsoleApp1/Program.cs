// See https://aka.ms/new-console-template for more information
using System.Security.Cryptography.X509Certificates;




internal class Solutuon
{
    public static void Main()
    {

        List<int> nums = new List<int> { 1, 2, 3, 4, 3, 2, 1 };

        Result.LonelyInteger(nums);
        
    }

}



internal class Result
{
    public static void LonelyInteger(List<int> nums)
    {
        int value;

        foreach(int n in nums)
        {

          int result =  nums.Count(x => x == n);
          if(result == 1)
            {
                value = n;
                break;
            }

        }

        

      

       

 

    }
}