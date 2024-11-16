namespace MasterStreams
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("");
            Console.WriteLine("Time Checker");

            if (DateTime.Now.TimeOfDay > new TimeSpan(18, 0, 0))
            {
                Console.WriteLine("Ava manheru veduwe");
            }
            else {

                Console.WriteLine("Nguva iripo nyora mitsara");
            
            }

        }
    }
}
