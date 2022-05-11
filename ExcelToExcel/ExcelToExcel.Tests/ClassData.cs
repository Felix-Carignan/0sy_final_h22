using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelToExcel.Tests
{
    class GoodInBadOut : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[] { "liste_especes.xlsx", "invalide_fichier_type.txt" };
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }


    class GoodInGoodOut : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[] { "liste_especes.xlsx", "liste_especes.csv" };
            yield return new object[] { "liste_especes.xlsx", "liste_especes.json" };
            yield return new object[] { "liste_especes.xlsx", "liste_especes.xlsx" };
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
