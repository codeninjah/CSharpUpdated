namespace PersonNrApp
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
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.greetLabel = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(44, 29);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(198, 22);
			this.textBox1.TabIndex = 0;
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(396, 29);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(241, 22);
			this.textBox2.TabIndex = 1;
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(153, 101);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(326, 22);
			this.textBox3.TabIndex = 2;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(396, 259);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(251, 90);
			this.button1.TabIndex = 3;
			this.button1.Text = "button1";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// greetLabel
			// 
			this.greetLabel.AutoSize = true;
			this.greetLabel.Location = new System.Drawing.Point(98, 296);
			this.greetLabel.Name = "greetLabel";
			this.greetLabel.Size = new System.Drawing.Size(0, 17);
			this.greetLabel.TabIndex = 4;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(113, 9);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(64, 17);
			this.label2.TabIndex = 5;
			this.label2.Text = "Förnamn";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(501, 9);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(73, 17);
			this.label3.TabIndex = 6;
			this.label3.Text = "Efternamn";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(292, 81);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(68, 17);
			this.label4.TabIndex = 7;
			this.label4.Text = "PersonNr";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(743, 381);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.greetLabel);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label greetLabel;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
	}
}

