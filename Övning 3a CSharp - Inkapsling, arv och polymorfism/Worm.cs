using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning_3a_CSharp___Inkapsling__arv_och_polymorfism
{
    public class Worm : Animal
    {
        public bool IsPoisonous { get; set; }
        public Worm(string name, double weight, int age, bool isPoisonous) : base(name, weight, age)
        {
            IsPoisonous = isPoisonous;
        }

        public override string DoSound()
        {
            return "grunt";

            //throw new NotImplementedException();
        }

        public override string Stats()
        {
            return base.Stats() + $"Is poisonous? {IsPoisonous}";
        }
    }
}
