using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Test__6
{
    internal class massiv
    {
        private int[,] arrayM;

        public massiv(int[,] array)
        {
            arrayM = array;
        }
        public int Number_One()//произведение элементов квадрат которых менее 25
        {
            int numo = 1;//1 f yt 0 nfr rfr ghb * yf 0 = 0
            foreach(int num in arrayM)
            if ((num * num) < 25)
            {
                numo *= num;
            }
            return numo;
        }//+
        public int Number_Two()//сума модуле с положительным элементом 
        {
            int sum = 0;
            foreach (int sum_modul in arrayM)
                if ((sum_modul > 0))
            {
                sum += Math.Abs(sum_modul);
            }
            return sum;
        }//+
        public int Number_Seven()//Опрпеделить в нем произведение тех элементов чей модуль лежит в диапазоне [15; 50]
        {
            int numo = 1;
            foreach (int num in arrayM)
                if ((num * num) > 15 && (num * num) < 50)
                {
                    numo *= num;
                }
            return numo;
        }//+
        public int Number_Three()//сума модуле с отрицат. элементом //+--
        {
            int quantity = 0;
            int sum = 0;
            foreach (int sum_moduli in arrayM)
                if ((sum_moduli < 0))
                {
                    quantity++;
                    sum += sum_moduli;
                }
            return quantity == 0 ? 0 : sum / quantity;
            //return quantity;
        }

        /*
        public int Number_Four()//Опрпеделить в нем среднее геометрическое эелементов, у которых оба индекса четные
        {
            foreach (int sum_moduli in arrayM)
                if ()
                {
                }
            return;
        }//-
        public int Number_Five()//Опрпеделить в нем  среднее геометрическое квадратов четных эелементов
        {
            foreach (int sum_moduli in arrayM)
                if ()
                {
                }
            return;
        }//-
        */
        public int Number_Six()//Опрпеделить в нем Количество тех элементов что при делении на 4 дают 2
        {
            int koluchestvo = 0;
            foreach (int sum  in arrayM)
            {
                int str1 = Convert.ToInt32(string.Join(" ", arrayM));                
                int answer = (str1 / 4);                
                if (answer == 2) {
                    koluchestvo += sum;
                }
                
            }
            return koluchestvo;
        }//-

    }
}
