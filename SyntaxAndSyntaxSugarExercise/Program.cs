using System.Threading.Channels;

namespace SyntaxAndSyntaxSugarExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
           var answer = 10;
           var response = answer < 9 ? $"{answer} is less that nine" : $"{answer} is greater than or equal to nine";
           Console.WriteLine(response);
        }
    }
}