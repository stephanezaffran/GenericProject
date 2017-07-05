using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GenericProject.Jobs
{
    public  class MaListeGenerique<T>
    {
        private int capacite;
        private int nbElements;
        private T[] tableau;


        public MaListeGenerique()
        {
            capacite = 10;
            nbElements = 0;
            tableau = new T[capacite];
        }


        public void Ajouter(T element)
        {
            if (nbElements >= capacite)
            {
                capacite *= 2;
                T[] copieTableau = new T[capacite];
                for (int i = 0; i < tableau.Length; i++)
                {
                    copieTableau[i] = tableau[i];
                }
                tableau = copieTableau;
            }
            tableau[nbElements] = element;
            nbElements++;
        }

        public static bool AreEqual(T x, T y)
        {
            return x.Equals(y);
        }

    }
}

