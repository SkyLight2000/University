using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibDog;
using LibCat;
using LibParrot;


namespace Lab_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog Reks = new Dog("Рекс", "Овчарка", "Черный");
            Reks.Age = 3;
            Reks.Weight = 34;
            Console.WriteLine(Reks);
            Reks.Bark();
            Reks.Jump();
            Cat Barsik = new Cat("Барсик", "Домашний", "Белый");
            Barsik.Age = 3;
            Barsik.Weight = 5;
            Console.WriteLine(Barsik);
            Barsik.Meow();
            Barsik.Jump();
            Parrot Jack = new Parrot("Джек", "Калита", "Зеленый");
            Jack.Age = 1;
            Jack.Weight = 1;
            Console.WriteLine(Jack);
            Jack.Speak();
            Jack.Fly();
        }
    }
}