using System.Reflection.Metadata.Ecma335;

namespace Day4
{
    class Program
    {
        int numberOfVisitors;
        string bear;
        decimal deposit;
        char character;

        public Program(int numberOfVisitors,string bear,decimal deposit,char character)
        {
            this.numberOfVisitors = numberOfVisitors;
            this.bear = bear;
          this.deposit = deposit;
            this.character = character;
        }

        static void Main(string[] args)
        {
            Program program = new Program(4,"Dotnet",100M,'A');
            Console.WriteLine(program.bear);
            Console.WriteLine(program.numberOfVisitors);
            Console.WriteLine(program.deposit);

            //understang unicode 
            int uniCodeValue = Convert.ToInt32(program.character);
            Console.WriteLine(uniCodeValue);

            int unicodeDirect = (int)program.character;
            Console.WriteLine(unicodeDirect);

            //String
            Console.WriteLine("Hello World");
            //literal strings
            Console.WriteLine("\"Hello\"");
            //escape characters 
            Console.WriteLine("Hello\nWorld");
            //verbatim Strings 
            Console.WriteLine(@"Hello\n");

            const int earthRadius = 6378;
            Console.WriteLine(earthRadius);
            int x = 123456;
            long y = x;
            Console.WriteLine(y);

        }
    }
}
