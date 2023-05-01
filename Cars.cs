using System;
using System.Collections.Generic;
using System.Diagnostics; //Stopwatch
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_3_Threads_and_Async
{
    public class Cars
    {
        public string Name { get; set; }
        public int distance { get; set; }       

        public Cars(string _name, int distance)
        {
            this.Name = _name;
            this.distance = distance;
        }

        List<Cars> cars = new List<Cars>();

        
        public void Dragstrip1(string name, int distance)
        {
             
            int randomOccuranceCounterDS1 = 0;

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start(); // Race is starting

           
            Console.WriteLine("{0} is accelerating ", name);
            
            for (int i = 0; i <= 50; i++)
            {

                Console.WriteLine($"{name} {i}");
                Thread.Sleep(1200); //KMH
                this.distance += 1; //Increments the distance "TICK" by one

                //Generates random number
                Random randomOccurance = new Random();

                //This if statement work so that it picks an random generated number between 0-50, if the number hits 0 which == 0
                //stands for it will run, so it's 1 in 50 that the first if statement runs
                if (randomOccurance.Next(50) <= 0 && stopwatch.ElapsedMilliseconds >= 30000 && randomOccuranceCounterDS1 < 1)
                {
                    Console.WriteLine("{0} ran out of fuel, proceeds to refuel...", name);
                    Thread.Sleep(30000);
                    Console.WriteLine("{0} is up and running!", name);

                    randomOccuranceCounterDS1++;
                    stopwatch.Restart();
                }
                //2 in 50 that random occurance happens so 6%
                if (randomOccurance.Next(50) <= 2 && stopwatch.ElapsedMilliseconds >= 30000 && randomOccuranceCounterDS1 < 1)
                {
                    Console.WriteLine("{0} got puncture, switching tire...", name);
                    Thread.Sleep(20000);
                    Console.WriteLine("{0} is up and running!", name);

                    randomOccuranceCounterDS1++;
                    stopwatch.Restart();
                }
                if (randomOccurance.Next(50) <= 5 && stopwatch.ElapsedMilliseconds >= 30000 && randomOccuranceCounterDS1 < 1)
                {
                    Console.WriteLine("{0} has to stop and wash the windshield", name);
                    Thread.Sleep(10000);
                    Console.WriteLine("{0} is up and running!", name);

                    randomOccuranceCounterDS1++;
                    stopwatch.Restart();
                }
                if (randomOccurance.Next(50) <= 10 && stopwatch.ElapsedMilliseconds >= 30000 && randomOccuranceCounterDS1 < 1)
                {
                    Console.WriteLine("{0} speeds changed miles per hour to 110kmh!", name);
                    Thread.Sleep(1500);

                    randomOccuranceCounterDS1++;
                    stopwatch.Restart();
                }

            }
            Console.WriteLine("{0} has reached the finish line!", name);
        }

        public void Dragstrip2(string name, int distance)
        {
            
            int randomOccuranceCounterDS2 = 0;

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
          
            Console.WriteLine("{0} is accelerating ", name);
            for (int i = 0; i <= 50; i++)
            {
                
                Console.WriteLine($"{name} {i}");
                Thread.Sleep(1200);
                this.distance += 1;

                Random randomOccurance = new Random();

                if (randomOccurance.Next(50) <= 0 && stopwatch.ElapsedMilliseconds >= 30000 && randomOccuranceCounterDS2 < 1) //2%
                {
                    Console.WriteLine("AUDI ran out of fuel, proceeds to refuel...", name);
                    Thread.Sleep(30000);
                    Console.WriteLine("AUDI is up and running!", name);

                    randomOccuranceCounterDS2++;
                    stopwatch.Restart();
                }
                if (randomOccurance.Next(50) <= 2 && stopwatch.ElapsedMilliseconds >= 30000 && randomOccuranceCounterDS2 < 1) //6%
                {
                    Console.WriteLine("AUDI got puncture, switching tire...", name);
                    Thread.Sleep(20000);
                    Console.WriteLine("AUDI is up and running!", name);

                    randomOccuranceCounterDS2++;
                    stopwatch.Restart();
                }
                if (randomOccurance.Next(50) <= 5 && stopwatch.ElapsedMilliseconds >= 30000 && randomOccuranceCounterDS2 < 1) //10%
                {
                    Console.WriteLine("AUDI has to stop and wash the windshield", name);
                    Thread.Sleep(10000);
                    Console.WriteLine("AUDI is up and running!", name);

                    randomOccuranceCounterDS2++;
                    stopwatch.Restart();
                }
                if (randomOccurance.Next(50) <= 10 && stopwatch.ElapsedMilliseconds >= 30000 && randomOccuranceCounterDS2 < 1)//22%
                {
                    Console.WriteLine("AUDI speeds changed miles per hour to 110kmh!", name);
                    Thread.Sleep(1500);
                    Console.WriteLine("Accelerating to normal speed of 120/KMH", name);

                    randomOccuranceCounterDS2++;
                    stopwatch.Restart();
                }              
            }
            Console.WriteLine("{0} has reached the finish line!", name);
        }

        public void ShowCarStatus(string name, int distance, List<Cars> cars)
        {
            while (true)
            {
                if (Console.KeyAvailable)
                {
                    if (Console.ReadKey().Key == ConsoleKey.Enter)
                    {
                        foreach (var car in cars)
                        {
                            Console.WriteLine("{0}: has traveled {1}km so far", car.Name, car.distance);
                        }
                    }
                }
            }
        }
    }
}
