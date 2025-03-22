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
			this.LinkedIn_IMG = new System.Windows.Forms.PictureBox();
			this.GitHub_IMG = new System.Windows.Forms.PictureBox();
			this.WebSite_IMG = new System.Windows.Forms.PictureBox();
			this.Header_PNL.SuspendLayout();
			this.Footer_PNL.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.LinkedIn_IMG)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.GitHub_IMG)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.WebSite_IMG)).BeginInit();
			this.SuspendLayout();
			// 
			// Header_PNL
			// 
			this.Header_PNL.BackColor = System.Drawing.SystemColors.Window;
			this.Header_PNL.Controls.Add(this.Header_LBL);
			this.Header_PNL.Location = new System.Drawing.Point(12, 12);
			this.Header_PNL.Name = "Header_PNL";
			this.Header_PNL.Size = new System.Drawing.Size(760, 50);
			this.Header_PNL.TabIndex = 0;
			// 
			// Header_LBL
			// 
			this.Header_LBL.AutoSize = true;
			this.Header_LBL.Location = new System.Drawing.Point(312, 14);
			this.Header_LBL.Name = "Header_LBL";
			this.Header_LBL.Size = new System.Drawing.Size(128, 21);
			this.Header_LBL.TabIndex = 0;
			this.Header_LBL.Text = "Text Wrapper!";
			// 
			// Footer_PNL
			// 
			this.Footer_PNL.BackColor = System.Drawing.SystemColors.Window;
			this.Footer_PNL.Controls.Add(this.WebSite_IMG);
			this.Footer_PNL.Controls.Add(this.GitHub_IMG);
			this.Footer_PNL.Controls.Add(this.LinkedIn_IMG);
			this.Footer_PNL.Location = new System.Drawing.Point(12, 499);
			this.Footer_PNL.Name = "Footer_PNL";
			this.Footer_PNL.Size = new System.Drawing.Size(760, 50);
			this.Footer_PNL.TabIndex = 1;
			// 
			// LinkedIn_IMG
			// 
			this.LinkedIn_IMG.Cursor = System.Windows.Forms.Cursors.Hand;
			this.LinkedIn_IMG.Image = global::TextWrapper.Properties.Resources.linkedin;
			this.LinkedIn_IMG.Location = new System.Drawing.Point(325, 11);
			this.LinkedIn_IMG.Name = "LinkedIn_IMG";
			this.LinkedIn_IMG.Size = new System.Drawing.Size(30, 30);
			this.LinkedIn_IMG.TabIndex = 2;
			this.LinkedIn_IMG.TabStop = false;
			this.LinkedIn_IMG.Click += new System.EventHandler(this.LinkedIn_IMG_Click);
			// 
			// GitHub_IMG
			// 
			this.GitHub_IMG.Cursor = System.Windows.Forms.Cursors.Hand;
			this.GitHub_IMG.Image = global::TextWrapper.Properties.Resources.gitHub;
			this.GitHub_IMG.Location = new System.Drawing.Point(361, 11);
			this.GitHub_IMG.Name = "GitHub_IMG";
			this.GitHub_IMG.Size = new System.Drawing.Size(30, 30);
			this.GitHub_IMG.TabIndex = 3;
			this.GitHub_IMG.TabStop = false;
			this.GitHub_IMG.Click += new System.EventHandler(this.GitHub_IMG_Click);
			// 
			// WebSite_IMG
			// 
			this.WebSite_IMG.Cursor = System.Windows.Forms.Cursors.Hand;
			this.WebSite_IMG.Image = global::TextWrapper.Properties.Resources.website;
			this.WebSite_IMG.Location = new System.Drawing.Point(397, 11);
			this.WebSite_IMG.Name = "WebSite_IMG";
			this.WebSite_IMG.Size = new System.Drawing.Size(30, 30);
			this.WebSite_IMG.TabIndex = 4;
			this.WebSite_IMG.TabStop = false;
			this.WebSite_IMG.Click += new System.EventHandler(this.WebSite_IMG_Click);
			// 
			// WorkSpace_FRM
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.WindowFrame;
			this.ClientSize = new System.Drawing.Size(784, 561);
			this.Controls.Add(this.Footer_PNL);
			this.Controls.Add(this.Header_PNL);
			this.Font = new System.Drawing.Font("Montserrat Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
			this.Name = "WorkSpace_FRM";
			this.Text = "Work Space";
			this.Header_PNL.ResumeLayout(false);
			this.Header_PNL.PerformLayout();
			this.Footer_PNL.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.LinkedIn_IMG)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.GitHub_IMG)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.WebSite_IMG)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel Header_PNL;
		private System.Windows.Forms.Label Header_LBL;
		private System.Windows.Forms.Panel Footer_PNL;
		private System.Windows.Forms.PictureBox WebSite_IMG;
		private System.Windows.Forms.PictureBox GitHub_IMG;
		private System.Windows.Forms.PictureBox LinkedIn_IMG;
	}
}

