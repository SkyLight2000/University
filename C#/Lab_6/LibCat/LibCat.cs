using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibAnimal;

namespace LibCat
{
    public class Cat : Animal
    {
        public void Meow()
        {
            Console.WriteLine("Кот {0} мявчит", this.name);
        }

        public void Jump()
        {
            Console.WriteLine("Кот {0} прыгает", this.name);
        }

        public Cat(string name, string breed, string color) : base(name, breed, color) { }

        public override string ToString()
        {
            return string.Format("--------------------------------------------------------\n" +
                "Данные про кота:\n" +
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
