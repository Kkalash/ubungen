namespace To_DoList
{
    partial class to_Do_List_form
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(to_Do_List_form));
            this.delete_btn = new System.Windows.Forms.Button();
            this.toDoList_lb = new System.Windows.Forms.ListBox();
            this.add_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // delete_btn
            // 
            this.delete_btn.BackColor = System.Drawing.Color.ForestGreen;
            this.delete_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.delete_btn.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_btn.ForeColor = System.Drawing.Color.White;
            this.delete_btn.Location = new System.Drawing.Point(105, 373);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(108, 32);
            this.delete_btn.TabIndex = 0;
            this.delete_btn.Text = "Delete";
            this.delete_btn.UseVisualStyleBackColor = false;
            this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click);
            // 
            // toDoList_lb
            // 
            this.toDoList_lb.BackColor = System.Drawing.SystemColors.Info;
            this.toDoList_lb.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.toDoList_lb.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toDoList_lb.FormattingEnabled = true;
            this.toDoList_lb.ItemHeight = 26;
            this.toDoList_lb.Items.AddRange(new object[] {
            "Java",
            "Css",
            "C#",
            "Python"});
            this.toDoList_lb.Location = new System.Drawing.Point(12, 12);
            this.toDoList_lb.Name = "toDoList_lb";
            this.toDoList_lb.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.toDoList_lb.Size = new System.Drawing.Size(315, 342);
            this.toDoList_lb.TabIndex = 1;
            this.toDoList_lb.SelectedIndexChanged += new System.EventHandler(this.toDoList_lb_SelectedIndexChanged);
            // 
            // add_btn
            // 
            this.add_btn.BackColor = System.Drawing.Color.ForestGreen;
            this.add_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.add_btn.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_btn.ForeColor = System.Drawing.Color.White;
            this.add_btn.Location = new System.Drawing.Point(219, 373);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(108, 32);
            this.add_btn.TabIndex = 2;
            this.add_btn.Text = "Add";
            this.add_btn.UseVisualStyleBackColor = false;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // to_Do_List_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 425);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.toDoList_lb);
            this.Controls.Add(this.delete_btn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "to_Do_List_form";
            this.Text = "To-Do-List";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button delete_btn;
        private System.Windows.Forms.ListBox toDoList_lb;
        private System.Windows.Forms.Button add_btn;
    }
}

