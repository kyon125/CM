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
            string[] Gender = { "男", "男", "男", "女", "男", "男", "女", "男", "男", "男", "男", "男", "女", "男", "男", "男", "女", "女", "男", "男", "女", "男", "女", "男", "男", "女", "男", "男", "女", "男", "男", "男", "男", "女", "男", "男", "女", "女", "男", "男", "女", "女", "男", "男", "男", "男", "男", "男", "女", "男", "女", "女", "女", "女", "女", "女", "男", "女", "女", "女", "女", "女", "男", "男", "女", "女", "女", "男" };
            int[] CM = { 173, 0, 179, 155, 183, 170, 163, 174, 165, 189, 177, 180, 154, 167, 170, 173, 165, 158, 180, 165, 153, 175, 162, 165, 0, 160, 165, 173, 164, 177, 177, 180, 170, 151, 176, 180, 168, 152, 666, 2147483647, 165, 155, 777, 173, 169, 170, 169, 171, 0, 170, 150, 160, 155, 164, 163, 165, 184, 165, 155, 0, 168, 160, 169, 0, 150, 163, 168, 173 };
            string[] Star = { "金牛", "", "巨蟹", "白羊", "雙魚", "雙子", "天蠍", "巨蟹", "獅子", "雙魚", "雙子", "雙子", "獅子", "雙魚", "天蠍", "天蠍", "處女", "處女", "金牛", "雙魚", "處女", "摩羯", "雙魚", "白羊", "天蠍", "處女", "雙子", "金牛", "雙子", "白羊", "白羊", "摩羯", "射手", "巨蟹", "雙魚", "獅子", "射手", "摩羯", "天蠍", "", "雙魚", "雙子", "", "雙魚", "處女", "金牛", "天秤", "水瓶", "巨蟹", "處女", "白羊", "摩羯", "水瓶", "天秤", "金牛", "天蠍", "天蠍", "處女", "雙子", "", "摩羯", "天蠍", "雙子", "", "獅子", "天蠍", "射手", "金牛" };
            string[] Name = { "葉俊廷", "張澤瑜", "龘䶛䨻䎱㸞蚮䡶䴞䴝䯬䬛䰕㹚王程捷", "江儀婷", "張秉華", "陳柏霖", "黃紀瑜", "黃昱維", "蔡逸群", "登琳", "世新魏鈞孝吧", "劉定南", "陳信如", "童信傑", "李岳倫", "鄒和恆", "簡毓玟", "劉子瑄", "蕭紹洋", "李亞宸la", "張以潔", "邱仕紳", "呂家瑩", "世新林鑫佑", "徐均得", "陳佳欣", "張恩瑋", "周詮", "王湘婷", "蕭宇成", "Max Cheung(BANG)", "馬嘉誠Σヽ(ﾟД ﾟ; )ﾉ魔貫光殺砲(ﾟДﾟ)σ━0000", "陳昱嘉", "康珈熏", "盧奕宏", "陳郁佳的大哥黃博涵", "遲正雯", "世新林星彤", "許晏誠ｘ勒是奇多＿８＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝Ｄ　", "許子安", "高子晴", "陳思婷", "矝鵘鮿", "余彥廷", "吳耀輝", "鄭丞智", "林冠廷", "世新何曜宇", "邵喬雨", "張豐愷", "林子晴", "邱雁回", "陳家欣是韓妞", "鄧雅馨", "謝汶珊", "李曼寧", "我是陳柏霖2號", "張鈺慈", "鍾宜珊", "raer_tsai", "世新李姳諼", "鄭曼君", "陳柏霖", "世新許子安", "世新方若帆", "李曼寧", "世新遲正雯", "世新周詮" };
            int[] StarO = new int[Star.Length];

            int typeA = 0, typeB = 0, typeO = 0, typeAB = 0, typeElse = 0, man = 0, woman = 0;
            for (int x = 0; x < Gender.Length; x++)
            {
                if (Gender[x] == "男")
                {
                    man++;
                }

                else
                {
                    woman++;
                }
            }

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

            float manp = (float)man / (float)Gender.Length;
            float womanp = (float)woman / (float)Gender.Length;
            double typeAp = (double)typeA / (double)68;
            double typeOp = (double)typeO / (double)68;
            double typeBp = (double)typeB / (double)68;
            double typeABp = (double)typeAB / (double)68;
            double typeEp = (double)typeElse / (double)68;          
           
            int girlCM = 0,boyCM = 0;
            for (int a = 0; a < Gender.Length; a++)
            {
                if (Gender[a] == "女" && CM[a] < 200 && CM[a] > 100)
                {
                    girlCM += CM[a];
                }
                else if (Gender[a] == "男" && CM[a] < 200 && CM[a] > 100)
                {
                    boyCM += CM[a];
                }
            }
            float girlCMavenger = (float)girlCM /(float)woman;
            float boyCMavenger = (float)boyCM / (float)man;
            float allCMavenger = (float)(boyCM + girlCM)/ (float)Gender.Length;
            
            int z = 0;
            int StatOpeo = 0;
            for (int Z = 0; Z < Name.Length; Z++)
            {
                
                if (Star[Z] == "天蠍" && Type[Z] == "O")
                {
                    StatOpeo++;
                    StarO[z] = Z;
                    z++;
                }
            }
            Console.WriteLine("男生占全班比例:" + manp);
            Console.WriteLine("女生占全班比例:" + womanp);
            Console.WriteLine("A型:" + typeA.ToString() + "占全班比例:" + typeAp);
            Console.WriteLine("B型:" + typeB.ToString() + "占全班比例:" + typeBp);
            Console.WriteLine("AB型:" + typeAB.ToString() + "占全班比例:" + typeABp);
            Console.WriteLine("O型:" + typeO.ToString() + "占全班比例:" + typeOp);
            Console.WriteLine("其他:" + typeElse.ToString() + "占全班比例:" + typeEp);
            Console.WriteLine("女生平均身高:" + girlCMavenger);
            Console.WriteLine("男生平均身高:" + boyCMavenger);
            Console.WriteLine("全班平均身高:" + allCMavenger);
            Console.WriteLine("是天蠍且為O型血的人數:" + StatOpeo);
            Console.WriteLine("是天蠍且為O型血的人:");
            Console.WriteLine(Name[StarO[0]]);
            Console.WriteLine(Name[StarO[1]]);
            Console.WriteLine(Name[StarO[2]]);
            Console.WriteLine(Name[StarO[3]]);
            Console.WriteLine(Name[StarO[4]]);
            Console.Read();
        }
    }
}
