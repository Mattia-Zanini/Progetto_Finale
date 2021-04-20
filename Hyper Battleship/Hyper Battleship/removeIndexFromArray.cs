using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hyper_Battleship
{
    public static class removeIndexFromArray
    {
        //=========================================================================
        // Rimuove tutte le istanze di [itemToRemove] dall'array [originale]
        // Restituisce il nuovo array, senza modificare direttamente [originale]
        // .Net2.0-compatibile
        public static T[] RemoveFromArray<T>(this T[] original, T itemToRemove)
        {
            int numIdx = System.Array.IndexOf(original, itemToRemove);
            if (numIdx == -1) return original;
            List<T> tmp = new List<T>(original);
            tmp.RemoveAt(numIdx);
            return tmp.ToArray();
        }
    }
}
