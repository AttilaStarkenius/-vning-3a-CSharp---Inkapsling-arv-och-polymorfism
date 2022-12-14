using Övning_3a_CSharp___Inkapsling__arv_och_polymorfism;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning_3a_CSharp___Inkapsling__arv_och_polymorfism
{
    public class Wolfman : Wolf, IPerson
    {
        public int ShoeSize { get; set; }
        public Wolfman(string name, double weight, int age, int numberOfPups, int shoeSize) : base(name, weight, age, numberOfPups)
        {
            ShoeSize = shoeSize;
        }
        public string Talk()
        {
            // The body of Talk() is provided here
            return "The Wolfman says: Hey";
        }
        

        //public void Talk()
        //{
        //    throw new NotImplementedException();
        //}
    }
}
