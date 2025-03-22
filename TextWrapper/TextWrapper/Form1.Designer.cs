namespace TextWrapper
{
	partial class WorkSpace_FRM
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WorkSpace_FRM));
			this.Header_PNL = new System.Windows.Forms.Panel();
			this.Header_LBL = new System.Windows.Forms.Label();
			this.Footer_PNL = new System.Windows.Forms.Panel();
			this.WebSite_IMG = new System.Windows.Forms.PictureBox();
			this.GitHub_IMG = new System.Windows.Forms.PictureBox();
			this.LinkedIn_IMG = new System.Windows.Forms.PictureBox();
			this.SelectPath_BTN = new System.Windows.Forms.Button();
			this.Path_TB = new System.Windows.Forms.TextBox();
			this.TextBox_RTB = new System.Windows.Forms.RichTextBox();
			this.Clear_BTN = new System.Windows.Forms.Button();
			this.Run_BTN = new System.Windows.Forms.Button();
			this.Header_PNL.SuspendLayout();
			this.Footer_PNL.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.WebSite_IMG)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.GitHub_IMG)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.LinkedIn_IMG)).BeginInit();
			this.SuspendLayout();
			// 
			// Header_PNL
			// 
			this.Header_PNL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.Header_PNL.BackColor = System.Drawing.SystemColors.ControlLight;
			this.Header_PNL.Controls.Add(this.Header_LBL);
			this.Header_PNL.Location = new System.Drawing.Point(9, 10);
			this.Header_PNL.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.Header_PNL.Name = "Header_PNL";
			this.Header_PNL.Size = new System.Drawing.Size(764, 40);
			this.Header_PNL.TabIndex = 0;
			// 
			// Header_LBL
			// 
			this.Header_LBL.AutoSize = true;
			this.Header_LBL.Location = new System.Drawing.Point(338, 11);
			this.Header_LBL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.Header_LBL.Name = "Header_LBL";
			this.Header_LBL.Size = new System.Drawing.Size(89, 16);
			this.Header_LBL.TabIndex = 0;
			this.Header_LBL.Text = "Text Wrapper!";
			// 
			// Footer_PNL
			// 
			this.Footer_PNL.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.Footer_PNL.Controls.Add(this.WebSite_IMG);
			this.Footer_PNL.Controls.Add(this.GitHub_IMG);
			this.Footer_PNL.Controls.Add(this.LinkedIn_IMG);
			this.Footer_PNL.Location = new System.Drawing.Point(9, 510);
			this.Footer_PNL.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.Footer_PNL.Name = "Footer_PNL";
			this.Footer_PNL.Size = new System.Drawing.Size(764, 40);
			this.Footer_PNL.TabIndex = 1;
			// 
			// WebSite_IMG
			// 
			this.WebSite_IMG.Cursor = System.Windows.Forms.Cursors.Hand;
			this.WebSite_IMG.Image = global::TextWrapper.Properties.Resources.website;
			this.WebSite_IMG.Location = new System.Drawing.Point(401, 5);
			this.WebSite_IMG.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.WebSite_IMG.Name = "WebSite_IMG";
			this.WebSite_IMG.Size = new System.Drawing.Size(29, 30);
			this.WebSite_IMG.TabIndex = 4;
			this.WebSite_IMG.TabStop = false;
			this.WebSite_IMG.Click += new System.EventHandler(this.WebSite_IMG_Click);
			// 
			// GitHub_IMG
			// 
			this.GitHub_IMG.Cursor = System.Windows.Forms.Cursors.Hand;
			this.GitHub_IMG.Image = global::TextWrapper.Properties.Resources.gitHub;
			this.GitHub_IMG.Location = new System.Drawing.Point(367, 5);
			this.GitHub_IMG.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.GitHub_IMG.Name = "GitHub_IMG";
			this.GitHub_IMG.Size = new System.Drawing.Size(30, 30);
			this.GitHub_IMG.TabIndex = 3;
			this.GitHub_IMG.TabStop = false;
			this.GitHub_IMG.Click += new System.EventHandler(this.GitHub_IMG_Click);
			// 
			// LinkedIn_IMG
			// 
			this.LinkedIn_IMG.Cursor = System.Windows.Forms.Cursors.Hand;
			this.LinkedIn_IMG.Image = global::TextWrapper.Properties.Resources.linkedin;
			this.LinkedIn_IMG.Location = new System.Drawing.Point(334, 5);
			this.LinkedIn_IMG.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.LinkedIn_IMG.Name = "LinkedIn_IMG";
			this.LinkedIn_IMG.Size = new System.Drawing.Size(29, 30);
			this.LinkedIn_IMG.TabIndex = 2;
			this.LinkedIn_IMG.TabStop = false;
			this.LinkedIn_IMG.Click += new System.EventHandler(this.LinkedIn_IMG_Click);
			// 
			// SelectPath_BTN
			// 
			this.SelectPath_BTN.BackColor = System.Drawing.Color.DeepSkyBlue;
			this.SelectPath_BTN.Location = new System.Drawing.Point(9, 58);
			this.SelectPath_BTN.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.SelectPath_BTN.Name = "SelectPath_BTN";
			this.SelectPath_BTN.Size = new System.Drawing.Size(76, 24);
			this.SelectPath_BTN.TabIndex = 2;
			this.SelectPath_BTN.Text = "Save Path";
			this.SelectPath_BTN.UseVisualStyleBackColor = false;
			this.SelectPath_BTN.Click += new System.EventHandler(this.SelectPath_BTN_Click);
			// 
			// Path_TB
			// 
			this.Path_TB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.Path_TB.BackColor = System.Drawing.SystemColors.Info;
			this.Path_TB.Location = new System.Drawing.Point(89, 59);
			this.Path_TB.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.Path_TB.Name = "Path_TB";
			this.Path_TB.Size = new System.Drawing.Size(614, 23);
			this.Path_TB.TabIndex = 3;
			// 
			// TextBox_RTB
			// 
			this.TextBox_RTB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.TextBox_RTB.BackColor = System.Drawing.Color.Gainsboro;
			this.TextBox_RTB.Location = new System.Drawing.Point(10, 88);
			this.TextBox_RTB.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.TextBox_RTB.Name = "TextBox_RTB";
			this.TextBox_RTB.Size = new System.Drawing.Size(763, 388);
			this.TextBox_RTB.TabIndex = 4;
			this.TextBox_RTB.Text = "";
			// 
			// Clear_BTN
			// 
			this.Clear_BTN.BackColor = System.Drawing.Color.SandyBrown;
			this.Clear_BTN.Location = new System.Drawing.Point(707, 58);
			this.Clear_BTN.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.Clear_BTN.Name = "Clear_BTN";
			this.Clear_BTN.Size = new System.Drawing.Size(66, 24);
			this.Clear_BTN.TabIndex = 5;
			this.Clear_BTN.Text = "Clear";
			this.Clear_BTN.UseVisualStyleBackColor = false;
			this.Clear_BTN.Click += new System.EventHandler(this.Clear_BTN_Click);
			// 
			// Run_BTN
			// 
			this.Run_BTN.BackColor = System.Drawing.Color.DarkSeaGreen;
			this.Run_BTN.Location = new System.Drawing.Point(10, 482);
			this.Run_BTN.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.Run_BTN.Name = "Run_BTN";
			this.Run_BTN.Size = new System.Drawing.Size(763, 23);
			this.Run_BTN.TabIndex = 6;
			this.Run_BTN.Text = "Run";
			this.Run_BTN.UseVisualStyleBackColor = false;
			this.Run_BTN.Click += new System.EventHandler(this.Run_BTN_Click);
			// 
			// WorkSpace_FRM
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.DimGray;
			this.ClientSize = new System.Drawing.Size(784, 561);
			this.Controls.Add(this.Run_BTN);
			this.Controls.Add(this.Clear_BTN);
			this.Controls.Add(this.TextBox_RTB);
			this.Controls.Add(this.Path_TB);
			this.Controls.Add(this.SelectPath_BTN);
			this.Controls.Add(this.Footer_PNL);
			this.Controls.Add(this.Header_PNL);
			this.Cursor = System.Windows.Forms.Cursors.Hand;
			this.Font = new System.Drawing.Font("Microsoft PhagsPa", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.MaximizeBox = false;
			this.Name = "WorkSpace_FRM";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Work Space";
			this.Header_PNL.ResumeLayout(false);
			this.Header_PNL.PerformLayout();
			this.Footer_PNL.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.WebSite_IMG)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.GitHub_IMG)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.LinkedIn_IMG)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel Header_PNL;
		private System.Windows.Forms.Label Header_LBL;
		private System.Windows.Forms.Panel Footer_PNL;
		private System.Windows.Forms.PictureBox WebSite_IMG;
		private System.Windows.Forms.PictureBox GitHub_IMG;
		private System.Windows.Forms.PictureBox LinkedIn_IMG;
		private System.Windows.Forms.Button SelectPath_BTN;
		private System.Windows.Forms.TextBox Path_TB;
		private System.Windows.Forms.RichTextBox TextBox_RTB;
		private System.Windows.Forms.Button Clear_BTN;
		private System.Windows.Forms.Button Run_BTN;
	}
}

