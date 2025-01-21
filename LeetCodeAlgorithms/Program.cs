namespace LeetCodeAlgorithms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var currentExercise = new RomanToInteger();

            var test = currentExercise.RomanToInt("IX");

            Console.WriteLine(test);
        }
    }
}
