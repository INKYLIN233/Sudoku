using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sudoku
{
    internal class Function
    {
        private static int[][] array = new int[9][];
        public static void PrintArray()
        {
            int length = 4;
            int[][] a = GetArray();
            switch (MainForm.mainForm.ComboBox.Text)
            {
                case "简单":
                    length = 4;
                    break;
                case "中等":
                    length = 5;
                    break;
                case "困难":
                    length = 6;
                    break;
            }
            Random random = new Random();
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    int RandomNum = random.Next(9);
                    if (RandomNum > length)
                    {
                        MainForm.mainForm.labelArray[i, j].Text = a[i][j].ToString();
                        MainForm.mainForm.labelArray[i, j].Enabled = false;
                    }
                }
            }
        }
        private static int[][] GetArray()
        {
            array[0] = new int[9] { 5, 6, 4, 8, 9, 7, 2, 3, 1 };
            array[1] = new int[9] { 9, 7, 8, 3, 1, 2, 6, 4, 5 };
            array[2] = new int[9] { 3, 1, 2, 6, 4, 5, 9, 7, 8 };
            array[3] = new int[9] { 6, 4, 5, 9, 7, 8, 3, 1, 2 };
            array[4] = new int[9] { 7, 8, 9, 1, 2, 3, 4, 5, 6 };
            array[5] = new int[9] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            array[6] = new int[9] { 4, 5, 6, 7, 8, 9, 1, 2, 3 };
            array[7] = new int[9] { 8, 9, 7, 2, 3, 1, 5, 6, 4 };
            array[8] = new int[9] { 2, 3, 1, 5, 6, 4, 8, 9, 7 };

            List<int> list = CreateRandomList(9);
            int[][] result = CreateRandomArray(array, list);
            printArray(result);
            return result;
        }
        private static int[][] CreateRandomArray(int[][] seedArray, List<int> list)
        {
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    for (int k = 0; k < 9; k++)
                    {
                        if (seedArray[i][j] == list[k])
                        {
                            seedArray[i][j] = list[(k + 1) % 9];
                            break;
                        }
                    }
                }
            }
            return seedArray;
        }
        private static List<int> CreateRandomList(int length)
        {
            List<int> list = new List<int>();
            Random random = new Random();
            for (int i = 0; i < length; i++)
            {
                int randomNum = random.Next(length) + 1;
                while (true)
                {
                    if (!list.Contains(randomNum))
                    {
                        list.Add(randomNum);
                        break;
                    }
                    randomNum = random.Next(length) + 1;
                }
            }
            return list;
        }

        public static int[][] Get()
        {
            return array;
        }

        public static void ChangeBackColor()
        {
            foreach (var item in MainForm.mainForm.labelArray)
            {
                item.Tag = 0;
                item.BackColor = SystemColors.Window;
            }
        }
        public static string GetTime(int t)
        {
            int min, sec;
            String Min, Sec;
            min = t / 60 % 60;
            sec = t % 60;
            if (sec < 10)
                Sec = "0" + sec.ToString();
            else
                Sec = sec.ToString();
            if (min < 10)
                Min = "0" + min.ToString();
            else
                Min = min.ToString();
            string time = Min + ":" + Sec;

            return time;
        }

        internal static void Clear()
        {
            foreach (var item in MainForm.mainForm.labelArray)
            {
                item.Text = "";
                item.Enabled = true;
                item.Tag = 0;
            }
        }
        private static void printArray(int[][] a)
        {
            string charss = "";
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    charss += a[i][j] + "  ";
                }
            }
            Write(charss);
        }
        private static void Write(String s)
        {
            FileStream fs = new FileStream("E:\\aj.txt", FileMode.Create);
            StreamWriter sw = new StreamWriter(fs);
            //开始写入

            sw.Write(s);
            //清空缓冲区
            sw.Flush();
            //关闭流
            sw.Close();
            fs.Close();
        }
    }
}
