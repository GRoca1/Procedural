
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuDu421


{
    class Manche421
    {
        private int nbLanceCourant;
        private int nbLanceMaximum;
        private De[] des;

              public Manche421()
        {
            nbLanceCourant = 0;
            nbLanceMaximum = 3;
            des = new De[3];
            des[0] = new De();
            des[1] = new De();
            des[2] = new De();

        }
                public bool EstGagne()
        {
            bool ok = false;

            if ((des[0].Valeur == 4) && (des[1].Valeur == 2) && (des[2].Valeur == 1))
            {

                ok = true;
            }
            return ok;

        }
               public void LanceTout()
        {
            int[] chaine = new int[] { 1, 2, 3 };
            Lance(chaine);

        }
       
        public void Lance(int[] indicesDes)
        {
            foreach (int indice in indicesDes)
            {
                int choix = indice - 1;
                des[choix].Jeter();
            }

            Array.Sort(des);
            Array.Reverse(des);
        }
       
        public bool AEncoreUnLance()
        {
            bool ok = false;
            if (nbLanceCourant < nbLanceMaximum)
            {
                ok = true;
            }
            return ok;
        }

        public string DonneRepresentationDeLaManche()
        {
            return "de 1: " + des[0].Valeur + "de 2: " + des[1].Valeur + "de 3: " + des[2].Valeur;

        }
    }
}
    public class Alea : Random
    {
        private static Alea monAlea = null;

        private Alea()
        {
        }

        public static Alea Instance()
        {
            if (monAlea == null)
            {
                monAlea = new Alea();

            }
            return monAlea;
        }

        public int Nouveau(int valMin, int valMax)
        {

            return base.Next(valMin, valMax + 1);
        }
    }

     class De
    { 
        private int valeur;

       
        public int Valeur
        {
            get { return valeur; }
           
        }

        
        public De()
        {
            valeur = 1;
        }

       
        public void Jeter()
        {
            valeur = Alea.Instance().Nouveau(1, 6);
        }

        public override string ToString()
        {
            return valeur.ToString();
        }
    }
public class Manager421
{
    private Manche421 _manche;
    private int _numeroManche;
    public int NombreManches;
    private int numeroManche;

    public Manager421(int nbreManches)
    {
        NombreManches = nbreManches;
        numeroManche = 1;
    }

    public void Play()
    {
        _manche = new Manche421();
      
    }
}


