namespace WindowsFormsApp1
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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnDe = new System.Windows.Forms.Button();
            this.btnCheck = new System.Windows.Forms.Button();
            this.btnTea = new System.Windows.Forms.Button();
            this.btnCoffee = new System.Windows.Forms.Button();
            this.btnFood = new System.Windows.Forms.Button();
            this.btnMember = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.pictureLogo = new System.Windows.Forms.PictureBox();
            this.labelname = new System.Windows.Forms.Label();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.bntMinimize = new System.Windows.Forms.Button();
            this.btnMaximize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnCloseChildForm = new System.Windows.Forms.Button();
            this.lbTitle = new System.Windows.Forms.Label();
            this.panelDesktopPanel = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).BeginInit();
            this.panelTitleBar.SuspendLayout();
            this.panelDesktopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(70)))));
            this.panelMenu.Controls.Add(this.btnDe);
            this.panelMenu.Controls.Add(this.btnCheck);
            this.panelMenu.Controls.Add(this.btnTea);
            this.panelMenu.Controls.Add(this.btnCoffee);
            this.panelMenu.Controls.Add(this.btnFood);
            this.panelMenu.Controls.Add(this.btnMember);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(4);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(267, 662);
            this.panelMenu.TabIndex = 0;
            // 
            // btnDe
            // 
            this.btnDe.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDe.FlatAppearance.BorderSize = 0;
            this.btnDe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDe.Font = new System.Drawing.Font("Elianto", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDe.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnDe.Image = global::WindowsFormsApp1.Properties.Resources.muffin;
            this.btnDe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDe.Location = new System.Drawing.Point(0, 394);
            this.btnDe.Margin = new System.Windows.Forms.Padding(4);
            this.btnDe.Name = "btnDe";
            this.btnDe.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.btnDe.Size = new System.Drawing.Size(267, 74);
            this.btnDe.TabIndex = 6;
            this.btnDe.Text = "Dessert";
            this.btnDe.UseVisualStyleBackColor = true;
            this.btnDe.Click += new System.EventHandler(this.btnDe_Click);
            // 
            // btnCheck
            // 
            this.btnCheck.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnCheck.FlatAppearance.BorderSize = 0;
            this.btnCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheck.Font = new System.Drawing.Font("Elianto", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheck.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnCheck.Image = ((System.Drawing.Image)(resources.GetObject("btnCheck.Image")));
            this.btnCheck.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCheck.Location = new System.Drawing.Point(0, 588);
            this.btnCheck.Margin = new System.Windows.Forms.Padding(4);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.btnCheck.Size = new System.Drawing.Size(267, 74);
            this.btnCheck.TabIndex = 5;
            this.btnCheck.Text = "Check Bill";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // btnTea
            // 
            this.btnTea.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTea.FlatAppearance.BorderSize = 0;
            this.btnTea.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTea.Font = new System.Drawing.Font("Elianto", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTea.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnTea.Image = ((System.Drawing.Image)(resources.GetObject("btnTea.Image")));
            this.btnTea.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTea.Location = new System.Drawing.Point(0, 320);
            this.btnTea.Margin = new System.Windows.Forms.Padding(4);
            this.btnTea.Name = "btnTea";
            this.btnTea.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.btnTea.Size = new System.Drawing.Size(267, 74);
            this.btnTea.TabIndex = 4;
            this.btnTea.Text = "Tea";
            this.btnTea.UseVisualStyleBackColor = true;
            this.btnTea.Click += new System.EventHandler(this.btnTea_Click);
            // 
            // btnCoffee
            // 
            this.btnCoffee.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCoffee.FlatAppearance.BorderSize = 0;
            this.btnCoffee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCoffee.Font = new System.Drawing.Font("Elianto", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCoffee.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnCoffee.Image = ((System.Drawing.Image)(resources.GetObject("btnCoffee.Image")));
            this.btnCoffee.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCoffee.Location = new System.Drawing.Point(0, 246);
            this.btnCoffee.Margin = new System.Windows.Forms.Padding(4);
            this.btnCoffee.Name = "btnCoffee";
            this.btnCoffee.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.btnCoffee.Size = new System.Drawing.Size(267, 74);
            this.btnCoffee.TabIndex = 3;
            this.btnCoffee.Text = "Coffee";
            this.btnCoffee.UseVisualStyleBackColor = true;
            this.btnCoffee.Click += new System.EventHandler(this.btnCoffee_Click);
            // 
            // btnFood
            // 
            this.btnFood.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFood.FlatAppearance.BorderSize = 0;
            this.btnFood.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFood.Font = new System.Drawing.Font("Elianto", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFood.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnFood.Image = ((System.Drawing.Image)(resources.GetObject("btnFood.Image")));
            this.btnFood.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFood.Location = new System.Drawing.Point(0, 172);
            this.btnFood.Margin = new System.Windows.Forms.Padding(4);
            this.btnFood.Name = "btnFood";
            this.btnFood.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.btnFood.Size = new System.Drawing.Size(267, 74);
            this.btnFood.TabIndex = 2;
            this.btnFood.Text = "Food";
            this.btnFood.UseVisualStyleBackColor = true;
            this.btnFood.Click += new System.EventHandler(this.btnFood_Click);
            // 
            // btnMember
            // 
            this.btnMember.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMember.FlatAppearance.BorderSize = 0;
            this.btnMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMember.Font = new System.Drawing.Font("Elianto", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMember.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnMember.Image = ((System.Drawing.Image)(resources.GetObject("btnMember.Image")));
            this.btnMember.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMember.Location = new System.Drawing.Point(0, 98);
            this.btnMember.Margin = new System.Windows.Forms.Padding(4);
            this.btnMember.Name = "btnMember";
            this.btnMember.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.btnMember.Size = new System.Drawing.Size(267, 74);
            this.btnMember.TabIndex = 1;
            this.btnMember.Text = "Member";
            this.btnMember.UseVisualStyleBackColor = true;
            this.btnMember.Click += new System.EventHandler(this.btnMember_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panelLogo.Controls.Add(this.pictureLogo);
            this.panelLogo.Controls.Add(this.labelname);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Margin = new System.Windows.Forms.Padding(4);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.panelLogo.Size = new System.Drawing.Size(267, 98);
            this.panelLogo.TabIndex = 0;
            // 
            // pictureLogo
            // 
            this.pictureLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureLogo.Image")));
            this.pictureLogo.Location = new System.Drawing.Point(-3, -4);
            this.pictureLogo.Margin = new System.Windows.Forms.Padding(4);
            this.pictureLogo.Name = "pictureLogo";
            this.pictureLogo.Size = new System.Drawing.Size(107, 81);
            this.pictureLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureLogo.TabIndex = 2;
            this.pictureLogo.TabStop = false;
            // 
            // labelname
            // 
            this.labelname.AutoSize = true;
            this.labelname.Font = new System.Drawing.Font("Elianto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelname.ForeColor = System.Drawing.Color.Aqua;
            this.labelname.Location = new System.Drawing.Point(103, 41);
            this.labelname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelname.Name = "labelname";
            this.labelname.Size = new System.Drawing.Size(146, 35);
            this.labelname.TabIndex = 1;
            this.labelname.Text = "JB CAFE";
            this.labelname.Click += new System.EventHandler(this.label1_Click);
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.panelTitleBar.Controls.Add(this.bntMinimize);
            this.panelTitleBar.Controls.Add(this.btnMaximize);
            this.panelTitleBar.Controls.Add(this.btnClose);
            this.panelTitleBar.Controls.Add(this.btnCloseChildForm);
            this.panelTitleBar.Controls.Add(this.lbTitle);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(267, 0);
            this.panelTitleBar.Margin = new System.Windows.Forms.Padding(4);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(1036, 98);
            this.panelTitleBar.TabIndex = 1;
            // 
            // bntMinimize
            // 
            this.bntMinimize.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bntMinimize.FlatAppearance.BorderSize = 0;
            this.bntMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntMinimize.Image = global::WindowsFormsApp1.Properties.Resources.mm;
            this.bntMinimize.Location = new System.Drawing.Point(933, 4);
            this.bntMinimize.Margin = new System.Windows.Forms.Padding(4);
            this.bntMinimize.Name = "bntMinimize";
            this.bntMinimize.Size = new System.Drawing.Size(37, 28);
            this.bntMinimize.TabIndex = 4;
            this.bntMinimize.UseVisualStyleBackColor = true;
            this.bntMinimize.Click += new System.EventHandler(this.bntMinimize_Click);
            // 
            // btnMaximize
            // 
            this.btnMaximize.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnMaximize.FlatAppearance.BorderSize = 0;
            this.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximize.Image = global::WindowsFormsApp1.Properties.Resources.expand;
            this.btnMaximize.Location = new System.Drawing.Point(964, 4);
            this.btnMaximize.Margin = new System.Windows.Forms.Padding(4);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(37, 28);
            this.btnMaximize.TabIndex = 3;
            this.btnMaximize.UseVisualStyleBackColor = true;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = global::WindowsFormsApp1.Properties.Resources.exit;
            this.btnClose.Location = new System.Drawing.Point(995, 4);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(37, 28);
            this.btnClose.TabIndex = 2;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnCloseChildForm
            // 
            this.btnCloseChildForm.Cursor = System.Windows.Forms.Cursors.Cross;
            this.btnCloseChildForm.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnCloseChildForm.FlatAppearance.BorderSize = 0;
            this.btnCloseChildForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseChildForm.Image = global::WindowsFormsApp1.Properties.Resources._66;
            this.btnCloseChildForm.Location = new System.Drawing.Point(0, 0);
            this.btnCloseChildForm.Margin = new System.Windows.Forms.Padding(4);
            this.btnCloseChildForm.Name = "btnCloseChildForm";
            this.btnCloseChildForm.Size = new System.Drawing.Size(83, 98);
            this.btnCloseChildForm.TabIndex = 1;
            this.btnCloseChildForm.UseVisualStyleBackColor = true;
            this.btnCloseChildForm.Click += new System.EventHandler(this.btnCloseChildForm_Click);
            // 
            // lbTitle
            // 
            this.lbTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Elianto", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.Color.White;
            this.lbTitle.Location = new System.Drawing.Point(473, 34);
            this.lbTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(98, 35);
            this.lbTitle.TabIndex = 0;
            this.lbTitle.Text = "HOME";
            // 
            // panelDesktopPanel
            // 
            this.panelDesktopPanel.Controls.Add(this.pictureBox3);
            this.panelDesktopPanel.Controls.Add(this.pictureBox2);
            this.panelDesktopPanel.Controls.Add(this.pictureBox1);
            this.panelDesktopPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktopPanel.Location = new System.Drawing.Point(267, 98);
            this.panelDesktopPanel.Margin = new System.Windows.Forms.Padding(4);
            this.panelDesktopPanel.Name = "panelDesktopPanel";
            this.panelDesktopPanel.Size = new System.Drawing.Size(1036, 564);
            this.panelDesktopPanel.TabIndex = 2;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(12, 325);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(601, 230);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(621, -1);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(415, 564);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(624, 322);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1303, 662);
            this.Controls.Add(this.panelDesktopPanel);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1261, 605);
            this.Name = "Form1";
            this.Text = "CafeSystem";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).EndInit();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            this.panelDesktopPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Button btnTea;
        private System.Windows.Forms.Button btnCoffee;
        private System.Windows.Forms.Button btnFood;
        private System.Windows.Forms.Button btnMember;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Label labelname;
        private System.Windows.Forms.PictureBox pictureLogo;
        private System.Windows.Forms.Panel panelDesktopPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btnCloseChildForm;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button bntMinimize;
        private System.Windows.Forms.Button btnMaximize;
        private System.Windows.Forms.Button btnDe;
    }
}

