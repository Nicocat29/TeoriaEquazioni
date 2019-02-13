using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquazioniLibrary
{
    public static class Equazioni
    {
        public static bool IsDetermined(double a)
        {
            if (a==0)
            {
                return false;
            }
            else
            {
                return true;
            }

        }


        public static bool IsImpossible(double a, double b)
        {
            if (a == 0 && b != 0) 
            {
                return false;
            }
            else
            {
                return true;
            }

        }
    }
}
