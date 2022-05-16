using System;
using InoueLab;

namespace Hit_and_Blow_ipposhi
{
    class Program
    {
        static void Main(string[] args)
        {
            RandomMT rand = new RandomMT();
            int a = 1000;
            int q = 2;
            String str;
            char[] crct = new char[4];
            while (q == 1 || q == 2)
            {
                a = rand.Int(10000);
                str = a.ToString();
                if (a < 1000) continue;
                for (int i = 0; i < 4; i++)
                {
                    crct[i] = str[i];
                }

                for (int j = 0; j < 4; j++)
                {
                    for (int k = 1 + j; k < 4; k++)
                    {
                        if (crct[k] != crct[j])
                        {
                            q = 0;
                        }
                        else
                        {
                            q = 1;
                            break;
                        }
                    }
                    if (q == 1) break;
                }
                //下のコメントアウトを消せば答えがでます
               　//Console.WriteLine(a);
            }

            int pre = 1;
            int hit = 0;
            int blow = 0;
            while (hit != 4 || blow != 4) 
            {
                pre = 1;
                hit = 0;
                blow = 0;
                while (pre < 1000 || pre > 9999)
                {
                    Console.WriteLine("４桁の値を入力して下さい");
                    pre = int.Parse(Console.ReadLine());
                    if (pre < 1000 || pre > 9999)
                    {
                        continue;
                    }

                    String ans = pre.ToString();
                    char[] precrct = new char[4];
                    for (int i = 0; i < 4; i++)
                    {
                        precrct[i] = ans[i];
                    }
                    //hit判定
                    for (int i = 0; i < 4; i++)
                    {
                        if (crct[i] == precrct[i])
                        {
                            hit++;
                        }
                    }
                    //blow判定
                    for (int j = 0; j < 4; j++)
                    {
                        for (int k = 0; k < 4; k++)
                        {
                            if (crct[k] == precrct[j])
                            {
                                blow++;
                            }
                        }
                    }

                    if (hit == 4 && blow == 4)
                    {
                        Console.WriteLine(hit + "HIT");
                        Console.WriteLine(blow + "BLOW");
                        Console.WriteLine("正解！");
                    }
                    else
                    {
                        Console.WriteLine(hit + "HIT");
                        Console.WriteLine(blow + "BLOW");
                        Console.WriteLine("もう一度予想してください");
                    }
                }
            }
            Console.WriteLine("このゲームを終了しました");
        }
    }
}
