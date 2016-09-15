namespace PokemonProject
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pikachuCounter = new System.Windows.Forms.NumericUpDown();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.SquirtleCounter = new System.Windows.Forms.NumericUpDown();
            this.CharmanderCounter = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.costLabel = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pikachuCounter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SquirtleCounter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CharmanderCounter)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(118, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Pikachu - $6";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(118, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Squirtle - $5";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(118, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Charmander - $5";
            // 
            // pikachuCounter
            // 
            this.pikachuCounter.Location = new System.Drawing.Point(230, 75);
            this.pikachuCounter.Name = "pikachuCounter";
            this.pikachuCounter.Size = new System.Drawing.Size(120, 20);
            this.pikachuCounter.TabIndex = 6;
            this.pikachuCounter.ValueChanged += new System.EventHandler(this.pikachuCounter_ValueChanged);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::PokemonProject.Properties.Resources._004Charmander_OS_anime;
            this.pictureBox3.Location = new System.Drawing.Point(12, 168);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(100, 50);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::PokemonProject.Properties.Resources.squirtle_by_mighty355_d7dwh31;
            this.pictureBox2.Location = new System.Drawing.Point(12, 112);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PokemonProject.Properties.Resources._025Pikachu_OS_anime_11;
            this.pictureBox1.Location = new System.Drawing.Point(12, 56);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // SquirtleCounter
            // 
            this.SquirtleCounter.Location = new System.Drawing.Point(230, 128);
            this.SquirtleCounter.Name = "SquirtleCounter";
            this.SquirtleCounter.Size = new System.Drawing.Size(120, 20);
            this.SquirtleCounter.TabIndex = 7;
            this.SquirtleCounter.ValueChanged += new System.EventHandler(this.SquirtleCounter_ValueChanged);
            // 
            // CharmanderCounter
            // 
            this.CharmanderCounter.Location = new System.Drawing.Point(230, 187);
            this.CharmanderCounter.Name = "CharmanderCounter";
            this.CharmanderCounter.Size = new System.Drawing.Size(120, 20);
            this.CharmanderCounter.TabIndex = 8;
            this.CharmanderCounter.ValueChanged += new System.EventHandler(this.CharmanderCounter_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(147, 288);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Total Cost:";
            // 
            // costLabel
            // 
            this.costLabel.AutoSize = true;
            this.costLabel.Location = new System.Drawing.Point(211, 288);
            this.costLabel.Name = "costLabel";
            this.costLabel.Size = new System.Drawing.Size(19, 13);
            this.costLabel.TabIndex = 10;
            this.costLabel.Text = "$0";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(239, 244);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(88, 23);
            this.btnCalculate.TabIndex = 11;
            this.btnCalculate.Text = "Calculate Cost";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(450, 414);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.costLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CharmanderCounter);
            this.Controls.Add(this.SquirtleCounter);
            this.Controls.Add(this.pikachuCounter);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Pokemon Store";
            ((System.ComponentModel.ISupportInitialize)(this.pikachuCounter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SquirtleCounter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CharmanderCounter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown pikachuCounter;
        private System.Windows.Forms.NumericUpDown SquirtleCounter;
        private System.Windows.Forms.NumericUpDown CharmanderCounter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label costLabel;
        private System.Windows.Forms.Button btnCalculate;
    }
}

