using System;
using System.Collections.Generic;
using System.Linq;

namespace LambdaExpression
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> listPersonInCity = new List<Person>();
            AddRecords(listPersonInCity);
            RetrivingTopTwoRecordForAgeIsLessThanSixty(listPersonInCity);
            CheckingForTeenagerPerson(listPersonInCity);

        }

        private static void AddRecords(List<Person> listPersonInCity)
        {
            listPersonInCity.Add(new Person("20312452", "Ankit", "3 sai nagar wadi", 27));
            listPersonInCity.Add(new Person("20312445", "Rohan", "13 bhai nagar wadi", 35));
            listPersonInCity.Add(new Person("20312478", "Ankush", "45 ai nagar wadi", 25));
            listPersonInCity.Add(new Person("20312410", "Ravan", "77 si nagar wadi", 45));
            listPersonInCity.Add(new Person("20312495", "roj", "45 sa nagar wadi", 95));

        }
        private static void RetrivingTopTwoRecordForAgeIsLessThanSixty(List<Person> listPersonInCity)
        {
            foreach (Person person in listPersonInCity.FindAll(e => (e.Age < 60)).Take(3).ToList())
            { 
            Console.WriteLine("Name :" + person.Name + "Age : " + person.Age);
            }
        
        }

        private static void CheckingForTeenagerPerson(List<Person> listPersonInCity)
        {
            if (listPersonInCity.Any(e => (e.Age >= 13 && e.Age < 19)))
            {
                Console.WriteLine("Yes We Have teen Agers in lIst");
            }
            else
            {
                Console.WriteLine("No, We Dont Have Teen Agers in list");
            }
        
        }

    }
}
