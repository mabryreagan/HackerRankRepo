// See https://aka.ms/new-console-template for more information
using System.Security.Cryptography.X509Certificates;




internal class Solutuon
{
    public static void Main()
    {

        List<string> strings = new List<string> { "aba", "baba", "aba" ,"xzxb" };
        List<string> queries = new List<string> { "aba", "xzxb", "ab" };
       
        Result.matchingStrings(strings , queries);
        
    }

}



internal class Result
{
    public static void matchingStrings(List<string> strings , List<string> queries)
    {

        foreach (var item in queries)
        {
            var result = strings.Where(st => st == item);

        }
            
        
        

    }
}