namespace PracticeApp
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
			this.btn_Save = new System.Windows.Forms.Button();
			this.txt_PhoneNr = new System.Windows.Forms.TextBox();
			this.txt_PersonNr = new System.Windows.Forms.TextBox();
			this.spara_tillFil = new System.Windows.Forms.SaveFileDialog();
			this.lasa_frånFil = new System.Windows.Forms.OpenFileDialog();
			this.dtp_Fodelsedatum = new System.Windows.Forms.DateTimePicker();
			this.btn_Convert = new System.Windows.Forms.Button();
			this.konvertera_tillFil = new System.Windows.Forms.SaveFileDialog();
			this.SuspendLayout();
			// 
			// btn_Save
			// 
			this.btn_Save.Location = new System.Drawing.Point(213, 165);
			this.btn_Save.Name = "btn_Save";
			this.btn_Save.Size = new System.Drawing.Size(106, 70);
			this.btn_Save.TabIndex = 0;
			this.btn_Save.Text = "Spara";
			this.btn_Save.UseVisualStyleBackColor = true;
			this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
			// 
			// txt_PhoneNr
			// 
			this.txt_PhoneNr.Location = new System.Drawing.Point(542, 67);
			this.txt_PhoneNr.Name = "txt_PhoneNr";
			this.txt_PhoneNr.Size = new System.Drawing.Size(215, 22);
			this.txt_PhoneNr.TabIndex = 2;
			this.txt_PhoneNr.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
			// 
			// txt_PersonNr
			// 
			this.txt_PersonNr.Location = new System.Drawing.Point(23, 67);
			this.txt_PersonNr.Name = "txt_PersonNr";
			this.txt_PersonNr.Size = new System.Drawing.Size(215, 22);
			this.txt_PersonNr.TabIndex = 3;
			// 
			// lasa_frånFil
			// 
			this.lasa_frånFil.FileName = "openFileDialog1";
			this.lasa_frånFil.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
			// 
			// dtp_Fodelsedatum
			// 
			this.dtp_Fodelsedatum.Location = new System.Drawing.Point(303, 67);
			this.dtp_Fodelsedatum.Name = "dtp_Fodelsedatum";
			this.dtp_Fodelsedatum.Size = new System.Drawing.Size(200, 22);
			this.dtp_Fodelsedatum.TabIndex = 4;
			// 
			// btn_Convert
			// 
			this.btn_Convert.Location = new System.Drawing.Point(449, 165);
			this.btn_Convert.Name = "btn_Convert";
			this.btn_Convert.Size = new System.Drawing.Size(91, 70);
			this.btn_Convert.TabIndex = 5;
			this.btn_Convert.Text = "Konvertera";
			this.btn_Convert.UseVisualStyleBackColor = true;
			this.btn_Convert.Click += new System.EventHandler(this.btn_Convert_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(769, 374);
			this.Controls.Add(this.btn_Convert);
			this.Controls.Add(this.dtp_Fodelsedatum);
			this.Controls.Add(this.txt_PersonNr);
			this.Controls.Add(this.txt_PhoneNr);
			this.Controls.Add(this.btn_Save);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btn_Save;
		private System.Windows.Forms.TextBox txt_PhoneNr;
		private System.Windows.Forms.TextBox txt_PersonNr;
		private System.Windows.Forms.SaveFileDialog spara_tillFil;
		private System.Windows.Forms.OpenFileDialog lasa_frånFil;
		private System.Windows.Forms.DateTimePicker dtp_Fodelsedatum;
		private System.Windows.Forms.Button btn_Convert;
		private System.Windows.Forms.SaveFileDialog konvertera_tillFil;
	}
}

