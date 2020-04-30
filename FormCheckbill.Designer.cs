namespace WindowsFormsApp1.Forms
{
    partial class FormCheckbill
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCheckbill));
            this.checkbillb = new System.Windows.Forms.Button();
            this.ordertxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.orderbutton = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.clearbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // checkbillb
            // 
            this.checkbillb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkbillb.Font = new System.Drawing.Font("Elianto", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkbillb.ForeColor = System.Drawing.Color.Red;
            this.checkbillb.Location = new System.Drawing.Point(46, 288);
            this.checkbillb.Name = "checkbillb";
            this.checkbillb.Size = new System.Drawing.Size(226, 47);
            this.checkbillb.TabIndex = 0;
            this.checkbillb.Text = "Check bill";
            this.checkbillb.UseVisualStyleBackColor = true;
            this.checkbillb.Click += new System.EventHandler(this.checkbillb_Click);
            // 
            // ordertxt
            // 
            this.ordertxt.BackColor = System.Drawing.SystemColors.Window;
            this.ordertxt.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.ordertxt.Font = new System.Drawing.Font("Prompt", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ordertxt.Location = new System.Drawing.Point(380, 73);
            this.ordertxt.Multiline = true;
            this.ordertxt.Name = "ordertxt";
            this.ordertxt.Size = new System.Drawing.Size(267, 344);
            this.ordertxt.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Elianto", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(442, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Your Orders!";
            // 
            // orderbutton
            // 
            this.orderbutton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.orderbutton.Font = new System.Drawing.Font("Elianto", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderbutton.ForeColor = System.Drawing.Color.Green;
            this.orderbutton.Location = new System.Drawing.Point(46, 81);
            this.orderbutton.Name = "orderbutton";
            this.orderbutton.Size = new System.Drawing.Size(226, 47);
            this.orderbutton.TabIndex = 4;
            this.orderbutton.Text = "Check Order";
            this.orderbutton.UseVisualStyleBackColor = true;
            this.orderbutton.Click += new System.EventHandler(this.orderbutton_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(380, 45);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(267, 402);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // clearbutton
            // 
            this.clearbutton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.clearbutton.Font = new System.Drawing.Font("Elianto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearbutton.ForeColor = System.Drawing.Color.Chocolate;
            this.clearbutton.Location = new System.Drawing.Point(54, 145);
            this.clearbutton.Name = "clearbutton";
            this.clearbutton.Size = new System.Drawing.Size(205, 47);
            this.clearbutton.TabIndex = 5;
            this.clearbutton.Text = "Clear";
            this.clearbutton.UseVisualStyleBackColor = true;
            this.clearbutton.Click += new System.EventHandler(this.clearbutton_Click);
            // 
            // FormCheckbill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.clearbutton);
            this.Controls.Add(this.orderbutton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ordertxt);
            this.Controls.Add(this.checkbillb);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FormCheckbill";
            this.Text = "Checkbill";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button checkbillb;
        private System.Windows.Forms.TextBox ordertxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button orderbutton;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button clearbutton;
    }
}