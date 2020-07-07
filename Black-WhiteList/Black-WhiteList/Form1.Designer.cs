namespace Black_WhiteList
{
    partial class Form1
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
            this.white_list_lb = new System.Windows.Forms.ListBox();
            this.black_list_lb = new System.Windows.Forms.ListBox();
            this.to_white_list_btn = new System.Windows.Forms.Button();
            this.to_black_list_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // white_list_lb
            // 
            this.white_list_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.white_list_lb.FormattingEnabled = true;
            this.white_list_lb.ItemHeight = 20;
            this.white_list_lb.Items.AddRange(new object[] {
            "C#",
            "Ruby",
            "JS",
            "PHP"});
            this.white_list_lb.Location = new System.Drawing.Point(12, 14);
            this.white_list_lb.Name = "white_list_lb";
            this.white_list_lb.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.white_list_lb.Size = new System.Drawing.Size(159, 424);
            this.white_list_lb.TabIndex = 0;
            // 
            // black_list_lb
            // 
            this.black_list_lb.BackColor = System.Drawing.SystemColors.Window;
            this.black_list_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.black_list_lb.ForeColor = System.Drawing.SystemColors.MenuText;
            this.black_list_lb.FormattingEnabled = true;
            this.black_list_lb.ItemHeight = 18;
            this.black_list_lb.Items.AddRange(new object[] {
            "Java",
            "Python",
            "Css",
            "Html"});
            this.black_list_lb.Location = new System.Drawing.Point(294, 18);
            this.black_list_lb.Name = "black_list_lb";
            this.black_list_lb.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.black_list_lb.Size = new System.Drawing.Size(191, 418);
            this.black_list_lb.TabIndex = 1;
            // 
            // to_white_list_btn
            // 
            this.to_white_list_btn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.to_white_list_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.to_white_list_btn.Location = new System.Drawing.Point(193, 187);
            this.to_white_list_btn.Name = "to_white_list_btn";
            this.to_white_list_btn.Size = new System.Drawing.Size(75, 23);
            this.to_white_list_btn.TabIndex = 2;
            this.to_white_list_btn.Text = "<<<";
            this.to_white_list_btn.UseVisualStyleBackColor = true;
            this.to_white_list_btn.Click += new System.EventHandler(this.to_white_list_btn_Click);
            // 
            // to_black_list_btn
            // 
            this.to_black_list_btn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.to_black_list_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.to_black_list_btn.Location = new System.Drawing.Point(193, 216);
            this.to_black_list_btn.Name = "to_black_list_btn";
            this.to_black_list_btn.Size = new System.Drawing.Size(75, 23);
            this.to_black_list_btn.TabIndex = 3;
            this.to_black_list_btn.Text = ">>>";
            this.to_black_list_btn.UseVisualStyleBackColor = true;
            this.to_black_list_btn.Click += new System.EventHandler(this.to_black_list_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 450);
            this.Controls.Add(this.to_black_list_btn);
            this.Controls.Add(this.to_white_list_btn);
            this.Controls.Add(this.black_list_lb);
            this.Controls.Add(this.white_list_lb);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox white_list_lb;
        private System.Windows.Forms.ListBox black_list_lb;
        private System.Windows.Forms.Button to_white_list_btn;
        private System.Windows.Forms.Button to_black_list_btn;
    }
}

