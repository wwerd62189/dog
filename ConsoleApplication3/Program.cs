using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] a = { "葉俊廷", "張澤瑜", "王程捷 的咩？", "江儀婷", "張秉華", "陳柏霖", "黃紀瑜", "黃昱維", "蔡逸群", "登琳", "世新魏鈞孝吧", "劉定南", "陳信如", "童信傑", "李岳倫", "鄒和恆", "簡毓玟", "劉子瑄", "蕭紹洋", "李亞宸la", "張以潔", "邱仕紳", "呂家瑩", "世新林鑫佑", "徐均得", "陳佳欣", "張恩瑋", "周詮", "王湘婷", "蕭宇成", "Max Cheung(BANG)", "馬嘉誠Σヽ(ﾟД ﾟ; )ﾉ魔貫光殺砲(ﾟДﾟ)σ━0000", "陳昱嘉", "康珈熏", "盧奕宏", "陳郁佳的大哥黃博涵", "遲正雯", "世新林星彤", "許晏誠ｘ勒是奇多＿８＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝Ｄ　", "許子安", "高子晴", "陳思婷", "矝鵘鮿", "余彥廷", "吳耀輝", "鄭丞智", "林冠廷", "世新何曜宇", "邵喬雨", "張豐愷", "林子晴", "邱雁回", "陳家欣是韓妞", "鄧雅馨", "謝汶珊", "李曼寧", "世新徐偉哲", "张钰慈", "鍾宜珊", "raer_tsai", "世新李姳諼", "鄭曼君", "陳柏霖", "世新許子安", "世新方若帆", "李曼寧", "世新遲正雯", "世新周詮" };
            string[] b = { "男", "男", "男", "女", "男", "男", "女", "男", "男", "男", "男", "男", "女", "男", "男", "男", "女", "女", "男", "男", "女", "男", "女", "男", "男", "女", "男", "男", "女", "男", "男", "男", "男", "女", "男", "男", "女", "女", "男", "男", "女", "女", "男", "男", "男", "男", "男", "男", "女", "男", "女", "女", "女", "女", "女", "女", "男", "女", "女", "女", "女", "女", "男", "男", "女", "女", "女", "男" };
            int[] c = { 173, 0, 179, 155, 183, 170, 163, 174, 165, 189, 177, 180, 154, 167, 170, 173, 165, 158, 180, 165, 153, 175, 162, 165, 0, 160, 165, 173, 164, 177, 177, 180, 170, 151, 176, 180, 168, 152, 666, 2147483647, 165, 155, 777, 173, 169, 170, 169, 171, 0, 170, 150, 160, 155, 164, 163, 165, 184, 165, 155, 0, 168, 160, 169, 0, 150, 163, 168, 173 };
            string[] d = { "O", "其他", "O", "O", "A", "O", "A", "A", "O", "O", "A", "O", "A", "B", "O", "O", "A", "其他", "O", "O", "A", "", "B", "O", "", "O", "B", "O", "B", "B", "B", "O", "O", "AB", "O", "B", "A", "O", "O", "", "O", "A", "", "O", "O", "A", "O", "O", "其他", "B", "O", "O", "O", "A", "AB", "A", "O", "B", "AB", "", "O", "O", "O", "", "O", "A", "A", "O" };
            string[] e = { "金牛", "", "巨蟹", "白羊", "雙魚", "雙子", "天蠍", "巨蟹", "獅子", "雙魚", "雙子", "雙子", "獅子", "雙魚", "天蠍", "天蠍", "處女", "處女", "金牛", "雙魚", "處女", "摩羯", "雙魚", "白羊", "天蠍", "處女", "雙子", "金牛", "雙子", "白羊", "白羊", "摩羯", "射手", "巨蟹", "雙魚", "獅子", "射手", "摩羯", "天蠍", "", "雙魚", "雙子", "", "雙魚", "處女", "金牛", "天秤", "水瓶", "巨蟹", "處女", "白羊", "摩羯", "水瓶", "天秤", "金牛", "天蠍", "天蠍", "處女", "", "", "摩羯", "天蠍", "雙子", "", "獅子", "天蠍", "射手", "金牛" };

            int aa = 0;
            int bb = 0;
            int cc = 0;
            int dd = 0;
            int ee = 0;
            int hh = 0;
            int mm = 0;
            int nn = 0;
            
            int rr = 0;
            
            
         

            for (int i=0;i<b.Length;i++)
            {
                if (c[i] > 100 && c[i] < 200)
                {
                    rr += c[i];
                    if (b[i] == "男")

                    {
                        aa++;
                        mm += c[i];


                    }
                    if (b[i] == "女")

                    {
                        bb++;
                        nn += c[i];
                    }

                }
               

            }

            for (int n = 0; n < d.Length; n++)
            {
                //Console.WriteLine(s[n]);
                if (d[n] == "O")

                {
                    cc++;
                }
                if (d[n] == "A")

                {
                    dd++;
                }
                if (d[n] == "B")

                {
                    ee++;
                }
                if (d[n] == "AB")

                {
                    hh++;
                }
            }
           



             double ff = Math.Round((double)aa / b.Length*100);
            double gg = Math.Round((double)bb / b.Length*100);
            double ii = Math.Round((double)cc / b.Length*100);
            double jj = Math.Round((double)dd / b.Length*100);
            double kk = Math.Round((double)ee / b.Length*100);
            double ll = Math.Round((double)hh / b.Length*100);
            int pp = mm / aa;
            int qq = nn / bb;
            int ss = rr / (aa+bb);


            Console.WriteLine("男生人數" + aa);
            Console.WriteLine("男生比例" + ff+"%");
            Console.WriteLine("女生人數" + bb);
            Console.WriteLine("女生比例" + gg + "%");
            Console.WriteLine("O人數" + cc);
            Console.WriteLine("0型的" + ii + "%");
            Console.WriteLine("A人數" + dd);
            Console.WriteLine("A型的" + jj + "%");
            Console.WriteLine("B人數" + ee);
            Console.WriteLine("B型的" + kk + "%") ;
            Console.WriteLine("AB人數" + hh);
            Console.WriteLine("AB型的" + ll + "%");
            Console.WriteLine("男生身高平均" + pp);
            Console.WriteLine("女生身高平均" + qq);
            Console.WriteLine("身高平均" + ss);

            for (int i = 0; i < b.Length; i++)
            {
                if (e[i] == "天蠍" && d[i] == "O")
                {
                    Console.WriteLine("天蠍座O型的人" + a[i]);
                }
            }
            Console.ReadLine();





        }












    }
}
