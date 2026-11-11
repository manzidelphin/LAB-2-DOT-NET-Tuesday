namespace mashroom
{
    partial class MushroomIdentificationForm
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
            this.lblQuestionCount = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnRestart = new System.Windows.Forms.Button();
            this.btnNo = new System.Windows.Forms.Button();
            this.btnYes = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.lblInstructions = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.lblQuestionCount);
            this.pnlMain.Controls.Add(this.btnBack);
            this.pnlMain.Controls.Add(this.btnRestart);
            this.pnlMain.Controls.Add(this.btnNo);
            this.pnlMain.Controls.Add(this.btnYes);
            this.pnlMain.Controls.Add(this.lblResult);
            this.pnlMain.Controls.Add(this.lblQuestion);
            this.pnlMain.Controls.Add(this.lblInstructions);
            this.pnlMain.Controls.Add(this.lblTitle);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Padding = new System.Windows.Forms.Padding(32, 30, 32, 30);
            this.pnlMain.Size = new System.Drawing.Size(778, 529);
            this.pnlMain.TabIndex = 0;
            // 
            // lblQuestionCount
            // 
            this.lblQuestionCount.Location = new System.Drawing.Point(32, 342);
            this.lblQuestionCount.Name = "lblQuestionCount";
            this.lblQuestionCount.Size = new System.Drawing.Size(622, 28);
            this.lblQuestionCount.TabIndex = 8;
            this.lblQuestionCount.Text = "Questions asked: 0 of 3";
            this.lblQuestionCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(453, 431);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(201, 41);
            this.btnBack.TabIndex = 7;
            this.btnBack.Text = "Back to Main Menu";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnRestart
            // 
            this.btnRestart.Location = new System.Drawing.Point(32, 431);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(201, 41);
            this.btnRestart.TabIndex = 6;
            this.btnRestart.Text = "Restart Identification";
            this.btnRestart.UseVisualStyleBackColor = true;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // btnNo
            // 
            this.btnNo.Location = new System.Drawing.Point(357, 289);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(133, 49);
            this.btnNo.TabIndex = 5;
            this.btnNo.Text = "No";
            this.btnNo.UseVisualStyleBackColor = true;
            this.btnNo.Click += new System.EventHandler(this.btnNo_Click);
            // 
            // btnYes
            // 
            this.btnYes.Location = new System.Drawing.Point(197, 289);
            this.btnYes.Name = "btnYes";
            this.btnYes.Size = new System.Drawing.Size(133, 49);
            this.btnYes.TabIndex = 4;
            this.btnYes.Text = "Yes";
            this.btnYes.UseVisualStyleBackColor = true;
            this.btnYes.Click += new System.EventHandler(this.btnYes_Click);
            // 
            // lblResult
            // 
            this.lblResult.Location = new System.Drawing.Point(32, 375);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(622, 45);
            this.lblResult.TabIndex = 3;
            this.lblResult.Text = "Answer the questions to identify your mushroom.";
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblQuestion
            // 
            this.lblQuestion.Location = new System.Drawing.Point(53, 207);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(581, 62);
            this.lblQuestion.TabIndex = 2;
            this.lblQuestion.Text = "Does your mushroom have gills?";
            this.lblQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblInstructions
            // 
            this.lblInstructions.Location = new System.Drawing.Point(55, 95);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(576, 68);
            this.lblInstructions.TabIndex = 1;
            this.lblInstructions.Text = "Think of one of the six mushrooms. Answer each question using the Yes or No butto" +
    "ns. The system will ask no more than three questions.";
            this.lblInstructions.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitle
            // 
            this.lblTitle.Location = new System.Drawing.Point(29, 30);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(622, 51);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Mushroom Identification System";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MushroomIdentificationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 529);
            this.Controls.Add(this.pnlMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MushroomIdentificationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Mushroom Identification System";
            this.pnlMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Label lblQuestionCount;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.Button btnNo;
        private System.Windows.Forms.Button btnYes;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.Label lblInstructions;
        private System.Windows.Forms.Label lblTitle;
    }
}
