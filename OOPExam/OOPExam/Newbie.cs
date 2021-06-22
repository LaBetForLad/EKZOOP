
namespace OOP_Exam
{
    class Newbie : Human
    {
        public Newbie(string name, int age, int experince) : base(name, age, experince)
        {
        }

        public override bool Shot()
        {
            return rand.Next(1, 100) <= 1 * Experince;
        }

    }
}
