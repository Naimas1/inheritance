using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    internal class MusicalInstrument
    {
        protected string name;
        protected string characteristics;

        public MusicalInstrument(string name, string characteristics)
        {
            this.name = name;
            this.characteristics = characteristics;
        }

        public virtual void Sound()
        {
            Console.WriteLine("Musical instrument sound");
        }

        public void Show()
        {
            Console.WriteLine($"Musical instrument name: {name}");
        }

        public void Desc()
        {
            Console.WriteLine($"Musical instrument description: {characteristics}");
        }

        public virtual void History()
        {
            Console.WriteLine("Musical instrument history");
        }
    }

    class Violin : MusicalInstrument
    {
        public Violin(string name, string characteristics) : base(name, characteristics)
        {
        }

        public override void Sound()
        {
            Console.WriteLine("Violin sound: Screeeech");
        }

        public override void History()
        {
            Console.WriteLine("Violin history: Originated in the 16th century");
        }
    }

    class Trombone : MusicalInstrument
    {
        public Trombone(string name, string characteristics) : base(name, characteristics)
        {
        }

        public override void Sound()
        {
            Console.WriteLine("Trombone sound: Wah wah");
        }

        public override void History()
        {
            Console.WriteLine("Trombone history: Developed in the 15th century");
        }
    }

    class Ukulele : MusicalInstrument
    {
        public Ukulele(string name, string characteristics) : base(name, characteristics)
        {
        }

        public override void Sound()
        {
            Console.WriteLine("Ukulele sound: Plink plink");
        }

        public override void History()
        {
            Console.WriteLine("Ukulele history: Originated in Hawaii in the 19th century");
        }
    }

    class Cello : MusicalInstrument
    {
        public Cello(string name, string characteristics) : base(name, characteristics)
        {
        }

        public override void Sound()
        {
            Console.WriteLine("Cello sound: Deep and rich tones");
        }

        public override void History()
        {
            Console.WriteLine("Cello history: Originated in the 16th century");
        }
    }

    class Programas
    {
        static void Main(string[] args)
        {
            Violin violin = new Violin("Violin", "Four strings, played with a bow");
            violin.Show();
            violin.Desc();
            violin.Sound();
            violin.History();

            Trombone trombone = new Trombone("Trombone", "Brass instrument, played by sliding the slide");
            trombone.Show();
            trombone.Desc();
            trombone.Sound();
            trombone.History();

            Ukulele ukulele = new Ukulele("Ukulele", "Small guitar-like instrument with four strings");
            ukulele.Show();
            ukulele.Desc();
            ukulele.Sound();
            ukulele.History();

            Cello cello = new Cello("Cello", "Large string instrument played with a bow");
            cello.Show();
            cello.Desc();
            cello.Sound();
            cello.History();
        }
    }
}
