using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _47_InterfaceExample1
{
    // subclass chair that extends Furniture
    class Chair : Furniture, IDestroyable
    {
        public string DestructionSound { get; set; }
        // simple constructor
        public Chair(string color, string material)
        {
            this.Color = color;
            this.Material = material;
            DestructionSound = "ChairDestructionSound.mp3";
        }

        public void Destroy()
        {
            // when a chair gets destroyed we should play the destruction sound
            // and spawn the destroyed chair parts
            Console.WriteLine($"The {Color} chair was destroyed");
            Console.WriteLine("Playing destruction sound {0}", DestructionSound);
            Console.WriteLine("Spawning chair parts");
        }
    }
}
