using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP_Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Human> humans = new List<Human>();
            humans.Add(new Newbie("Igor", 15, 5));
            humans.Add(new Experienced("Sergiu", 34, 4));
            humans.Add(new Veteran("Vlad", 57, 12));
            humans.Add(new Experienced("Ivan", 29, 7));
            humans.Add(new Newbie("Volodya", 17, 2));
            humans.Add(new Veteran("Alex", 32, 8));
            humans.Add(new Experienced("Vasiliu", 22, 3));

            foreach (var human in humans)
            {

                if (human.Shot())
                {
                    Console.WriteLine(human.ToString() + " - Shoted");
                    Console.ReadKey();

                }
                else
                {
                    Console.WriteLine(human.ToString() + " - Missed");
                    Console.ReadKey();
                }
            }

        }
    }
}