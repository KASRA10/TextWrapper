using System;
using System.Windows.Forms;

namespace TextWrapper
{
	public partial class WorkSpace_FRM : Form
	{
		public WorkSpace_FRM()
		{
			InitializeComponent();
		}

		// LinkedIn Image Link
		private void LinkedIn_IMG_Click(object sender, EventArgs e)
		{
			// URL to open  
			string url = "https://linkedin.com/in/kasra-hosseini-k10";
			try
			{
				// Use Process.Start to open the URL in the default browser  
				System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
				{
					FileName = url,
					UseShellExecute = true // Ensures it uses the default browser  
				});
			}
			catch (Exception ex)
			{
				// Handle exceptions, such as when a browser is unavailable  
				MessageBox.Show("Unable to open the link. Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		// Github Image Link
		private void GitHub_IMG_Click(object sender, EventArgs e)
		{
			// URL to open  
			string url = "https://github.com/KASRA10";
			try
			{
				// Use Process.Start to open the URL in the default browser  
				System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
				{
					FileName = url,
					UseShellExecute = true // Ensures it uses the default browser  
				});
			}
			catch (Exception ex)
			{
				// Handle exceptions, such as when a browser is unavailable  
				MessageBox.Show("Unable to open the link. Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		// Website IMage Link
		private void WebSite_IMG_Click(object sender, EventArgs e)
		{
			// URL to open  
			string url = "https://kasra10design.com/";
			try
			{
				// Use Process.Start to open the URL in the default browser  
				System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
				{
					FileName = url,
					UseShellExecute = true // Ensures it uses the default browser  
				});
			}
			catch (Exception ex)
			{
				// Handle exceptions, such as when a browser is unavailable  
				MessageBox.Show("Unable to open the link. Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
	}
}
