namespace mashroom
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
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.lblHeading = new System.Windows.Forms.Label();
            this.btnBicycleRental = new System.Windows.Forms.Button();
            this.btnMushroomIdentification = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.pnlMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.Controls.Add(this.lblSubtitle);
            this.pnlMenu.Controls.Add(this.lblHeading);
            this.pnlMenu.Controls.Add(this.btnExit);
            this.pnlMenu.Controls.Add(this.btnMushroomIdentification);
            this.pnlMenu.Controls.Add(this.btnBicycleRental);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMenu.Padding = new System.Windows.Forms.Padding(32);
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.Location = new System.Drawing.Point(32, 90);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(440, 30);
            this.lblSubtitle.TabIndex = 1;
            this.lblSubtitle.Text = "Windows Forms Application";
            this.lblSubtitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHeading
            // 
            this.lblHeading.Location = new System.Drawing.Point(32, 38);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(440, 48);
            this.lblHeading.TabIndex = 0;
            this.lblHeading.Text = "C# Programming Lab 1";
            this.lblHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnBicycleRental
            // 
            this.btnBicycleRental.Location = new System.Drawing.Point(92, 152);
            this.btnBicycleRental.Name = "btnBicycleRental";
            this.btnBicycleRental.Size = new System.Drawing.Size(320, 52);
            this.btnBicycleRental.TabIndex = 2;
            this.btnBicycleRental.Text = "Problem 1 — Bicycle Rental";
            this.btnBicycleRental.UseVisualStyleBackColor = true;
            this.btnBicycleRental.Click += new System.EventHandler(this.btnBicycleRental_Click);
            // 
            // btnMushroomIdentification
            // 
            this.btnMushroomIdentification.Location = new System.Drawing.Point(92, 220);
            this.btnMushroomIdentification.Name = "btnMushroomIdentification";
            this.btnMushroomIdentification.Size = new System.Drawing.Size(320, 52);
            this.btnMushroomIdentification.TabIndex = 3;
            this.btnMushroomIdentification.Text = "Problem 2 — Mushroom Identification";
            this.btnMushroomIdentification.UseVisualStyleBackColor = true;
            this.btnMushroomIdentification.Click += new System.EventHandler(this.btnMushroomIdentification_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(152, 294);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(200, 42);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit Application";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 388);
            this.Controls.Add(this.pnlMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "C# LAB 1 — MAIN MENU";
            this.pnlMenu.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.Button btnBicycleRental;
        private System.Windows.Forms.Button btnMushroomIdentification;
        private System.Windows.Forms.Button btnExit;
    }
}

