namespace WindowsFormsApp1.Forms
{
    partial class FormFoods
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFoods));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bbqnum = new System.Windows.Forms.NumericUpDown();
            this.piznum = new System.Windows.Forms.NumericUpDown();
            this.burnum = new System.Windows.Forms.NumericUpDown();
            this.pornum = new System.Windows.Forms.NumericUpDown();
            this.stanum = new System.Windows.Forms.NumericUpDown();
            this.salnum = new System.Windows.Forms.NumericUpDown();
            this.bbq = new System.Windows.Forms.CheckBox();
            this.pizza = new System.Windows.Forms.CheckBox();
            this.burgers = new System.Windows.Forms.CheckBox();
            this.porkchop = new System.Windows.Forms.CheckBox();
            this.steak = new System.Windows.Forms.CheckBox();
            this.salad = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnorderfoods = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bbqnum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.piznum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.burnum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pornum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stanum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salnum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.bbqnum);
            this.groupBox1.Controls.Add(this.piznum);
            this.groupBox1.Controls.Add(this.burnum);
            this.groupBox1.Controls.Add(this.pornum);
            this.groupBox1.Controls.Add(this.stanum);
            this.groupBox1.Controls.Add(this.salnum);
            this.groupBox1.Controls.Add(this.bbq);
            this.groupBox1.Controls.Add(this.pizza);
            this.groupBox1.Controls.Add(this.burgers);
            this.groupBox1.Controls.Add(this.porkchop);
            this.groupBox1.Controls.Add(this.steak);
            this.groupBox1.Controls.Add(this.salad);
            this.groupBox1.Location = new System.Drawing.Point(15, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(485, 300);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // bbqnum
            // 
            this.bbqnum.Location = new System.Drawing.Point(441, 269);
            this.bbqnum.Name = "bbqnum";
            this.bbqnum.Size = new System.Drawing.Size(39, 20);
            this.bbqnum.TabIndex = 11;
            // 
            // piznum
            // 
            this.piznum.Location = new System.Drawing.Point(441, 226);
            this.piznum.Name = "piznum";
            this.piznum.Size = new System.Drawing.Size(39, 20);
            this.piznum.TabIndex = 10;
            // 
            // burnum
            // 
            this.burnum.Location = new System.Drawing.Point(441, 182);
            this.burnum.Name = "burnum";
            this.burnum.Size = new System.Drawing.Size(39, 20);
            this.burnum.TabIndex = 9;
            // 
            // pornum
            // 
            this.pornum.Location = new System.Drawing.Point(441, 138);
            this.pornum.Name = "pornum";
            this.pornum.Size = new System.Drawing.Size(39, 20);
            this.pornum.TabIndex = 8;
            // 
            // stanum
            // 
            this.stanum.Location = new System.Drawing.Point(441, 94);
            this.stanum.Name = "stanum";
            this.stanum.Size = new System.Drawing.Size(39, 20);
            this.stanum.TabIndex = 7;
            // 
            // salnum
            // 
            this.salnum.Location = new System.Drawing.Point(442, 50);
            this.salnum.Name = "salnum";
            this.salnum.Size = new System.Drawing.Size(39, 20);
            this.salnum.TabIndex = 6;
            // 
            // bbq
            // 
            this.bbq.AutoSize = true;
            this.bbq.Font = new System.Drawing.Font("supermarket", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bbq.Location = new System.Drawing.Point(11, 258);
            this.bbq.Name = "bbq";
            this.bbq.Size = new System.Drawing.Size(439, 38);
            this.bbq.TabIndex = 5;
            this.bbq.Text = "BBQ ............................................................ 89 Baht";
            this.bbq.UseVisualStyleBackColor = true;
            // 
            // pizza
            // 
            this.pizza.AutoSize = true;
            this.pizza.Font = new System.Drawing.Font("supermarket", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pizza.Location = new System.Drawing.Point(11, 214);
            this.pizza.Name = "pizza";
            this.pizza.Size = new System.Drawing.Size(438, 38);
            this.pizza.TabIndex = 4;
            this.pizza.Text = "Pizza ....................................................... 269 Baht";
            this.pizza.UseVisualStyleBackColor = true;
            // 
            // burgers
            // 
            this.burgers.AutoSize = true;
            this.burgers.Font = new System.Drawing.Font("supermarket", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.burgers.Location = new System.Drawing.Point(12, 170);
            this.burgers.Name = "burgers";
            this.burgers.Size = new System.Drawing.Size(438, 38);
            this.burgers.TabIndex = 3;
            this.burgers.Text = "Burgers ...................................................... 69 Baht";
            this.burgers.UseVisualStyleBackColor = true;
            // 
            // porkchop
            // 
            this.porkchop.AutoSize = true;
            this.porkchop.Font = new System.Drawing.Font("supermarket", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.porkchop.Location = new System.Drawing.Point(12, 126);
            this.porkchop.Name = "porkchop";
            this.porkchop.Size = new System.Drawing.Size(439, 38);
            this.porkchop.TabIndex = 2;
            this.porkchop.Text = "Pork chop ...............................................  159 Baht";
            this.porkchop.UseVisualStyleBackColor = true;
            // 
            // steak
            // 
            this.steak.AutoSize = true;
            this.steak.Font = new System.Drawing.Font("supermarket", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.steak.Location = new System.Drawing.Point(12, 82);
            this.steak.Name = "steak";
            this.steak.Size = new System.Drawing.Size(439, 38);
            this.steak.TabIndex = 1;
            this.steak.Text = "Steak ......................................................  199 Baht";
            this.steak.UseVisualStyleBackColor = true;
            // 
            // salad
            // 
            this.salad.AutoSize = true;
            this.salad.Font = new System.Drawing.Font("supermarket", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salad.Location = new System.Drawing.Point(12, 38);
            this.salad.Name = "salad";
            this.salad.Size = new System.Drawing.Size(439, 38);
            this.salad.TabIndex = 0;
            this.salad.Text = "Salad ........................................................  89 Baht";
            this.salad.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Elianto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "MENU";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(510, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(313, 449);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // btnorderfoods
            // 
            this.btnorderfoods.Font = new System.Drawing.Font("Elianto", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnorderfoods.ForeColor = System.Drawing.Color.Red;
            this.btnorderfoods.Location = new System.Drawing.Point(172, 367);
            this.btnorderfoods.Name = "btnorderfoods";
            this.btnorderfoods.Size = new System.Drawing.Size(153, 35);
            this.btnorderfoods.TabIndex = 14;
            this.btnorderfoods.Text = "Order Here";
            this.btnorderfoods.UseVisualStyleBackColor = true;
            this.btnorderfoods.Click += new System.EventHandler(this.btnorderfoods_Click);
            // 
            // FormFoods
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 450);
            this.Controls.Add(this.btnorderfoods);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormFoods";
            this.Text = "Foods";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bbqnum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.piznum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.burnum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pornum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stanum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salnum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox burgers;
        private System.Windows.Forms.CheckBox porkchop;
        private System.Windows.Forms.CheckBox steak;
        private System.Windows.Forms.CheckBox salad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox bbq;
        private System.Windows.Forms.CheckBox pizza;
        private System.Windows.Forms.NumericUpDown bbqnum;
        private System.Windows.Forms.NumericUpDown piznum;
        private System.Windows.Forms.NumericUpDown burnum;
        private System.Windows.Forms.NumericUpDown pornum;
        private System.Windows.Forms.NumericUpDown stanum;
        private System.Windows.Forms.NumericUpDown salnum;
        private System.Windows.Forms.Button btnorderfoods;
    }
}