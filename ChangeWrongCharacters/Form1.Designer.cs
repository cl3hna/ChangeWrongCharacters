namespace ChangeWrongCharacters
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.label1 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.btnFileLocation = new System.Windows.Forms.Button();
			this.ofdPath = new System.Windows.Forms.OpenFileDialog();
			this.button1 = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.rtbResult = new System.Windows.Forms.RichTextBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 35);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(88, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Your file location:";
			// 
			// textBox1
			// 
			this.textBox1.Enabled = false;
			this.textBox1.Location = new System.Drawing.Point(106, 28);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(251, 20);
			this.textBox1.TabIndex = 1;
			// 
			// btnFileLocation
			// 
			this.btnFileLocation.Location = new System.Drawing.Point(254, 54);
			this.btnFileLocation.Name = "btnFileLocation";
			this.btnFileLocation.Size = new System.Drawing.Size(103, 23);
			this.btnFileLocation.TabIndex = 2;
			this.btnFileLocation.Text = "File Location";
			this.btnFileLocation.UseVisualStyleBackColor = true;
			this.btnFileLocation.Click += new System.EventHandler(this.btnFileLocation_Click);
			// 
			// ofdPath
			// 
			this.ofdPath.FileName = "ofdPath";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(190, 92);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(167, 23);
			this.button1.TabIndex = 3;
			this.button1.Text = "Change Wrong Characters";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(60, 131);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(40, 13);
			this.label2.TabIndex = 4;
			this.label2.Text = "Result:";
			// 
			// rtbResult
			// 
			this.rtbResult.Location = new System.Drawing.Point(106, 131);
			this.rtbResult.Name = "rtbResult";
			this.rtbResult.Size = new System.Drawing.Size(251, 169);
			this.rtbResult.TabIndex = 5;
			this.rtbResult.Text = "";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(388, 319);
			this.Controls.Add(this.rtbResult);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.btnFileLocation);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Change Wrong Characters";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Button btnFileLocation;
		private System.Windows.Forms.OpenFileDialog ofdPath;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.RichTextBox rtbResult;
	}
}

