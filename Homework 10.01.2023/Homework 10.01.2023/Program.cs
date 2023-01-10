

using Homework_10._01._2023;
using Homework_10._01._2023.Exceptions;
using System.Collections.Generic;


#region Factorial Task

//Factorial(-5);
//static void Factorial(int num)
//{
//    try
//    {

//        int factorial = 1;
//        var result = 0;

//        if (num == 0)
//        {
//            throw new FactorialExceptions("Impossible 0!");
//        }

//        if (num >= 1)
//        {
//            for (int i = 1; i <= num; i++)
//            {
//                factorial *= i;
//                result = factorial;
//            }
//            Console.WriteLine(result);


//        }
//        else
//        {
//            throw new FactorialExceptions("Please Add Correct Number");
//        }

//    }
//    catch (Exception ex)
//    {
//        Console.WriteLine(ex.Message);
//    }


//}
#endregion

#region Person TASK delegate'siz

//Person person = new Person();
//static List<Person> ShowAllPerson()
//{
//    List<Person> persons = new List<Person>();

//    Person person1 = new();

//    person1.FullName = "Agazade Bextiyar";
//    person1.Address = "Baki";
//    person1.Salary = 1200;

//    Person person2 = new();

//    person2.FullName = "Babazade Elvin";
//    person2.Address = "Gence";
//    person2.Salary = 800;

//    Person person3 = new();

//    person3.FullName = "Sahmarova Sevinc";
//    person3.Address = "Mingecevir";
//    person3.Salary = 1650;

//    Person person4 = new();

//    person4.FullName = "Aliyev Habil";
//    person4.Address = "Sumgait";
//    person4.Salary = 750;

//    persons.Add(person1);
//    persons.Add(person2);
//    persons.Add(person3);
//    persons.Add(person4);

//    return persons;
//}

//ShowPersonInfo();
//static void ShowPersonInfo()
//{
//    var result = ShowAllPerson();

//    foreach (var item in result)
//    {
//        if (item.Salary > 1000)
//        {
//            Console.WriteLine($"{item.FullName}{item.Address}");
//        }

//    }
//}
#endregion


//DelegatedPersons calculate = new DelegatedPersons();
//calculate.ShowPersonThanSalary();