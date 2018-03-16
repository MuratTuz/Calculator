using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hesap_Makinesi
{
        /* Buradaki static methotlar extension olarak çağırıldığında
     * (örn: textBox1.Text.ZeroIfEmpty) derleyici bunu 
     * MyStringClass.ZeroIfEmpty(textBox1.Text) olarak çalıştırıyor.
     * Dolayısıyla bir bu değerlerin bir değişkene atama yapılması gerekiyor.
     */
    public static class MyStringClass
    {
        public static string ZeroIfEmpty(this string s)
        {
            return string.IsNullOrEmpty(s) ? "0" : s;
        }

        public static string VirgulEkle(this string s)
        {
            if (s.Equals("-")) s += "0";
            return !s.Contains(',') ? s + ',' : s;
        }


        public static int DigitIndex<TSource>(this IEnumerable<TSource> source)
        {
           // if (source.Last().Equals(')')) return -1;

            source = source.Reverse();
            int total = source.Count() - 1;
            int ind = 0;

            foreach (var item in source)
            {
                if (item.Equals('+') || item.Equals('-') || item.Equals('/') || item.Equals('x'))
                    return (total - ind);
                ind++;
            }
            return -1;
            //string str = (string)Convert.ChangeType(source, typeof(string));
            //if (!str.Contains(',')) str += ',';

            //return (TSource)Convert.ChangeType(str, typeof(TSource));
        }

        public static decimal ToDecimal(this string s)
        {
            if (decimal.TryParse(s, out decimal d))
                return d;
            return 0;
        }

        public static double ToDouble(this string s)
        {
            double d;
            if (double.TryParse(s, out d))
                return d;
            return 0;
        }

        public static bool Islem_mi(this char item)
        {

            if (item.Equals('+') || item.Equals('-') || item.Equals('/') || item.Equals('x'))
                return true;
            else
                return false;
        }


 
    }
}
