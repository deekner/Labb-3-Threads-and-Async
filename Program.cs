using System.Xml.Linq;

namespace Labb_3_Threads_and_Async
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Cars Car1 = new Cars("BMW", 0);
            Cars Car2 = new Cars("Audi", 0);
            List<Cars> Cars = new List<Cars>() 
            { 
              Car1, 
              Car2
            };

            Thread BmwThread = new Thread(() => Car1.Dragstrip1("M5", 0));
            Thread AudiThread = new Thread(() => Car2.Dragstrip2("RS6", 0));


            //Starts Thread
            BmwThread.Start();
            AudiThread.Start();

            Car1.ShowCarStatus(Car1.Name, Car1.distance, Cars);
            Car2.ShowCarStatus(Car2.Name, Car2.distance, Cars);


            //Application stops when ALL threads has finished
            BmwThread.Join();
            AudiThread.Join();

            
            Console.WriteLine("Race has finished!");
            Console.ReadKey();

        }
        
    }
}