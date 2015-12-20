﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advent
{
    public class day16
    {
        public static void day_16()
        {
            //Day 16 Challenge
            day16 d16 = new day16();
            Console.WriteLine("Day 16");
            Console.ReadLine();
            d16.setup();
            Console.WriteLine(d16.CompareSues());
            Console.ReadLine();
            Console.WriteLine(d16.CompareSuespart2());
            Console.ReadLine();
        }
        public enum sueThings
        {
            children,
            cats,
            samoyeds,
            pomeranians,
            akitas,
            vizslas,
            goldfish,
            trees,
            cars,
            perfumes
        }
        public int[,] sue = new int[501,10];
        public string[] input = File.ReadAllLines("../../day16.txt");
        public void setup()
        {
            XmasSue[(int)sueThings.children] = 3;
            XmasSue[(int)sueThings.cats] = 7;
            XmasSue[(int)sueThings.samoyeds] = 2;
            XmasSue[(int)sueThings.pomeranians] = 3;
            XmasSue[(int)sueThings.akitas] = 0;
            XmasSue[(int)sueThings.vizslas] = 0;
            XmasSue[(int)sueThings.goldfish] = 5;
            XmasSue[(int)sueThings.trees] = 3;
            XmasSue[(int)sueThings.cars] = 2;
            XmasSue[(int)sueThings.perfumes] = 1;
            for (int i = 1; i < 500; i++)
            {
                sue[i, (int)sueThings.children] = -1;
                sue[i, (int)sueThings.cats] = -1;
                sue[i, (int)sueThings.samoyeds] = -1;
                sue[i, (int)sueThings.pomeranians] = -1;
                sue[i, (int)sueThings.akitas] = -1;
                sue[i, (int)sueThings.vizslas] = -1;
                sue[i, (int)sueThings.goldfish] = -1;
                sue[i, (int)sueThings.trees] = -1;
                sue[i, (int)sueThings.cars] = -1;
                sue[i, (int)sueThings.perfumes] = -1;
            }
            for (int j = 0; j < input.Length; j++)
            {
                string tmp;
                tmp = input[j].Substring(4);
                string[] tmp2 = tmp.Split(',');
                string[] tmp3 = tmp2[0].Split(':');
                string num1 = tmp3[2].Trim();
                string[] tmp4 = tmp2[1].Split(':');
                string num2 = tmp4[1].Trim();
                string[] tmp5 = tmp2[2].Split(':');
                string num3 = tmp5[1].Trim();

                if (tmp2[0].Contains("children"))
                {
                    sue[j + 1, (int)sueThings.children] = Convert.ToInt32(num1);
                }
                if (tmp2[1].Contains("children"))
                {
                    sue[j + 1, (int)sueThings.children] = Convert.ToInt32(num2);
                }
                if (tmp2[2].Contains("children"))
                {
                    sue[j + 1, (int)sueThings.children] = Convert.ToInt32(num3);
                }

                if (tmp2[0].Contains("cats"))
                {
                    sue[j + 1, (int)sueThings.cats] = Convert.ToInt32(num1);
                }
                if (tmp2[1].Contains("cats"))
                {
                    sue[j + 1, (int)sueThings.cats] = Convert.ToInt32(num2);
                }
                if (tmp2[2].Contains("cats"))
                {
                    sue[j + 1, (int)sueThings.cats] = Convert.ToInt32(num3);
                }

                if (tmp2[0].Contains("samoyeds"))
                {
                    sue[j + 1, (int)sueThings.samoyeds] = Convert.ToInt32(num1);
                }
                if (tmp2[1].Contains("samoyeds"))
                {
                    sue[j + 1, (int)sueThings.samoyeds] = Convert.ToInt32(num2);
                }
                if (tmp2[2].Contains("samoyeds"))
                {
                    sue[j + 1, (int)sueThings.samoyeds] = Convert.ToInt32(num3);
                }

                if (tmp2[0].Contains("pomeranians"))
                {
                    sue[j + 1, (int)sueThings.pomeranians] = Convert.ToInt32(num1);
                }
                if (tmp2[1].Contains("pomeranians"))
                {
                    sue[j + 1, (int)sueThings.pomeranians] = Convert.ToInt32(num2);
                }
                if (tmp2[2].Contains("pomeranians"))
                {
                    sue[j + 1, (int)sueThings.pomeranians] = Convert.ToInt32(num3);
                }

                if (tmp2[0].Contains("akitas"))
                {
                    sue[j + 1, (int)sueThings.akitas] = Convert.ToInt32(num1);
                }
                if (tmp2[1].Contains("akitas"))
                {
                    sue[j + 1, (int)sueThings.akitas] = Convert.ToInt32(num2);
                }
                if (tmp2[2].Contains("akitas"))
                {
                    sue[j + 1, (int)sueThings.akitas] = Convert.ToInt32(num3);
                }

                if (tmp2[0].Contains("vizslas"))
                {
                    sue[j + 1, (int)sueThings.vizslas] = Convert.ToInt32(num1);
                }
                if (tmp2[1].Contains("vizslas"))
                {
                    sue[j + 1, (int)sueThings.vizslas] = Convert.ToInt32(num2);
                }
                if (tmp2[2].Contains("vizslas"))
                {
                    sue[j + 1, (int)sueThings.vizslas] = Convert.ToInt32(num3);
                }

                if (tmp2[0].Contains("goldfish"))
                {
                    sue[j + 1, (int)sueThings.goldfish] = Convert.ToInt32(num1);
                }
                if (tmp2[1].Contains("goldfish"))
                {
                    sue[j + 1, (int)sueThings.goldfish] = Convert.ToInt32(num2);
                }
                if (tmp2[2].Contains("goldfish"))
                {
                    sue[j + 1, (int)sueThings.goldfish] = Convert.ToInt32(num3);
                }

                if (tmp2[0].Contains("trees"))
                {
                    sue[j + 1, (int)sueThings.trees] = Convert.ToInt32(num1);
                }
                if (tmp2[1].Contains("trees"))
                {
                    sue[j + 1, (int)sueThings.trees] = Convert.ToInt32(num2);
                }
                if (tmp2[2].Contains("trees"))
                {
                    sue[j + 1, (int)sueThings.trees] = Convert.ToInt32(num3);
                }

                if (tmp2[0].Contains("cars"))
                {
                    sue[j + 1, (int)sueThings.cars] = Convert.ToInt32(num1);
                }
                if (tmp2[1].Contains("cars"))
                {
                    sue[j + 1, (int)sueThings.cars] = Convert.ToInt32(num2);
                }
                if (tmp2[2].Contains("cars"))
                {
                    sue[j + 1, (int)sueThings.cars] = Convert.ToInt32(num3);
                }

                if (tmp2[0].Contains("perfumes"))
                {
                    sue[j + 1, (int)sueThings.perfumes] = Convert.ToInt32(num1);
                }
                if (tmp2[1].Contains("perfumes"))
                {
                    sue[j + 1, (int)sueThings.perfumes] = Convert.ToInt32(num2);
                }
                if (tmp2[2].Contains("perfumes"))
                {
                    sue[j + 1, (int)sueThings.perfumes] = Convert.ToInt32(num3);
                }
            }
        }

        public int[] XmasSue = new int[10];

        public int CompareSues()
        {
            int[] possible = new int[501];
            for (int i = 1; i < 500; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (sue[i, j] == XmasSue[j]) { possible[i]++; }
                }
            }
            return possible.ToList().IndexOf(possible.Max());
        }

        public int CompareSuespart2()
        {
            int[] possible2 = new int[501];
            for (int i = 1; i < 501; i++)
            {
                if (sue[i, (int)sueThings.children] == -1) { }
                else if (sue[i, (int)sueThings.children] == XmasSue[(int)sueThings.children]) { possible2[i]++; }
                else { possible2[i]--; }
                if (sue[i, (int)sueThings.samoyeds] == -1) { }
                else if (sue[i, (int)sueThings.samoyeds] == XmasSue[(int)sueThings.samoyeds]) { possible2[i]++; }
                else { possible2[i]--; }
                if (sue[i, (int)sueThings.akitas] == -1) { }
                else if (sue[i, (int)sueThings.akitas] == XmasSue[(int)sueThings.akitas]) { possible2[i]++; }
                else { possible2[i]--; }
                if (sue[i, (int)sueThings.vizslas] == -1) { }
                else if (sue[i, (int)sueThings.vizslas] == XmasSue[(int)sueThings.vizslas]) { possible2[i]++; }
                else { possible2[i]--; }
                if (sue[i, (int)sueThings.cars] == -1) { }
                else if (sue[i, (int)sueThings.cars] == XmasSue[(int)sueThings.cars]) { possible2[i]++; }
                else { possible2[i]--; }
                if (sue[i, (int)sueThings.perfumes] == -1) { }
                else if (sue[i, (int)sueThings.perfumes] == XmasSue[(int)sueThings.perfumes]) { possible2[i]++; }
                else { possible2[i]--; }
                if (sue[i, (int)sueThings.cats] == -1) { }
                else if (sue[i, (int)sueThings.cats] > XmasSue[(int)sueThings.cats]) { possible2[i]++; }
                else { possible2[i]--; }
                if (sue[i, (int)sueThings.trees] == -1) { }
                else if (sue[i, (int)sueThings.trees] > XmasSue[(int)sueThings.trees]) { possible2[i]++; }
                else { possible2[i]--; }
                if (sue[i, (int)sueThings.pomeranians] == -1) { }
                else if (sue[i, (int)sueThings.pomeranians] < XmasSue[(int)sueThings.pomeranians]) { possible2[i]++; }
                else { possible2[i]--; }
                if (sue[i, (int)sueThings.goldfish] == -1) { }
                else if (sue[i, (int)sueThings.goldfish] < XmasSue[(int)sueThings.goldfish]) { possible2[i]++; }
                else { possible2[i]--; }
            }
            return possible2.ToList().IndexOf(possible2.Max());
        }
    }
}
