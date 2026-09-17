using System;
using System.Collections.Generic;
using System.Text;

namespace Tamagotchi
{
    internal class TamagotchiZburator : Tamagotchi //Scriind ": Tamagotchi" dupa numele clasei informeaza compilatorul ca aceasta clasa e derivata din clasa Tamagotchi
    {   //Suprascrierea efectiva a metodei ScoateSunet() din clasa de baza. Metoda va fi actualizata in clasa Tamagotchi astfel incat sunetul sa fie scos in fucntie de starea de spirit a Tamagotchi-ului
        public override void ScoateSunet()
        {
            Console.WriteLine("Flap, flap!");
        }
    }
}
