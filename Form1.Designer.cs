using System;

namespace HotelMenagementSystem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.labelUser = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnFruitTea = new System.Windows.Forms.Button();
            this.btnGreenTea = new System.Windows.Forms.Button();
            this.btnHerbTea = new System.Windows.Forms.Button();
            this.btnHotChocolate = new System.Windows.Forms.Button();
            this.btnMocaccino = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.BtnCapuchino = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnFreshJuice = new System.Windows.Forms.Button();
            this.btnMilkShake = new System.Windows.Forms.Button();
            this.btnSmoothie = new System.Windows.Forms.Button();
            this.btnIcedCoffee = new System.Windows.Forms.Button();
            this.btnIcedTea = new System.Windows.Forms.Button();
            this.btnLemonade = new System.Windows.Forms.Button();
            this.btnSoftDrink = new System.Windows.Forms.Button();
            this.btnWater = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonCheckOut = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.TotalBill = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelCurrent = new System.Windows.Forms.ToolStripStatusLabel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(204)))), ((int)(((byte)(222)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Name = "panel1";
            // 
            // panel3
            // 
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.labelUser);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Name = "panel3";
            // 
            // labelUser
            // 
            resources.ApplyResources(this.labelUser, "labelUser");
            this.labelUser.Name = "labelUser";
            this.labelUser.Click += new System.EventHandler(this.label6_Click);
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // panel2
            // 
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(204)))), ((int)(((byte)(222)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.btnFruitTea);
            this.panel2.Controls.Add(this.btnGreenTea);
            this.panel2.Controls.Add(this.btnHerbTea);
            this.panel2.Controls.Add(this.btnHotChocolate);
            this.panel2.Controls.Add(this.btnMocaccino);
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.BtnCapuchino);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Name = "panel2";
            // 
            // btnFruitTea
            // 
            resources.ApplyResources(this.btnFruitTea, "btnFruitTea");
            this.btnFruitTea.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFruitTea.Name = "btnFruitTea";
            this.btnFruitTea.UseVisualStyleBackColor = true;
            this.btnFruitTea.Click += new System.EventHandler(this.btnFruitTea_Click);
            // 
            // btnGreenTea
            // 
            resources.ApplyResources(this.btnGreenTea, "btnGreenTea");
            this.btnGreenTea.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGreenTea.Name = "btnGreenTea";
            this.btnGreenTea.UseVisualStyleBackColor = true;
            this.btnGreenTea.Click += new System.EventHandler(this.btnGreenTea_Click);
            // 
            // btnHerbTea
            // 
            resources.ApplyResources(this.btnHerbTea, "btnHerbTea");
            this.btnHerbTea.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHerbTea.Name = "btnHerbTea";
            this.btnHerbTea.UseVisualStyleBackColor = true;
            this.btnHerbTea.Click += new System.EventHandler(this.btnHerbTea_Click);
            // 
            // btnHotChocolate
            // 
            resources.ApplyResources(this.btnHotChocolate, "btnHotChocolate");
            this.btnHotChocolate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHotChocolate.Name = "btnHotChocolate";
            this.btnHotChocolate.UseVisualStyleBackColor = true;
            this.btnHotChocolate.Click += new System.EventHandler(this.btnHotChocolate_Click);
            // 
            // btnMocaccino
            // 
            resources.ApplyResources(this.btnMocaccino, "btnMocaccino");
            this.btnMocaccino.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMocaccino.Name = "btnMocaccino";
            this.btnMocaccino.UseVisualStyleBackColor = true;
            this.btnMocaccino.Click += new System.EventHandler(this.btnMocaccino_Click);
            // 
            // button5
            // 
            resources.ApplyResources(this.button5, "button5");
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.Name = "button5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            resources.ApplyResources(this.button4, "button4");
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.Name = "button4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // BtnCapuchino
            // 
            resources.ApplyResources(this.BtnCapuchino, "BtnCapuchino");
            this.BtnCapuchino.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCapuchino.Name = "BtnCapuchino";
            this.BtnCapuchino.UseVisualStyleBackColor = true;
            this.BtnCapuchino.Click += new System.EventHandler(this.BtnCapuchino_Click);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // panel4
            // 
            resources.ApplyResources(this.panel4, "panel4");
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(204)))), ((int)(((byte)(222)))));
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.btnFreshJuice);
            this.panel4.Controls.Add(this.btnMilkShake);
            this.panel4.Controls.Add(this.btnSmoothie);
            this.panel4.Controls.Add(this.btnIcedCoffee);
            this.panel4.Controls.Add(this.btnIcedTea);
            this.panel4.Controls.Add(this.btnLemonade);
            this.panel4.Controls.Add(this.btnSoftDrink);
            this.panel4.Controls.Add(this.btnWater);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Name = "panel4";
            // 
            // btnFreshJuice
            // 
            resources.ApplyResources(this.btnFreshJuice, "btnFreshJuice");
            this.btnFreshJuice.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFreshJuice.Name = "btnFreshJuice";
            this.btnFreshJuice.UseVisualStyleBackColor = true;
            this.btnFreshJuice.Click += new System.EventHandler(this.btnFreshJuice_Click);
            // 
            // btnMilkShake
            // 
            resources.ApplyResources(this.btnMilkShake, "btnMilkShake");
            this.btnMilkShake.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMilkShake.Name = "btnMilkShake";
            this.btnMilkShake.UseVisualStyleBackColor = true;
            this.btnMilkShake.Click += new System.EventHandler(this.btnMilkShake_Click);
            // 
            // btnSmoothie
            // 
            resources.ApplyResources(this.btnSmoothie, "btnSmoothie");
            this.btnSmoothie.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSmoothie.Name = "btnSmoothie";
            this.btnSmoothie.UseVisualStyleBackColor = true;
            this.btnSmoothie.Click += new System.EventHandler(this.btnSmoothie_Click);
            // 
            // btnIcedCoffee
            // 
            resources.ApplyResources(this.btnIcedCoffee, "btnIcedCoffee");
            this.btnIcedCoffee.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIcedCoffee.Name = "btnIcedCoffee";
            this.btnIcedCoffee.UseVisualStyleBackColor = true;
            this.btnIcedCoffee.Click += new System.EventHandler(this.btnIcedCoffee_Click);
            // 
            // btnIcedTea
            // 
            resources.ApplyResources(this.btnIcedTea, "btnIcedTea");
            this.btnIcedTea.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIcedTea.Name = "btnIcedTea";
            this.btnIcedTea.UseVisualStyleBackColor = true;
            this.btnIcedTea.Click += new System.EventHandler(this.btnIcedTea_Click);
            // 
            // btnLemonade
            // 
            resources.ApplyResources(this.btnLemonade, "btnLemonade");
            this.btnLemonade.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLemonade.Name = "btnLemonade";
            this.btnLemonade.UseVisualStyleBackColor = true;
            this.btnLemonade.Click += new System.EventHandler(this.btnLemonade_Click);
            // 
            // btnSoftDrink
            // 
            resources.ApplyResources(this.btnSoftDrink, "btnSoftDrink");
            this.btnSoftDrink.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSoftDrink.Name = "btnSoftDrink";
            this.btnSoftDrink.UseVisualStyleBackColor = true;
            this.btnSoftDrink.Click += new System.EventHandler(this.btnSoftDrink_Click);
            // 
            // btnWater
            // 
            resources.ApplyResources(this.btnWater, "btnWater");
            this.btnWater.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnWater.Name = "btnWater";
            this.btnWater.UseVisualStyleBackColor = true;
            this.btnWater.Click += new System.EventHandler(this.btnWater_Click);
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // buttonCheckOut
            // 
            resources.ApplyResources(this.buttonCheckOut, "buttonCheckOut");
            this.buttonCheckOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCheckOut.Name = "buttonCheckOut";
            this.buttonCheckOut.UseVisualStyleBackColor = true;
            this.buttonCheckOut.Click += new System.EventHandler(this.buttonCheckOut_Click);
            // 
            // buttonExit
            // 
            resources.ApplyResources(this.buttonExit, "buttonExit");
            this.buttonExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // resetButton
            // 
            resources.ApplyResources(this.resetButton, "resetButton");
            this.resetButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.resetButton.Name = "resetButton";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // TotalBill
            // 
            resources.ApplyResources(this.TotalBill, "TotalBill");
            this.TotalBill.Name = "TotalBill";
            // 
            // listView1
            // 
            resources.ApplyResources(this.listView1, "listView1");
            this.listView1.HideSelection = false;
            this.listView1.Name = "listView1";
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Name = "label4";
            // 
            // statusStrip1
            // 
            resources.ApplyResources(this.statusStrip1, "statusStrip1");
            this.statusStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(146)))), ((int)(((byte)(176)))));
            this.statusStrip1.GripMargin = new System.Windows.Forms.Padding(0);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelCurrent});
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.Stretch = false;
            // 
            // toolStripStatusLabelCurrent
            // 
            resources.ApplyResources(this.toolStripStatusLabelCurrent, "toolStripStatusLabelCurrent");
            this.toolStripStatusLabelCurrent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(146)))), ((int)(((byte)(176)))));
            this.toolStripStatusLabelCurrent.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripStatusLabelCurrent.LinkColor = System.Drawing.Color.White;
            this.toolStripStatusLabelCurrent.Margin = new System.Windows.Forms.Padding(0);
            this.toolStripStatusLabelCurrent.Name = "toolStripStatusLabelCurrent";
            // 
            // pictureBox2
            // 
            resources.ApplyResources(this.pictureBox2, "pictureBox2");
            this.pictureBox2.Image = global::CafeManagementSystem.Properties.Resources.giphy;
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(146)))), ((int)(((byte)(176)))));
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.TotalBill);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonCheckOut);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonCheckOut;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button BtnCapuchino;
        private System.Windows.Forms.TextBox TotalBill;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btnMocaccino;
        private System.Windows.Forms.Button btnHotChocolate;
        private System.Windows.Forms.Button btnHerbTea;
        private System.Windows.Forms.Button btnGreenTea;
        private System.Windows.Forms.Button btnFruitTea;
        private System.Windows.Forms.Button btnWater;
        private System.Windows.Forms.Button btnSoftDrink;
        private System.Windows.Forms.Button btnLemonade;
        private System.Windows.Forms.Button btnIcedTea;
        private System.Windows.Forms.Button btnIcedCoffee;
        private System.Windows.Forms.Button btnSmoothie;
        private System.Windows.Forms.Button btnMilkShake;
        private System.Windows.Forms.Button btnFreshJuice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelCurrent;
        public System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

