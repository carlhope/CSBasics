namespace CSBasics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double pi = 3.14;
            bool isLearningCSharp = true;
            string favouriteFilm = "Matrix";
            favouriteFilm = "High School Musical";
            printGreeting("Charlie");
            Console.WriteLine(methodName(1, 2));

        }
        private static void printGreeting(string name)
        {
            Console.WriteLine("Hello, " + name);
        }
        private static int methodName(int parameterOne, int parameterTwo)
        {
            return parameterOne - parameterTwo;
        }
    }
}
