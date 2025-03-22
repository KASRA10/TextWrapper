// Ignore Spelling: FRM splitted

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace TextWrapper
{
	public partial class WorkSpace_FRM : Form
	{
		#region Public_Variables
		public List<string> splittedText = new List<string>();
		#endregion
		public WorkSpace_FRM()
		{
			InitializeComponent();
			Path_TB.Text = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Downloads");
			TextBox_RTB.Text = "Enter Your Text Here . . .";
		}

		// Select Path
		private void SelectPath_BTN_Click(object sender, EventArgs e)
		{
			FolderBrowserDialog SaveFolderPath = new FolderBrowserDialog();
			SaveFolderPath.RootFolder = Environment.SpecialFolder.MyComputer;
			SaveFolderPath.ShowNewFolderButton = true;
			if (SaveFolderPath.ShowDialog() == DialogResult.OK)
			{
				Path_TB.Text = SaveFolderPath.SelectedPath; // Set Selected Path Address To The Text Of TextBox. 
			}
		}

		// Run Button
		private void Run_BTN_Click(object sender, EventArgs e)
		{
			splittedText = TextBox_RTB.Text.Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries).ToList();

			try
			{
				// Get the folder path from Path_TB TextBox and add a filename
				string folderPath = Path_TB.Text;
				string fileName = "TextWrappedResult.txt";
				string filePath = Path.Combine(folderPath, fileName);

				// Write all strings to the file, each on a new line
				File.WriteAllLines(filePath, splittedText);

				// Show success message with the full path
				DialogResult result = MessageBox.Show($"File saved successfully at: {filePath}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			catch (Exception ex)
			{
				// Handle any errors (like invalid path, permissions, etc.)
				DialogResult result = MessageBox.Show($"Error saving file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		// Clear Button
		private void Clear_BTN_Click(object sender, EventArgs e)
		{
			splittedText.Clear();
			Path_TB.Text = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Downloads");
			TextBox_RTB.Text = "Enter Your Text Here . . .";
		}

		#region Footer
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
				DialogResult result = MessageBox.Show("Unable to open the link. Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
				DialogResult result = MessageBox.Show("Unable to open the link. Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
				DialogResult result = MessageBox.Show("Unable to open the link. Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		#endregion
	}
}
