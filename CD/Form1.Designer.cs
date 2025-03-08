namespace CD
{
    partial class CD_Delta
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
            this.CdInFolderBtn = new System.Windows.Forms.Button();
            this.displayPathBtn = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.StatsCheckBox = new System.Windows.Forms.CheckBox();
            this.blockSizeLb = new System.Windows.Forms.Label();
            this.BlockSizeTxtBox = new System.Windows.Forms.TextBox();
            this.Reading = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ProgressBarC = new System.Windows.Forms.ProgressBar();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.ExecuteBtn = new System.Windows.Forms.Button();
            this.ErrorLb = new System.Windows.Forms.Label();
            this.InfoLb = new System.Windows.Forms.Label();
            this.PersentLb = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CdInFolderBtn
            // 
            this.CdInFolderBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CdInFolderBtn.Location = new System.Drawing.Point(17, 60);
            this.CdInFolderBtn.Name = "CdInFolderBtn";
            this.CdInFolderBtn.Size = new System.Drawing.Size(174, 52);
            this.CdInFolderBtn.TabIndex = 0;
            this.CdInFolderBtn.Text = "CD in folder";
            this.CdInFolderBtn.UseVisualStyleBackColor = true;
            this.CdInFolderBtn.Click += new System.EventHandler(this.CdInFolderBtn_Click);
            // 
            // displayPathBtn
            // 
            this.displayPathBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.displayPathBtn.Location = new System.Drawing.Point(221, 60);
            this.displayPathBtn.Name = "displayPathBtn";
            this.displayPathBtn.Size = new System.Drawing.Size(575, 52);
            this.displayPathBtn.TabIndex = 1;
            this.displayPathBtn.Text = "Display path to selected folder";
            this.displayPathBtn.UseVisualStyleBackColor = true;
            this.displayPathBtn.Click += new System.EventHandler(this.DisplayPathBtn_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox1.Location = new System.Drawing.Point(17, 142);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(268, 33);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "Without folder CD-out";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // StatsCheckBox
            // 
            this.StatsCheckBox.AutoSize = true;
            this.StatsCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StatsCheckBox.Location = new System.Drawing.Point(618, 142);
            this.StatsCheckBox.Name = "StatsCheckBox";
            this.StatsCheckBox.Size = new System.Drawing.Size(92, 33);
            this.StatsCheckBox.TabIndex = 3;
            this.StatsCheckBox.Text = "Stats";
            this.StatsCheckBox.UseVisualStyleBackColor = true;
            // 
            // blockSizeLb
            // 
            this.blockSizeLb.AutoSize = true;
            this.blockSizeLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.blockSizeLb.Location = new System.Drawing.Point(12, 9);
            this.blockSizeLb.Name = "blockSizeLb";
            this.blockSizeLb.Size = new System.Drawing.Size(126, 29);
            this.blockSizeLb.TabIndex = 4;
            this.blockSizeLb.Text = "Block Size";
            // 
            // BlockSizeTxtBox
            // 
            this.BlockSizeTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BlockSizeTxtBox.Location = new System.Drawing.Point(221, 9);
            this.BlockSizeTxtBox.Name = "BlockSizeTxtBox";
            this.BlockSizeTxtBox.Size = new System.Drawing.Size(156, 35);
            this.BlockSizeTxtBox.TabIndex = 6;
            // 
            // Reading
            // 
            this.Reading.AutoSize = true;
            this.Reading.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Reading.Location = new System.Drawing.Point(12, 400);
            this.Reading.Name = "Reading";
            this.Reading.Size = new System.Drawing.Size(200, 29);
            this.Reading.TabIndex = 7;
            this.Reading.Text = "00.00.00 Reading";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(319, 400);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(211, 29);
            this.label4.TabIndex = 8;
            this.label4.Text = "00.00.00 Alghoritm";
            // 
            // ProgressBarC
            // 
            this.ProgressBarC.Location = new System.Drawing.Point(17, 448);
            this.ProgressBarC.Name = "ProgressBarC";
            this.ProgressBarC.Size = new System.Drawing.Size(779, 41);
            this.ProgressBarC.TabIndex = 9;
            // 
            // CancelBtn
            // 
            this.CancelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CancelBtn.Location = new System.Drawing.Point(17, 523);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(174, 52);
            this.CancelBtn.TabIndex = 10;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // ExecuteBtn
            // 
            this.ExecuteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExecuteBtn.Location = new System.Drawing.Point(614, 523);
            this.ExecuteBtn.Name = "ExecuteBtn";
            this.ExecuteBtn.Size = new System.Drawing.Size(182, 52);
            this.ExecuteBtn.TabIndex = 11;
            this.ExecuteBtn.Text = "Execute";
            this.ExecuteBtn.UseVisualStyleBackColor = true;
            this.ExecuteBtn.Click += new System.EventHandler(this.ExecuteBtn_Click);
            // 
            // ErrorLb
            // 
            this.ErrorLb.AutoSize = true;
            this.ErrorLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ErrorLb.ForeColor = System.Drawing.Color.Red;
            this.ErrorLb.Location = new System.Drawing.Point(440, 15);
            this.ErrorLb.Name = "ErrorLb";
            this.ErrorLb.Size = new System.Drawing.Size(0, 25);
            this.ErrorLb.TabIndex = 12;
            // 
            // InfoLb
            // 
            this.InfoLb.AutoSize = true;
            this.InfoLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InfoLb.Location = new System.Drawing.Point(13, 228);
            this.InfoLb.Name = "InfoLb";
            this.InfoLb.Size = new System.Drawing.Size(66, 25);
            this.InfoLb.TabIndex = 13;
            this.InfoLb.Text = "InfoLb";
            // 
            // PersentLb
            // 
            this.PersentLb.AutoSize = true;
            this.PersentLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PersentLb.Location = new System.Drawing.Point(724, 400);
            this.PersentLb.Name = "PersentLb";
            this.PersentLb.Size = new System.Drawing.Size(48, 29);
            this.PersentLb.TabIndex = 14;
            this.PersentLb.Text = "0%";
            // 
            // CD_Delta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 587);
            this.Controls.Add(this.PersentLb);
            this.Controls.Add(this.InfoLb);
            this.Controls.Add(this.ErrorLb);
            this.Controls.Add(this.ExecuteBtn);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.ProgressBarC);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Reading);
            this.Controls.Add(this.BlockSizeTxtBox);
            this.Controls.Add(this.blockSizeLb);
            this.Controls.Add(this.StatsCheckBox);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.displayPathBtn);
            this.Controls.Add(this.CdInFolderBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CD_Delta";
            this.Text = "CD-Delta";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CdInFolderBtn;
        private System.Windows.Forms.Button displayPathBtn;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox StatsCheckBox;
        private System.Windows.Forms.Label blockSizeLb;
        private System.Windows.Forms.TextBox BlockSizeTxtBox;
        private System.Windows.Forms.Label Reading;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ProgressBar ProgressBarC;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Button ExecuteBtn;
        private System.Windows.Forms.Label ErrorLb;
        private System.Windows.Forms.Label InfoLb;
        private System.Windows.Forms.Label PersentLb;
    }
}

