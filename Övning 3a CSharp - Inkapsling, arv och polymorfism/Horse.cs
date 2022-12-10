using System.Reflection;

namespace PersonSound
{
    public class Horse : Animal, IPerson
    {
        public double Height { get; set; }
        public Horse(string name, double weight, int age) : base(name, weight, age)
        {
        }

        public override string DoSound()
        {
            return "huh";

            //throw new NotImplementedException();
        }

        public override string Stats()
        {
            return base.Stats() + $"Height: {Height}";
        }

        public string Talk()
        {
            return "I'm a horse!";
        }


        //public override string Stats(Animal animal)
        //{
        //    Type myType = animal.GetType();
        //    IList<PropertyInfo> props = new List<PropertyInfo>(myType.GetProperties());

        //    foreach (PropertyInfo prop in props)
        //    {
        //        string s = JsonConvert.SerializeObject(prop.GetValue(animal, null));
        //        Console.WriteLine(s);
        //        return s;

        //        //string s = JsonConvert.SerializeObject(yourObject);

        //        //object propValue = prop.GetValue(myObject, null);

        //        // Do something with propValue
        //    }
        //    return "No such animal";
        //    //throw new NotImplementedException();
        //}
    }
}

