namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] person1 = Console.ReadLine().Split(' ');
            string[] person2 = Console.ReadLine().Split(' ');
            if (person1[1] == person2[1])
            {
                if(person1[1] == person2[1] && person1[0] == person2[0] && person1[1] == person1[0])
                    Console.WriteLine("Siblings");
                else if (person1[0] == person2[0])
                    Console.WriteLine("not siblings");
                else
                    Console.WriteLine("siblings");
            }
            else
                Console.WriteLine("not siblings");

            //sadsadsa

            //side branch

        }
      
    }
}
