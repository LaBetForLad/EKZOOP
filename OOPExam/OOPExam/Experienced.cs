
namespace OOP_Exam
{
    class Experienced : Human
    {
        public Experienced(string name, int age, int experince) : base(name, age, experince)
        {

        }

        public override bool Shot()
        {
            return rand.Next(1, 100) <= 5 * Experince;

        }

    }
}
