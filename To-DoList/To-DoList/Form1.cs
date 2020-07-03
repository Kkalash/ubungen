using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace To_DoList
{
    public partial class to_Do_List_form : Form
    {
        public to_Do_List_form()
        {
            InitializeComponent();
            delete_btn.Enabled = false;
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            while (toDoList_lb.SelectedItems.Count != 0)
            {
                toDoList_lb.Items.Remove(toDoList_lb.SelectedItems[0]);
            }
        }

        private void toDoList_lb_SelectedIndexChanged(object sender, EventArgs e)
        {
            var isNull = toDoList_lb.Items.Count == 0 || toDoList_lb.SelectedIndex < 0;
            delete_btn.Enabled = !isNull;
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
           var txtToAdd = ShowDialog();
            toDoList_lb.Items.Add(txtToAdd);
        }

        public static new string ShowDialog()
        {
            Form prompt = new Form()
            {
                Width = 500,
                Height = 90,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = "Add new",
                StartPosition = FormStartPosition.CenterScreen
            };

            TextBox textBox = new TextBox() { Left = 20, Top = 10, Width = 350 };
            Button confirmation = new Button() { Text = "OK", Left = 380, Width = 80, Top = 10, DialogResult = DialogResult.OK };
            confirmation.Click += (sender, e) => { prompt.Close(); };
            prompt.Controls.Add(textBox);
            prompt.Controls.Add(confirmation);
            prompt.AcceptButton = confirmation;

            return prompt.ShowDialog() == DialogResult.OK ? textBox.Text : "";
        }
    }
}
