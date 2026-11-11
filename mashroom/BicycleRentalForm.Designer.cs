namespace mashroom
{
    partial class BicycleRentalForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.pnlMain = new System.Windows.Forms.Panel();
            this.grpRates = new System.Windows.Forms.GroupBox();
            this.lblRateLate = new System.Windows.Forms.Label();
            this.lblRateEvening = new System.Windows.Forms.Label();
            this.lblRateAfternoon = new System.Windows.Forms.Label();
            this.lblRateMorning = new System.Windows.Forms.Label();
            this.lblRateEarly = new System.Windows.Forms.Label();
            this.lblTotalResult = new System.Windows.Forms.Label();
            this.lblDurationResult = new System.Windows.Forms.Label();
            this.lblTotalCaption = new System.Windows.Forms.Label();
            this.lblDurationCaption = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.txtEndHour = new System.Windows.Forms.TextBox();
            this.txtStartHour = new System.Windows.Forms.TextBox();
            this.lblEndHour = new System.Windows.Forms.Label();
            this.lblStartHour = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlMain.SuspendLayout();
            this.grpRates.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.grpRates);
            this.pnlMain.Controls.Add(this.lblTotalResult);
            this.pnlMain.Controls.Add(this.lblDurationResult);
            this.pnlMain.Controls.Add(this.lblTotalCaption);
            this.pnlMain.Controls.Add(this.lblDurationCaption);
            this.pnlMain.Controls.Add(this.btnBack);
            this.pnlMain.Controls.Add(this.btnClear);
            this.pnlMain.Controls.Add(this.btnCalculate);
            this.pnlMain.Controls.Add(this.txtEndHour);
            this.pnlMain.Controls.Add(this.txtStartHour);
            this.pnlMain.Controls.Add(this.lblEndHour);
            this.pnlMain.Controls.Add(this.lblStartHour);
            this.pnlMain.Controls.Add(this.lblTitle);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Padding = new System.Windows.Forms.Padding(24);
            // 
            // grpRates
            // 
            this.grpRates.Controls.Add(this.lblRateLate);
            this.grpRates.Controls.Add(this.lblRateEvening);
            this.grpRates.Controls.Add(this.lblRateAfternoon);
            this.grpRates.Controls.Add(this.lblRateMorning);
            this.grpRates.Controls.Add(this.lblRateEarly);
            this.grpRates.Location = new System.Drawing.Point(334, 99);
            this.grpRates.Name = "grpRates";
            this.grpRates.Size = new System.Drawing.Size(256, 190);
            this.grpRates.TabIndex = 12;
            this.grpRates.TabStop = false;
            this.grpRates.Text = "Hourly Rental Rates";
            // 
            // lblRateLate
            // 
            this.lblRateLate.Location = new System.Drawing.Point(16, 151);
            this.lblRateLate.Name = "lblRateLate";
            this.lblRateLate.Size = new System.Drawing.Size(224, 24);
            this.lblRateLate.TabIndex = 4;
            this.lblRateLate.Text = "21:00–24:00   500 RWF / hour";
            this.lblRateLate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblRateEvening
            // 
            this.lblRateEvening.Location = new System.Drawing.Point(16, 122);
            this.lblRateEvening.Name = "lblRateEvening";
            this.lblRateEvening.Size = new System.Drawing.Size(224, 24);
            this.lblRateEvening.TabIndex = 3;
            this.lblRateEvening.Text = "19:00–21:00   1,000 RWF / hour";
            this.lblRateEvening.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblRateAfternoon
            // 
            this.lblRateAfternoon.Location = new System.Drawing.Point(16, 93);
            this.lblRateAfternoon.Name = "lblRateAfternoon";
            this.lblRateAfternoon.Size = new System.Drawing.Size(224, 24);
            this.lblRateAfternoon.TabIndex = 2;
            this.lblRateAfternoon.Text = "14:00–19:00   1,500 RWF / hour";
            this.lblRateAfternoon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblRateMorning
            // 
            this.lblRateMorning.Location = new System.Drawing.Point(16, 64);
            this.lblRateMorning.Name = "lblRateMorning";
            this.lblRateMorning.Size = new System.Drawing.Size(224, 24);
            this.lblRateMorning.TabIndex = 1;
            this.lblRateMorning.Text = "07:00–14:00   1,000 RWF / hour";
            this.lblRateMorning.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblRateEarly
            // 
            this.lblRateEarly.Location = new System.Drawing.Point(16, 35);
            this.lblRateEarly.Name = "lblRateEarly";
            this.lblRateEarly.Size = new System.Drawing.Size(224, 24);
            this.lblRateEarly.TabIndex = 0;
            this.lblRateEarly.Text = "00:00–07:00   500 RWF / hour";
            this.lblRateEarly.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTotalResult
            // 
            this.lblTotalResult.Location = new System.Drawing.Point(24, 370);
            this.lblTotalResult.Name = "lblTotalResult";
            this.lblTotalResult.Size = new System.Drawing.Size(566, 40);
            this.lblTotalResult.TabIndex = 11;
            this.lblTotalResult.Text = "—";
            this.lblTotalResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDurationResult
            // 
            this.lblDurationResult.Location = new System.Drawing.Point(24, 316);
            this.lblDurationResult.Name = "lblDurationResult";
            this.lblDurationResult.Size = new System.Drawing.Size(566, 30);
            this.lblDurationResult.TabIndex = 10;
            this.lblDurationResult.Text = "—";
            this.lblDurationResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalCaption
            // 
            this.lblTotalCaption.Location = new System.Drawing.Point(24, 346);
            this.lblTotalCaption.Name = "lblTotalCaption";
            this.lblTotalCaption.Size = new System.Drawing.Size(566, 24);
            this.lblTotalCaption.TabIndex = 9;
            this.lblTotalCaption.Text = "Total Rental Cost";
            this.lblTotalCaption.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDurationCaption
            // 
            this.lblDurationCaption.Location = new System.Drawing.Point(24, 290);
            this.lblDurationCaption.Name = "lblDurationCaption";
            this.lblDurationCaption.Size = new System.Drawing.Size(566, 24);
            this.lblDurationCaption.TabIndex = 8;
            this.lblDurationCaption.Text = "Rental Duration";
            this.lblDurationCaption.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(414, 432);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(176, 38);
            this.btnBack.TabIndex = 7;
            this.btnBack.Text = "Back to Main Menu";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(216, 226);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(96, 38);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(24, 226);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(176, 38);
            this.btnCalculate.TabIndex = 5;
            this.btnCalculate.Text = "Calculate Rental";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // txtEndHour
            // 
            this.txtEndHour.Location = new System.Drawing.Point(24, 174);
            this.txtEndHour.Name = "txtEndHour";
            this.txtEndHour.Size = new System.Drawing.Size(288, 27);
            this.txtEndHour.TabIndex = 4;
            // 
            // txtStartHour
            // 
            this.txtStartHour.Location = new System.Drawing.Point(24, 112);
            this.txtStartHour.Name = "txtStartHour";
            this.txtStartHour.Size = new System.Drawing.Size(288, 27);
            this.txtStartHour.TabIndex = 2;
            // 
            // lblEndHour
            // 
            this.lblEndHour.Location = new System.Drawing.Point(24, 146);
            this.lblEndHour.Name = "lblEndHour";
            this.lblEndHour.Size = new System.Drawing.Size(288, 24);
            this.lblEndHour.TabIndex = 3;
            this.lblEndHour.Text = "Ending Hour (1–24)";
            // 
            // lblStartHour
            // 
            this.lblStartHour.Location = new System.Drawing.Point(24, 84);
            this.lblStartHour.Name = "lblStartHour";
            this.lblStartHour.Size = new System.Drawing.Size(288, 24);
            this.lblStartHour.TabIndex = 1;
            this.lblStartHour.Text = "Starting Hour (0–23)";
            // 
            // lblTitle
            // 
            this.lblTitle.Location = new System.Drawing.Point(24, 24);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(566, 42);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Bicycle Rental Calculator";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BicycleRentalForm
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 494);
            this.Controls.Add(this.pnlMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "BicycleRentalForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Bicycle Rental System";
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.grpRates.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.GroupBox grpRates;
        private System.Windows.Forms.Label lblRateLate;
        private System.Windows.Forms.Label lblRateEvening;
        private System.Windows.Forms.Label lblRateAfternoon;
        private System.Windows.Forms.Label lblRateMorning;
        private System.Windows.Forms.Label lblRateEarly;
        private System.Windows.Forms.Label lblTotalResult;
        private System.Windows.Forms.Label lblDurationResult;
        private System.Windows.Forms.Label lblTotalCaption;
        private System.Windows.Forms.Label lblDurationCaption;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox txtEndHour;
        private System.Windows.Forms.TextBox txtStartHour;
        private System.Windows.Forms.Label lblEndHour;
        private System.Windows.Forms.Label lblStartHour;
        private System.Windows.Forms.Label lblTitle;
    }
}
