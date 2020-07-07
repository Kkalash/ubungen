namespace ThreeDimensional
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
            this.randNum_lb = new System.Windows.Forms.ListBox();
            this.result_win_lb = new System.Windows.Forms.ListBox();
            this.show_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // randNum_lb
            // 
            this.randNum_lb.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.randNum_lb.FormattingEnabled = true;
            this.randNum_lb.ItemHeight = 15;
            this.randNum_lb.Location = new System.Drawing.Point(4, 3);
            this.randNum_lb.Name = "randNum_lb";
            this.randNum_lb.Size = new System.Drawing.Size(313, 154);
            this.randNum_lb.TabIndex = 4;
            // 
            // result_win_lb
            // 
            this.result_win_lb.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.result_win_lb.FormattingEnabled = true;
            this.result_win_lb.ItemHeight = 14;
            this.result_win_lb.Location = new System.Drawing.Point(4, 170);
            this.result_win_lb.Name = "result_win_lb";
            this.result_win_lb.Size = new System.Drawing.Size(313, 186);
            this.result_win_lb.TabIndex = 5;
            // 
            // show_btn
            // 
            this.show_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.show_btn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.show_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.show_btn.Location = new System.Drawing.Point(224, 181);
            this.show_btn.Name = "show_btn";
            this.show_btn.Size = new System.Drawing.Size(75, 23);
            this.show_btn.TabIndex = 6;
            this.show_btn.Text = "Show";
            this.show_btn.UseVisualStyleBackColor = true;
            this.show_btn.Click += new System.EventHandler(this.show_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 383);
            this.Controls.Add(this.show_btn);
            this.Controls.Add(this.result_win_lb);
            this.Controls.Add(this.randNum_lb);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListBox randNum_lb;
        private System.Windows.Forms.ListBox result_win_lb;
        private System.Windows.Forms.Button show_btn;
    }
}

