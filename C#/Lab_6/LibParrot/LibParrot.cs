using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibAnimal;

namespace LibParrot
{
    public class Parrot : Animal
    {
        public void Speak()
        {
            Console.WriteLine("Попугай {0} разговаривает", this.name);
        }

        public void Fly()
        {
            Console.WriteLine("Попугай {0} летает", this.name);
        }

        public Parrot(string name, string breed, string color) : base(name, breed, color) { }

        public override string ToString()
        {
            return string.Format("--------------------------------------------------------\n" +
                "Данные про попугая:\n" +
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
