
using System;

namespace OOP_Exam
{
    abstract class Human
    {
        protected Human(string name, int age, int experince)
        {
            Name = name;
            Age = age;
            Experince = experince;
        }
        protected Random rand = new Random();
        protected string Name { get; set; }
        protected int Age { get; set; }
        protected int Experince { get; set; }

        abstract public bool Shot();
        public override string ToString()
        {
            return "Name: " + Name + ", Age: " + Age + ", Expirience: " + Experince;
        }

    }
}
