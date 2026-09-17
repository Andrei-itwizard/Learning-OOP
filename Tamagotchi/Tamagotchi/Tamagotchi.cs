using System;
using System.Collections.Generic;
using System.Text;

namespace Tamagotchi
{
    internal class Tamagotchi
    {   //Incapsulare. Aceste date nu pot fi accesate direct din exteriorul clasei, ci doar prin intermediul metodelor publice.
        //Actualizare: deoarece vreau sa creez o clasa separata pentru un alt tip de Tamagotchi (TamagotchiZburator), am schimbat modificatorul de acces de la private la protected, pentru a permite mostenirea acestor atribute in clasa derivata.
        protected int _nivelFoame;
        protected int _energie;
        protected int _nivelFericire;

        //Constructorul clasei Tamagotchi. Acesta este apelat atunci când se creează un obiect de tip Tamagotchi.
        //Nu are parametri deoarece e folosit doar ca sa intializeze NivelFoame, Energie si NivelFericire la valorile alese de mine
        public Tamagotchi()
        {
            _nivelFoame = 0;
            _energie = 100;
            _nivelFericire = 100;
        }

        /*Inainte de a trece la implementarea metodelor de interactionare cu Tamagotchi-ul trebuie creat un alt set de metode publice
        care sa returneze nivelurile de foame, energie si fericire ale Tamagotchi-ului (aka "Getters")*/
        public int NivelFoame
        {
            get { return _nivelFoame; }
        }

        public int Energie
        {
            get { return _energie; }
        }

        public int NivelFericire
        {
            get { return _nivelFericire; }
        }
        //Sa cream niste metode prin care utilizatorul poate interactiona cu Tamagotchi-ul!
        public void Hraneste()
        {
            _nivelFoame -= 10;
            _energie += 5;
            _nivelFericire += 5;
        /*Si fiecare metoda vine la pachet cu exceptiile ei. De exemplu, daca nivelul de foame e deja 0, atunci Tamagotchi-ul n-ar mai
        trebui sa poata fi hranit, daca are deja energie 100 n-ar trebui sa se simta si mai energic, etc.*/
            if (_nivelFoame == 0)
            {
                throw new Exception("Tamagotchi-ul nu poate fi hranit deoarece nivelul de foame este deja 0.");
            }
        }

        public void Joaca()
        {
            _nivelFoame += 5;
            _energie -= 10;
            _nivelFericire += 10;
            if (_energie == 0)
            {
                throw new Exception("Tamagotchi-ul este prea obosit sa se joace. Ar trebui sa se odihneasca.");
            }
        }

        public void Odihneste()
        {
            _nivelFoame += 5;
            _energie += 20;
            _nivelFericire -= 5;
            if (_energie == 100)
            {
                throw new Exception("Tamagotchi-ul nu poate dormi deoarece este plin de energie! Du-te si joaca-te cu el!");
            }
        }
        /*"$" indica un string interpolation, ce permite convertirea intr-un string si apoi afisarea oricarei variabile ce se afla 
        in interiorul acoladelor*/
        public void AfiseazaStare()
        {
            Console.WriteLine($"Nivel de foame: {_nivelFoame}");
            Console.WriteLine($"Nivel de energie: {_energie}");
            Console.WriteLine($"Nivel de fericire: {_nivelFericire}");
        }
    }
}
