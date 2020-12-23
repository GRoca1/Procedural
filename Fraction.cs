using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AppFraction
{
    public class fraction
    {// attributs
        private int numerateur;
        private int denominateur;

        //proprietes
        public int Denominateur
        { get => denominateur; set => denominateur = value; }
        public int Numerateur
        { get => numerateur; set => numerateur = value; }

        // Constructeur
        public fraction(int _numerateur, int _denominateur)
        {
            try
            {
                this.numerateur = _numerateur;
                this.denominateur = _denominateur;
                double lafraction = (double)this.numerateur / this.denominateur;
            }
            catch (ArithmeticException e)
            {
                Console.WriteLine("Division par zero impossible" + e.Message);
            }
            catch (Exception er)
            {
                Console.WriteLine(er.Message);
            }
        }
            public fraction(int _numerateur)
            {
                this.numerateur = _numerateur;
                this.denominateur = 1;
            }
            public fraction()
            {
                this.numerateur = 0;
                this.denominateur = 1;
            }

                //Méthodes fraction

            public override string ToString()
            {
                string chaineFraction = "";
                if (this.denominateur ==1)
            {
                chaineFraction += this.numerateur;
            }
            else
            {
                chaineFraction += this.numerateur + "/" + this.denominateur;
            }
            return chaineFraction;
            }

    }
  }
    

        
    

