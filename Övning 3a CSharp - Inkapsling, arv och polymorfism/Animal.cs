using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning_3a_CSharp___Inkapsling__arv_och_polymorfism
{
    public abstract class Animal
    {
        /*10.11.2022. If every animal needs a new property,
         it should be added in this "Animal.cs" class.*/
        public string Name { get; set; }
        public double Weight { get; set; }
        public int Age { get; set; }

        public Animal(string name, double weight, int age)
        {
            Name = name;
            Weight = weight;
            Age = age;
        }

        //public abstract string Stats(Animal animal);
        //{
        //    return "chirp";

        //throw new NotImplementedException();
        //}

        public abstract string DoSound();

        public virtual string Stats()
        {
            return $"Species: {this.GetType().Name}, Name: {Name}, Weight: {Weight}, Age: {Age}, ";
        }


    }
}
