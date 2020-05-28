namespace WindowsFormsApp1.Forms
{
    partial class FormDessert
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDessert));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cupnum = new System.Windows.Forms.NumericUpDown();
            this.wafnum = new System.Windows.Forms.NumericUpDown();
            this.pannum = new System.Windows.Forms.NumericUpDown();
            this.mufnum = new System.Windows.Forms.NumericUpDown();
            this.honnum = new System.Windows.Forms.NumericUpDown();
            this.cupcake = new System.Windows.Forms.CheckBox();
            this.waffle = new System.Windows.Forms.CheckBox();
            this.pancake = new System.Windows.Forms.CheckBox();
            this.muffin = new System.Windows.Forms.CheckBox();
            this.honey = new System.Windows.Forms.CheckBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnorderdessert = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cupnum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wafnum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pannum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mufnum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.honnum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Elianto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 35);
            this.label1.TabIndex = 6;
            this.label1.Text = "MENU";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.cupnum);
            this.groupBox1.Controls.Add(this.wafnum);
            this.groupBox1.Controls.Add(this.pannum);
            this.groupBox1.Controls.Add(this.mufnum);
            this.groupBox1.Controls.Add(this.honnum);
            this.groupBox1.Controls.Add(this.cupcake);
            this.groupBox1.Controls.Add(this.waffle);
            this.groupBox1.Controls.Add(this.pancake);
            this.groupBox1.Controls.Add(this.muffin);
            this.groupBox1.Controls.Add(this.honey);
            this.groupBox1.Location = new System.Drawing.Point(27, 44);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(640, 343);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // cupnum
            // 
            this.cupnum.Location = new System.Drawing.Point(591, 267);
            this.cupnum.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cupnum.Name = "cupnum";
            this.cupnum.Size = new System.Drawing.Size(52, 22);
            this.cupnum.TabIndex = 10;
            // 
            // wafnum
            // 
            this.wafnum.Location = new System.Drawing.Point(591, 213);
            this.wafnum.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.wafnum.Name = "wafnum";
            this.wafnum.Size = new System.Drawing.Size(52, 22);
            this.wafnum.TabIndex = 9;
            // 
            // pannum
            // 
            this.pannum.Location = new System.Drawing.Point(591, 160);
            this.pannum.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pannum.Name = "pannum";
            this.pannum.Size = new System.Drawing.Size(52, 22);
            this.pannum.TabIndex = 8;
            // 
            // mufnum
            // 
            this.mufnum.Location = new System.Drawing.Point(591, 105);
            this.mufnum.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mufnum.Name = "mufnum";
            this.mufnum.Size = new System.Drawing.Size(52, 22);
            this.mufnum.TabIndex = 7;
            // 
            // honnum
            // 
            this.honnum.Location = new System.Drawing.Point(592, 52);
            this.honnum.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.honnum.Name = "honnum";
            this.honnum.Size = new System.Drawing.Size(52, 22);
            this.honnum.TabIndex = 6;
            // 
            // cupcake
            // 
            this.cupcake.AutoSize = true;
            this.cupcake.Font = new System.Drawing.Font("supermarket", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cupcake.Location = new System.Drawing.Point(15, 252);
            this.cupcake.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cupcake.Name = "cupcake";
            this.cupcake.Size = new System.Drawing.Size(530, 46);
            this.cupcake.TabIndex = 4;
            this.cupcake.Text = "Cup Cake .................................................. 59 Baht";
            this.cupcake.UseVisualStyleBackColor = true;
            // 
            // waffle
            // 
            this.waffle.AutoSize = true;
            this.waffle.Font = new System.Drawing.Font("supermarket", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.waffle.Location = new System.Drawing.Point(16, 199);
            this.waffle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.waffle.Name = "waffle";
            this.waffle.Size = new System.Drawing.Size(530, 46);
            this.waffle.TabIndex = 3;
            this.waffle.Text = "Waffle ....................................................... 59 Baht";
            this.waffle.UseVisualStyleBackColor = true;
            // 
            // pancake
            // 
            this.pancake.AutoSize = true;
            this.pancake.Font = new System.Drawing.Font("supermarket", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pancake.Location = new System.Drawing.Point(16, 144);
            this.pancake.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pancake.Name = "pancake";
            this.pancake.Size = new System.Drawing.Size(533, 46);
            this.pancake.TabIndex = 2;
            this.pancake.Text = "Pan Cake .................................................  49 Baht";
            this.pancake.UseVisualStyleBackColor = true;
            // 
            // muffin
            // 
            this.muffin.AutoSize = true;
            this.muffin.Font = new System.Drawing.Font("supermarket", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.muffin.Location = new System.Drawing.Point(16, 91);
            this.muffin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.muffin.Name = "muffin";
            this.muffin.Size = new System.Drawing.Size(532, 46);
            this.muffin.TabIndex = 1;
            this.muffin.Text = "Muffin ......................................................  49 Baht";
            this.muffin.UseVisualStyleBackColor = true;
            // 
            // honey
            // 
            this.honey.AutoSize = true;
            this.honey.Font = new System.Drawing.Font("supermarket", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.honey.Location = new System.Drawing.Point(16, 37);
            this.honey.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.honey.Name = "honey";
            this.honey.Size = new System.Drawing.Size(536, 46);
            this.honey.TabIndex = 0;
            this.honey.Text = "Honey Toast..............................................  89 Baht";
            this.honey.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(676, 0);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(387, 553);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // btnorderdessert
            // 
            this.btnorderdessert.Font = new System.Drawing.Font("Elianto", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnorderdessert.ForeColor = System.Drawing.Color.Red;
            this.btnorderdessert.Location = new System.Drawing.Point(225, 433);
            this.btnorderdessert.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnorderdessert.Name = "btnorderdessert";
            this.btnorderdessert.Size = new System.Drawing.Size(204, 43);
            this.btnorderdessert.TabIndex = 14;
            this.btnorderdessert.Text = "Order Here";
            this.btnorderdessert.UseVisualStyleBackColor = true;
            this.btnorderdessert.Click += new System.EventHandler(this.btnorderdessert_Click);
            // 
            // FormDessert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnorderdessert);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormDessert";
            this.Text = "Dessert";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cupnum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wafnum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pannum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mufnum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.honnum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown cupnum;
        private System.Windows.Forms.NumericUpDown wafnum;
        private System.Windows.Forms.NumericUpDown pannum;
        private System.Windows.Forms.NumericUpDown mufnum;
        private System.Windows.Forms.NumericUpDown honnum;
        private System.Windows.Forms.CheckBox cupcake;
        private System.Windows.Forms.CheckBox waffle;
        private System.Windows.Forms.CheckBox pancake;
        private System.Windows.Forms.CheckBox muffin;
        private System.Windows.Forms.CheckBox honey;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnorderdessert;
    }
}