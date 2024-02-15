namespace Lab5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            { 
                Circle c1 = new Circle(15);
                Console.WriteLine(c1.ToString());
                Circle c2 = new Circle(-5);
                Console.WriteLine(c2.ToString());
                Circle c3 = new Circle(0);
                Console.WriteLine(c3.ToString());
            }
            catch (InvalidRadiusException e) 
            {
                Console.WriteLine("Error: " + e.Message);
            }
        }
    }
}
