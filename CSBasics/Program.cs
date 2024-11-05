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

            bool stringLonger = isStringLonger("powershell", 20);


            Book newBook = new Book("CSBasics", 100);

            Console.WriteLine(newBook.CurrentPage);
            Console.WriteLine(newBook.Title);

            newBook.TurnPage();
            newBook.TurnPage();
            newBook.TurnPage();
            newBook.TurnPage();
            newBook.TurnPage();
            newBook.TurnPage();
            newBook.TurnPage();

            Console.WriteLine(newBook.CurrentPage);

        }
        private static void printGreeting(string name)
        {
            Console.WriteLine("Hello, " + name);
        }
        private static int methodName(int parameterOne, int parameterTwo)
        {
            return parameterOne - parameterTwo;
        }
        private static bool isStringLonger(string word, int number)
        {
            return word.Length > number;
        }

        

        
    }
}
