using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    abstract class Animal
    {
        public abstract string Name { get; set; }

        public Animal(string name)
        {
            Name = name;
        }
        public abstract void Say();

        public virtual void ShowInfo()
        {
            Console.WriteLine(Name);
            Say();
        }
    }
    class Cat : Animal
    {
        private string sound;
        private string name;
        public override string Name
        {
            get => name;
            set => name = value;    
        }
        public Cat(string name, string sound)
            : base(name)
        {
            this.sound = sound;
        }
        public override void Say()
        {
            Console.WriteLine(sound);
        }
    }

    class Dog : Animal
    {
        private string sound;
        private string name;
        public override string Name
        {
            get => name;
            set => name = value;
        }
        public string Sound
        {
            get => sound;
        }
        public Dog(string name, string sound)
            : base(name)
        {
            this.sound = sound;
        }
        public override void Say()
        {
            Console.WriteLine(sound);
        }
    }
}
