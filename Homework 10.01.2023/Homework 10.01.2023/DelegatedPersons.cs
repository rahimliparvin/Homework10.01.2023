using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//namespace Homework_10._01._2023
//{
//    public class DelegatedPersons
//    {
//        public delegate bool CheckPerson(Person person);

//        public bool GetPerson(Person person)
//        {
//            return (person.Salary > 1000);

//        }


//        public void ShowPersonThanSalary()
//        {
//            List<Person> persons = new List<Person>();

//            Console.WriteLine(ShowPersonInfo(GetPerson, persons));

//            //var result = persons.FindAll(m=> m.Salary > 1000);
//            //  foreach (var person in result)
//            //  {
//            //      Console.WriteLine(person.FullName + " - " + person.Address);
//            //  }


//        }



//        static List<Person> ShowAllPerson()
//        {
//            List<Person> persons = new List<Person>();

//            Person person1 = new();

//            person1.FullName = "Agazade Bextiyar";
//            person1.Address = "Baki";
//            person1.Salary = 1200;

//            Person person2 = new();

//            person2.FullName = "Babazade Elvin";
//            person2.Address = "Gence";
//            person2.Salary = 800;

//            Person person3 = new();

//            person3.FullName = "Sahmarova Sevinc";
//            person3.Address = "Mingecevir";
//            person3.Salary = 1650;

//            Person person4 = new();

//            person4.FullName = "Aliyev Habil";
//            person4.Address = "Sumgait";
//            person4.Salary = 750;

//            persons.Add(person1);
//            persons.Add(person2);
//            persons.Add(person3);
//            persons.Add(person4);

//            return persons;
//        }


//        static void ShowPersonInfo(CheckPerson func, List<Person> persons)
//        {
//            var result = ShowAllPerson();

//            foreach (var item in result)
//            {
//                if (func(item))//(item.Salary > 1000)
//                {
//                    Console.WriteLine($"{item.FullName}{item.Address}");
//                }

//            }
//        }

//    }
//}
