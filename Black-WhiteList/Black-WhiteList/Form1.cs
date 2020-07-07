using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Black_WhiteList
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void to_white_list_btn_Click(object sender, EventArgs e)
        {
            while(black_list_lb.SelectedItems.Count != 0)
            {
                white_list_lb.Items.Add(black_list_lb.SelectedItems[0]);
                black_list_lb.Items.Remove(black_list_lb.SelectedItems[0]);
            }
        }

        private void to_black_list_btn_Click(object sender, EventArgs e)
        {
            while(white_list_lb.SelectedItems.Count != 0)
            {
                black_list_lb.Items.Add(white_list_lb.SelectedItems[0]);
                white_list_lb.Items.Remove(white_list_lb.SelectedItems[0]);
            }
        }
    }
}
