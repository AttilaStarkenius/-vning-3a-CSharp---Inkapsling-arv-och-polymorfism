using Övning_3a_CSharp___Inkapsling__arv_och_polymorfism;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace Övning_3a_CSharp___Inkapsling__arv_och_polymorfism
{
    public class PersonHandler
    {
        //public List<Person> PersonList = new List<Person>();

        public Person CreatePerson(string firstName = "Testname", int age = 10)
        {
            var person = new Person();
            person.FirstName = firstName;
            person.Age = age;

            return person;

        }

        public void SetAge(Person person, int age)
        {
            person.Age = age;
        }


        //PersonList.Remove(new Person(age, fname, lname, height, weight));
        //return new Person(age, fname, lname, height, weight);

        //    Age = age;
        //FName = fname;
        //LName = lname;
        //Height = height;
        //Weight = weight; 



    }
}
//Person person = new Person();
//person.Age = age;
//person.FName = fname;
//person.LName = lname;   
//person.Height = height;
//person.Weight = weight;
//return new Person();



