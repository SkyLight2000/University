using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exceptions;

namespace LibAnimal
{
    public class Animal
    {
        protected string breed;
        protected string name;
        private int age;
        private int weight;
        protected string color;

        public Animal(string name, string breed, string color)
        {
            this.name = name;
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
                "Порода: {1}\n" +
                "Цвет: {2}\n" +
                "Возраст: {3}\n" +
                "Вес: {4} кг\n", name, breed, color, Age, Weight
                );
        }
    }
}
