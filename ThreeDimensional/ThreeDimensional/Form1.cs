using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThreeDimensional
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ThreeDimensional.FillThreeDimensionalArrAndFindMinNumb();
            ShowRandomNums();
        }

        private void ShowRandomNums()
        {
            var arr = ThreeDimensional.threeDimen;
            for (int x = 0; x < 6; x++)
            {
                var txt = "";
                for (int y = 0; y < 3; y++)
                {
                    txt += " (";
                    for (int z = 0; z < 4; z++)
                    {
                        txt += " " + arr[x, y, z] + " ";
                    }
                    txt += ") ";
                }
                randNum_lb.Items.Add(txt);
            }
        }

        private void show_btn_Click(object sender, EventArgs e)
        {
            var min = ThreeDimensional.minNum;
            var arr = ThreeDimensional.threeDimen;
            result_win_lb.Items.Add("Minimum: " + min + ", an Position:");
            for (int x = 0; x < 6; x++)
            {
                for (int y = 0; y < 3; y++)
                {
                    for (int z = 0; z < 4; z++)
                    {
                        if (arr[x, y, z] == min)
                        {
                            var txt = "Zeile " + x + " ,Gruppe " + y + " ,Element " + z;
                            result_win_lb.Items.Add(txt);
                        }
                    }
                }
            }
        }
    }

    public class ThreeDimensional
    {
        public static int[,,] threeDimen = new int[6, 3, 4];
        public static int minNum { get; set;}

        public static void FillThreeDimensionalArrAndFindMinNumb()
        {
            int min = Int32.MaxValue;
            var rand = new Random();
            for(int i = 0; i < 6; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    for(int k = 0; k < 4; k++)
                    {
                        threeDimen[i, j, k] = rand.Next(1, 100);
                        min = threeDimen[i, j, k] < min ? threeDimen[i, j, k] : min;
                    }
                }
            }
            minNum = min;
        }
    }
}
