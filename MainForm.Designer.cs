namespace ConventionOfElements
{
	partial class MainForm
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.buttonStart = new System.Windows.Forms.Button();
			this.timerPerSecond = new System.Windows.Forms.Timer(this.components);
			this.labelInfoText = new System.Windows.Forms.Label();
			this.buttonExit = new System.Windows.Forms.Button();
			this.labelCounter = new System.Windows.Forms.Label();
			this.comboBoxBuffs = new System.Windows.Forms.ComboBox();
			this.labelBuffText = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// buttonStart
			// 
			this.buttonStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.buttonStart.Location = new System.Drawing.Point(12, 229);
			this.buttonStart.Name = "buttonStart";
			this.buttonStart.Size = new System.Drawing.Size(75, 23);
			this.buttonStart.TabIndex = 0;
			this.buttonStart.Text = "Start";
			this.buttonStart.UseVisualStyleBackColor = true;
			this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
			// 
			// timerPerSecond
			// 
			this.timerPerSecond.Interval = 1000;
			this.timerPerSecond.Tick += new System.EventHandler(this.timerPerSecond_Tick);
			// 
			// labelInfoText
			// 
			this.labelInfoText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.labelInfoText.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelInfoText.ForeColor = System.Drawing.Color.White;
			this.labelInfoText.Location = new System.Drawing.Point(12, 9);
			this.labelInfoText.Name = "labelInfoText";
			this.labelInfoText.Size = new System.Drawing.Size(310, 105);
			this.labelInfoText.TabIndex = 1;
			this.labelInfoText.Text = "label1";
			this.labelInfoText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.labelInfoText.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MovingMouseDown);
			// 
			// buttonExit
			// 
			this.buttonExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonExit.Location = new System.Drawing.Point(247, 229);
			this.buttonExit.Name = "buttonExit";
			this.buttonExit.Size = new System.Drawing.Size(75, 23);
			this.buttonExit.TabIndex = 2;
			this.buttonExit.Text = "Exit";
			this.buttonExit.UseVisualStyleBackColor = true;
			this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
			// 
			// labelCounter
			// 
			this.labelCounter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.labelCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelCounter.ForeColor = System.Drawing.Color.White;
			this.labelCounter.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.labelCounter.Location = new System.Drawing.Point(12, 177);
			this.labelCounter.Name = "labelCounter";
			this.labelCounter.Size = new System.Drawing.Size(310, 35);
			this.labelCounter.TabIndex = 3;
			this.labelCounter.Text = "4";
			this.labelCounter.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.labelCounter.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MovingMouseDown);
			// 
			// comboBoxBuffs
			// 
			this.comboBoxBuffs.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.comboBoxBuffs.FormattingEnabled = true;
			this.comboBoxBuffs.Items.AddRange(new object[] {
            "Lightning",
            "Physical",
            "Cold",
            "Fire",
            "Holy"});
			this.comboBoxBuffs.Location = new System.Drawing.Point(115, 230);
			this.comboBoxBuffs.Name = "comboBoxBuffs";
			this.comboBoxBuffs.Size = new System.Drawing.Size(105, 21);
			this.comboBoxBuffs.TabIndex = 4;
			this.comboBoxBuffs.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
			// 
			// labelBuffText
			// 
			this.labelBuffText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.labelBuffText.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelBuffText.ForeColor = System.Drawing.Color.White;
			this.labelBuffText.Location = new System.Drawing.Point(12, 114);
			this.labelBuffText.Name = "labelBuffText";
			this.labelBuffText.Size = new System.Drawing.Size(310, 63);
			this.labelBuffText.TabIndex = 5;
			this.labelBuffText.Text = "label3";
			this.labelBuffText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.labelBuffText.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MovingMouseDown);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Black;
			this.ClientSize = new System.Drawing.Size(334, 269);
			this.Controls.Add(this.labelBuffText);
			this.Controls.Add(this.comboBoxBuffs);
			this.Controls.Add(this.labelCounter);
			this.Controls.Add(this.buttonExit);
			this.Controls.Add(this.labelInfoText);
			this.Controls.Add(this.buttonStart);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Convention Of Elements - Helper";
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MovingMouseDown);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button buttonStart;
		private System.Windows.Forms.Timer timerPerSecond;
		private System.Windows.Forms.Label labelInfoText;
		private System.Windows.Forms.Button buttonExit;
		private System.Windows.Forms.Label labelCounter;
		private System.Windows.Forms.ComboBox comboBoxBuffs;
		private System.Windows.Forms.Label labelBuffText;
	}
}

