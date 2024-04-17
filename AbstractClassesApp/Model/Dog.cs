using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassesApp.Model
{
    internal class Dog : AbstractAnimal
    {
        public override void Eat()
        {
            base.Eat();
            Console.WriteLine("Animal is Dog!");
        }

        public override void Speak()
        {
            Console.WriteLine("Dog say hello!");
        }

        public override string ToString()
        {
            return $"Id: {Id} Name: {Name} Age: {Age}";
        }
    }
}
