using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibAnimal;

namespace LibDog
{
    public class Dog : Animal
    {
        public void Bark()
        {
            Console.WriteLine("Собака {0} лает", this.name);
        }

        public void Jump()
        {
            Console.WriteLine("Собака {0} прыгает", this.name);
        }

        public Dog(string name, string breed, string color) : base(name, breed, color) { }

        public override string ToString()
        {
            return string.Format("--------------------------------------------------------\n" +
                "Данные про собаку:\n" +
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
