using System;
using System.Collections.Generic;
using System.Text;

namespace Jeux421
{
    public class Alea : Random
    {
        private static Alea MonAlea = null;

        private Alea()
        {

        }

        public static Alea GetInstance()

        {

            if (MonAlea == null)
            {
                MonAlea = new Alea();

            }
            return MonAlea;

        }

        /// 
        /// <param name="valMax"></param>
        /// <param name="valMin"></param>
        public int Nouveau(int valMin, int valMax)
        {

            return base.Next(valMin, valMax + 1);
        }

        /// 
        //<param name="valMax"></param>
        public int Nouveau(int valMax)
        {

            return base.Next(valMax + 1);

        }

        public double NouveauReel()
        {

            return base.NextDouble();

        }

    }//end Alea

    public class De
    {

        // Attributs
        private int valeur;
        private Alea hasard;
        //propriétés
        public int Valeur
        {
            get
            {
                return valeur;
            }

            set
            {
                valeur = value;
            }
        }
        //Constructeur
        public De()
        {
            this.valeur = 0; //initialisation
        }
        //

        public void jeter()
        {
            //Alea
            hasard = Alea.GetInstance();
            this.valeur = hasard.Next(1, 6);

        }


    }

    public class Lancer
    {

        //Attribut 
        private De[] LesTroisDes = new De[3];
        //Constructeur

        public Lancer()
        {
            for (int i = 0; i < LesTroisDes.Length; i++)
            {
                LesTroisDes[i] = new De();
                LesTroisDes[i].jeter();

            }
            Array.Sort(LesTroisDes);

        }
        public void trier()
        {

            Array.Sort(LesTroisDes);

        }

        public void ReLancerUnDe(int _numDe)
        {
            LesTroisDes[_numDe - 1].jeter();
            trier();

        }
        public int GetValeurDe(int _numDe)
        {
            return LesTroisDes[_numDe - 1].Valeur;
        }
    }
}
