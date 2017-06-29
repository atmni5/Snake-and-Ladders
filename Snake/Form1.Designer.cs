namespace Snake
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.compupnl2 = new System.Windows.Forms.Panel();
            this.compupnl3 = new System.Windows.Forms.Panel();
            this.compupnl1 = new System.Windows.Forms.Panel();
            this.humanpnl = new System.Windows.Forms.Panel();
            this.humanlbl = new System.Windows.Forms.Label();
            this.computer1lbl = new System.Windows.Forms.Label();
            this.computer2lbl = new System.Windows.Forms.Label();
            this.computer3lbl = new System.Windows.Forms.Label();
            this.humanposlbl = new System.Windows.Forms.Label();
            this.computer1poslbl = new System.Windows.Forms.Label();
            this.computer2poslbl = new System.Windows.Forms.Label();
            this.computer3poslbl = new System.Windows.Forms.Label();
            this.playlbl = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.Controls.Add(this.humanpnl);
            this.panel1.Controls.Add(this.compupnl2);
            this.panel1.Controls.Add(this.compupnl3);
            this.panel1.Controls.Add(this.compupnl1);
            this.panel1.Location = new System.Drawing.Point(270, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(500, 500);
            this.panel1.TabIndex = 0;
            // 
            // compupnl2
            // 
            this.compupnl2.BackColor = System.Drawing.Color.Red;
            this.compupnl2.Location = new System.Drawing.Point(0, 475);
            this.compupnl2.Name = "compupnl2";
            this.compupnl2.Size = new System.Drawing.Size(25, 25);
            this.compupnl2.TabIndex = 3;
            // 
            // compupnl3
            // 
            this.compupnl3.BackColor = System.Drawing.Color.Red;
            this.compupnl3.Location = new System.Drawing.Point(25, 475);
            this.compupnl3.Name = "compupnl3";
            this.compupnl3.Size = new System.Drawing.Size(25, 25);
            this.compupnl3.TabIndex = 2;
            // 
            // compupnl1
            // 
            this.compupnl1.BackColor = System.Drawing.Color.Red;
            this.compupnl1.Location = new System.Drawing.Point(25, 450);
            this.compupnl1.Name = "compupnl1";
            this.compupnl1.Size = new System.Drawing.Size(25, 25);
            this.compupnl1.TabIndex = 1;
            // 
            // humanpnl
            // 
            this.humanpnl.BackColor = System.Drawing.Color.Black;
            this.humanpnl.ForeColor = System.Drawing.SystemColors.Control;
            this.humanpnl.Location = new System.Drawing.Point(0, 450);
            this.humanpnl.Name = "humanpnl";
            this.humanpnl.Size = new System.Drawing.Size(25, 25);
            this.humanpnl.TabIndex = 0;
            // 
            // humanlbl
            // 
            this.humanlbl.AutoSize = true;
            this.humanlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.humanlbl.Location = new System.Drawing.Point(1, 24);
            this.humanlbl.Name = "humanlbl";
            this.humanlbl.Size = new System.Drawing.Size(163, 24);
            this.humanlbl.TabIndex = 1;
            this.humanlbl.Text = "Human Position:";
            // 
            // computer1lbl
            // 
            this.computer1lbl.AutoSize = true;
            this.computer1lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.computer1lbl.Location = new System.Drawing.Point(1, 66);
            this.computer1lbl.Name = "computer1lbl";
            this.computer1lbl.Size = new System.Drawing.Size(198, 24);
            this.computer1lbl.TabIndex = 2;
            this.computer1lbl.Text = "Computer1 Position:";
            // 
            // computer2lbl
            // 
            this.computer2lbl.AutoSize = true;
            this.computer2lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.computer2lbl.Location = new System.Drawing.Point(1, 108);
            this.computer2lbl.Name = "computer2lbl";
            this.computer2lbl.Size = new System.Drawing.Size(198, 24);
            this.computer2lbl.TabIndex = 3;
            this.computer2lbl.Text = "Computer2 Position:";
            // 
            // computer3lbl
            // 
            this.computer3lbl.AutoSize = true;
            this.computer3lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.computer3lbl.Location = new System.Drawing.Point(1, 154);
            this.computer3lbl.Name = "computer3lbl";
            this.computer3lbl.Size = new System.Drawing.Size(198, 24);
            this.computer3lbl.TabIndex = 4;
            this.computer3lbl.Text = "Computer3 Position:";
            // 
            // humanposlbl
            // 
            this.humanposlbl.AutoSize = true;
            this.humanposlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.humanposlbl.Location = new System.Drawing.Point(205, 24);
            this.humanposlbl.Name = "humanposlbl";
            this.humanposlbl.Size = new System.Drawing.Size(21, 24);
            this.humanposlbl.TabIndex = 5;
            this.humanposlbl.Text = "1";
            // 
            // computer1poslbl
            // 
            this.computer1poslbl.AutoSize = true;
            this.computer1poslbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.computer1poslbl.Location = new System.Drawing.Point(205, 66);
            this.computer1poslbl.Name = "computer1poslbl";
            this.computer1poslbl.Size = new System.Drawing.Size(21, 24);
            this.computer1poslbl.TabIndex = 6;
            this.computer1poslbl.Text = "1";
            // 
            // computer2poslbl
            // 
            this.computer2poslbl.AutoSize = true;
            this.computer2poslbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.computer2poslbl.Location = new System.Drawing.Point(205, 108);
            this.computer2poslbl.Name = "computer2poslbl";
            this.computer2poslbl.Size = new System.Drawing.Size(21, 24);
            this.computer2poslbl.TabIndex = 7;
            this.computer2poslbl.Text = "1";
            // 
            // computer3poslbl
            // 
            this.computer3poslbl.AutoSize = true;
            this.computer3poslbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.computer3poslbl.Location = new System.Drawing.Point(205, 154);
            this.computer3poslbl.Name = "computer3poslbl";
            this.computer3poslbl.Size = new System.Drawing.Size(21, 24);
            this.computer3poslbl.TabIndex = 8;
            this.computer3poslbl.Text = "1";
            // 
            // playlbl
            // 
            this.playlbl.AutoSize = true;
            this.playlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playlbl.Location = new System.Drawing.Point(8, 416);
            this.playlbl.Name = "playlbl";
            this.playlbl.Size = new System.Drawing.Size(237, 66);
            this.playlbl.TabIndex = 9;
            this.playlbl.Text = "Mash The Enter\r\nButton To Play!!";
            this.playlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(789, 512);
            this.Controls.Add(this.playlbl);
            this.Controls.Add(this.computer3poslbl);
            this.Controls.Add(this.computer2poslbl);
            this.Controls.Add(this.computer1poslbl);
            this.Controls.Add(this.humanposlbl);
            this.Controls.Add(this.computer3lbl);
            this.Controls.Add(this.computer2lbl);
            this.Controls.Add(this.computer1lbl);
            this.Controls.Add(this.humanlbl);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel compupnl2;
        private System.Windows.Forms.Panel compupnl3;
        private System.Windows.Forms.Panel compupnl1;
        private System.Windows.Forms.Panel humanpnl;
        private System.Windows.Forms.Label humanlbl;
        private System.Windows.Forms.Label computer1lbl;
        private System.Windows.Forms.Label computer2lbl;
        private System.Windows.Forms.Label computer3lbl;
        private System.Windows.Forms.Label humanposlbl;
        private System.Windows.Forms.Label computer1poslbl;
        private System.Windows.Forms.Label computer2poslbl;
        private System.Windows.Forms.Label computer3poslbl;
        private System.Windows.Forms.Label playlbl;
    }
}

