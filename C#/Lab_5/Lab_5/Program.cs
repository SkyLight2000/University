using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5
{
    class Animal
    {
        private string type;
        private string breed;
        private string name;
        private int age;
        private int weight;
        private string color;

        public Animal(string name, string type, string breed, string color)
        {
            this.name = name;
            this.type = type;
            this.breed = breed;
            this.color = color;
        }

        public int Age
        {
            get { return age; }
            set
            {
                if (value > 0)
                    age = value;
                else
                    throw new InvalidAgeException();
            }
        }

        public int Weight
        {
            get { return weight; }
            set
            {
                if (value > 0)
                    weight = value;
                else
                    throw new InvalidWeightException();
            }

        }

        public override string ToString()
        {
            return string.Format("--------------------------------------------------------\n" +
                "Данные про животное:\n" +
                "--------------------------------------------------------\n" +
                "Имя: {0}\n" +
                "Вид: {1}\n" +
                "Порода: {2}\n" +
                "Цвет: {3}\n" +
                "Возраст: {4}\n" +
                "Вес: {5} кг\n", name, type, breed, color, Age, Weight
                );
        }
    }

    class AnimalException : Exception
    {
        public AnimalException(string messange) : base(messange) { }
    }

    class InvalidAgeException : AnimalException
    {
        public InvalidAgeException() : base("Invalid age input") { }
    }

    class InvalidWeightException : AnimalException
    {
        public InvalidWeightException() : base("Invalid weight input") { }
    }



    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------------------Животное--------------------------");
            Animal Reks = new Animal("Рекс", "Собака", "Овчарка", "Черный");
            Reks.Age = 3;
            Reks.Weight = 30;
            Console.WriteLine(Reks);
            Animal Barsik = new Animal("Барсик", "Кот", "Домашний", "Белый");
            Barsik.Age = 3;
            Barsik.Weight = 5;
            Console.WriteLine(Barsik);
            Console.ReadKey();
        }
    }
}