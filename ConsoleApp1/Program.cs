using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] Type = { "O", "其他", "O", "O", "A", "O", "A", "A", "O", "O", "A", "O", "A", "B", "O", "O", "A", "其他", "O", "O", "A", "", "B", "O", "", "O", "B", "O", "B", "B", "B", "O", "O", "AB", "O", "B", "A", "O", "O", "", "O", "A", "", "O", "O", "A", "O", "O", "其他", "B", "O", "O", "O", "A", "AB", "A", "O", "B", "AB", "", "O", "O", "O", "", "O", "A", "A", "O" };

            int typeA = 0, typeB = 0, typeO = 0, typeAB = 0, typeElse = 0;
            for (int i = 0; i < Type.Length; i++)
            {
                if (Type[i] == "A")
                {
                    typeA++;
                }
                else if (Type[i] == "B")
                {
                    typeB++;
                }
                else if (Type[i] == "AB")
                {
                    typeAB++;
                }
                else if (Type[i] == "O")
                {
                    typeO++;
                }
                else
                {
                    typeElse++;
                }
            }
            double typeAp = (double)typeA / (double)68;
            double typeOp = (double)typeO / (double)68;
            double typeBp = (double)typeB / (double)68;
            double typeABp = (double)typeAB / (double)68;
            double typeEp = (double)typeElse / (double)68;
            Console.WriteLine("A型:" + typeA.ToString() + "占全班比例:" + typeAp);
            Console.WriteLine("B型:" + typeB.ToString() + "占全班比例:" + typeBp);
            Console.WriteLine("AB型:" + typeAB.ToString() + "占全班比例:" + typeABp);
            Console.WriteLine("O型:" + typeO.ToString() + "占全班比例:" + typeOp);
            Console.WriteLine("其他:" + typeElse.ToString() + "占全班比例:" + typeEp);


            string[] Gender = { "男", "男", "男", "女", "男", "男", "女", "男", "男", "男", "男", "男", "女", "男", "男", "男", "女", "女", "男", "男", "女", "男", "女", "男", "男", "女", "男", "男", "女", "男", "男", "男", "男", "女", "男", "男", "女", "女", "男", "男", "女", "女", "男", "男", "男", "男", "男", "男", "女", "男", "女", "女", "女", "女", "女", "女", "男", "女", "女", "女", "女", "女", "男", "男", "女", "女", "女", "男" };
            int [] CM = { 173, 0, 179, 155, 183, 170, 163, 174, 165, 189, 177, 180, 154, 167, 170, 173, 165, 158, 180, 165, 153, 175, 162, 165, 0, 160, 165, 173, 164, 177, 177, 180, 170, 151, 176, 180, 168, 152, 666, 2147483647, 165, 155, 777, 173, 169, 170, 169, 171, 0, 170, 150, 160, 155, 164, 163, 165, 184, 165, 155, 0, 168, 160, 169, 0, 150, 163, 168, 173 };

            int girlCM = 0;
            int girl = 0;
            for (int a = 0; a < Gender.Length; a++)
            {
                if (Gender[a] == "女" && CM[a] < 200 && CM[a] > 100)
                {                    
                    girl++;
                    girlCM += CM[a];
                }
                
            }
            float girlCMavenger = (float)girlCM /(float)girl;
            Console.WriteLine("女生身高:" + girlCM);
            Console.WriteLine("女生平均身高:" +girlCMavenger);
            Console.Read();
        }
    }
}
