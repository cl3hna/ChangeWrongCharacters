using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChangeWrongCharacters
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void btnFileLocation_Click(object sender, EventArgs e)
		{
			ofdPath.Filter = "Text files (*.txt)|*.txt|Srt files (*.srt)|*.srt";
			ofdPath.FileName = "";
			DialogResult result = ofdPath.ShowDialog();
			if (result == DialogResult.OK)
			{
				string filePath = ofdPath.FileName;
				this.textBox1.Text = filePath;
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			try
			{
				this.rtbResult.Clear();

				string fileContent = "";
				fileContent = File.ReadAllText(this.textBox1.Text);
				if (!string.IsNullOrEmpty(this.textBox1.Text))
				{
					List<char> forbiddenChars = new List<char>() { 'ê', '³', '¿', 'Ÿ', 'æ', '¹', 'œ', 'Ñ', '£', '¯', 'ñ', 'Œ' };
					List<char> correctChars = new List<char>() { 'ę', 'ł', 'ż', 'ź', 'ć', 'ą', 'ś', 'Ń', 'Ł', 'Ż', 'ń', 'Ś' };
					List<int> charsCounter = new List<int>();

					int counter;
					foreach (var item in forbiddenChars)
					{
						counter = fileContent.Count(c => c == item);
						charsCounter.Add(counter);
					}

					for (int i = 0; i < forbiddenChars.Count; i++)
					{
						fileContent = fileContent.Replace(forbiddenChars[i], correctChars[i]);
						this.rtbResult.Text += $" {charsCounter[i]} occurences of '{forbiddenChars[i]}' were replaced as '{correctChars[i]}' {Environment.NewLine}";
					}

					File.WriteAllText(this.textBox1.Text, fileContent);

					MessageBox.Show("Operation completed successfully");
				}
				else
					MessageBox.Show("Select your file first!");
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
	}
}
