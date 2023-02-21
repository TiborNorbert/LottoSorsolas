namespace LottoSorsolas
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.sorsolas = new System.Windows.Forms.Button();
            this.Panel = new System.Windows.Forms.Panel();
            this.nyeroszamok = new System.Windows.Forms.Label();
            this.megjatszot = new System.Windows.Forms.Label();
            this.talalata = new System.Windows.Forms.Label();
            this.megjatszott = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // sorsolas
            // 
            this.sorsolas.Image = global::LottoSorsolas.Properties.Resources.shamrock_lucky_icon;
            this.sorsolas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sorsolas.Location = new System.Drawing.Point(80, 329);
            this.sorsolas.Name = "sorsolas";
            this.sorsolas.Size = new System.Drawing.Size(91, 38);
            this.sorsolas.TabIndex = 0;
            this.sorsolas.Text = "Sorsolás";
            this.sorsolas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.sorsolas.UseVisualStyleBackColor = true;
            this.sorsolas.Click += new System.EventHandler(this.sorsolas_Click);
            // 
            // Panel
            // 
            this.Panel.Location = new System.Drawing.Point(25, 19);
            this.Panel.Name = "Panel";
            this.Panel.Size = new System.Drawing.Size(763, 248);
            this.Panel.TabIndex = 1;
            // 
            // nyeroszamok
            // 
            this.nyeroszamok.AutoSize = true;
            this.nyeroszamok.ForeColor = System.Drawing.Color.Green;
            this.nyeroszamok.Location = new System.Drawing.Point(345, 306);
            this.nyeroszamok.Name = "nyeroszamok";
            this.nyeroszamok.Size = new System.Drawing.Size(82, 13);
            this.nyeroszamok.TabIndex = 2;
            this.nyeroszamok.Text = "NyerőSzámok->";
            // 
            // megjatszot
            // 
            this.megjatszot.AutoSize = true;
            this.megjatszot.Location = new System.Drawing.Point(345, 342);
            this.megjatszot.Name = "megjatszot";
            this.megjatszot.Size = new System.Drawing.Size(70, 13);
            this.megjatszot.TabIndex = 3;
            this.megjatszot.Text = "Megjátszott->";
            // 
            // talalata
            // 
            this.talalata.AutoSize = true;
            this.talalata.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.talalata.Location = new System.Drawing.Point(345, 376);
            this.talalata.Name = "talalata";
            this.talalata.Size = new System.Drawing.Size(48, 13);
            this.talalata.TabIndex = 4;
            this.talalata.Text = "Találat->";
            // 
            // megjatszott
            // 
            this.megjatszott.AutoSize = true;
            this.megjatszott.Location = new System.Drawing.Point(433, 342);
            this.megjatszott.Name = "megjatszott";
            this.megjatszott.Size = new System.Drawing.Size(0, 13);
            this.megjatszott.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.megjatszott);
            this.Controls.Add(this.talalata);
            this.Controls.Add(this.megjatszot);
            this.Controls.Add(this.nyeroszamok);
            this.Controls.Add(this.Panel);
            this.Controls.Add(this.sorsolas);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button sorsolas;
        private System.Windows.Forms.Panel Panel;
        private System.Windows.Forms.Label nyeroszamok;
        private System.Windows.Forms.Label megjatszot;
        private System.Windows.Forms.Label talalata;
        private System.Windows.Forms.Label megjatszott;
    }
}

