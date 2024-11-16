namespace MasterStreams
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("");
            Utilities.printInput("Time CHecker");

            if (DateTime.Now.TimeOfDay > new TimeSpan(18, 0, 0))
            {
                Utilities.printInput("Ava manheru veduwe");
            }
            else {

                Utilities.printInput("Nguva iripo nyora mitsara");
            
            }

            for (int i = 0; i < 10; i++) {

                Utilities.printInput(i);
            
            }

            Console.WriteLine("Just an update from a different Machine");

        }
    }
}
