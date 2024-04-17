﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassesApp.Model
{
    internal abstract class AbstractAnimal
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public double Age { get; set; }

        public abstract void Speak();

        public virtual void Eat()
        {
            Console.WriteLine("Animal is eating");
        }

        public abstract override string ToString();
    }
}
