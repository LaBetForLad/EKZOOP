

namespace OOP_Exam
{
    class Veteran : Human
    {
        public Veteran(string name, int age, int experince) : base(name, age, experince)
        {
        }

        public override bool Shot()
        {
            return rand.Next(1, 100) <= 90 - 1 * Age;
        }
        
    }
}
