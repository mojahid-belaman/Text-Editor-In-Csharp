namespace TextEditor
{
	partial class RadForm1
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RadForm1));
			this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
			this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
			this.txtNum = new System.Windows.Forms.NumericUpDown();
			this.rdText = new Telerik.WinControls.UI.RadRadioButton();
			this.rdBack = new Telerik.WinControls.UI.RadRadioButton();
			this.radButton1 = new Telerik.WinControls.UI.RadButton();
			this.radButton2 = new Telerik.WinControls.UI.RadButton();
			this.radButton3 = new Telerik.WinControls.UI.RadButton();
			this.radButton4 = new Telerik.WinControls.UI.RadButton();
			this.radButton5 = new Telerik.WinControls.UI.RadButton();
			this.radButton6 = new Telerik.WinControls.UI.RadButton();
			this.radButton7 = new Telerik.WinControls.UI.RadButton();
			this.radButton8 = new Telerik.WinControls.UI.RadButton();
			this.radButton9 = new Telerik.WinControls.UI.RadButton();
			this.radButton10 = new Telerik.WinControls.UI.RadButton();
			this.radButton11 = new Telerik.WinControls.UI.RadButton();
			this.radButton12 = new Telerik.WinControls.UI.RadButton();
			this.radButton13 = new Telerik.WinControls.UI.RadButton();
			this.radButton14 = new Telerik.WinControls.UI.RadButton();
			this.radButton15 = new Telerik.WinControls.UI.RadButton();
			this.radButton16 = new Telerik.WinControls.UI.RadButton();
			this.radButton17 = new Telerik.WinControls.UI.RadButton();
			this.txtEditor = new System.Windows.Forms.RichTextBox();
			this.cbFontName = new System.Windows.Forms.ComboBox();
			this.chbBold = new System.Windows.Forms.CheckBox();
			this.chbUnderline = new System.Windows.Forms.CheckBox();
			this.chbItalic = new System.Windows.Forms.CheckBox();
			this.chbStrike = new System.Windows.Forms.CheckBox();
			((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtNum)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.rdText)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.rdBack)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.radButton1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.radButton2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.radButton3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.radButton4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.radButton5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.radButton6)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.radButton7)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.radButton8)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.radButton9)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.radButton10)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.radButton11)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.radButton12)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.radButton13)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.radButton14)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.radButton15)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.radButton16)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.radButton17)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
			this.SuspendLayout();
			// 
			// radLabel1
			// 
			this.radLabel1.Font = new System.Drawing.Font("Segoe UI", 13F);
			this.radLabel1.Location = new System.Drawing.Point(-3, 7);
			this.radLabel1.Name = "radLabel1";
			this.radLabel1.Size = new System.Drawing.Size(104, 27);
			this.radLabel1.TabIndex = 0;
			this.radLabel1.Text = "Font Name :";
			// 
			// radLabel2
			// 
			this.radLabel2.Font = new System.Drawing.Font("Segoe UI", 13F);
			this.radLabel2.Location = new System.Drawing.Point(316, 7);
			this.radLabel2.Name = "radLabel2";
			this.radLabel2.Size = new System.Drawing.Size(39, 27);
			this.radLabel2.TabIndex = 1;
			this.radLabel2.Text = "Size";
			// 
			// txtNum
			// 
			this.txtNum.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.txtNum.Location = new System.Drawing.Point(316, 36);
			this.txtNum.Maximum = new decimal(new int[] {
            72,
            0,
            0,
            0});
			this.txtNum.Minimum = new decimal(new int[] {
            8,
            0,
            0,
            0});
			this.txtNum.Name = "txtNum";
			this.txtNum.Size = new System.Drawing.Size(55, 29);
			this.txtNum.TabIndex = 3;
			this.txtNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtNum.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
			this.txtNum.ValueChanged += new System.EventHandler(this.cbFontName_SelectedIndexChanged);
			// 
			// rdText
			// 
			this.rdText.CheckState = System.Windows.Forms.CheckState.Checked;
			this.rdText.Font = new System.Drawing.Font("Segoe UI", 13F);
			this.rdText.Location = new System.Drawing.Point(740, 12);
			this.rdText.Name = "rdText";
			this.rdText.Size = new System.Drawing.Size(55, 27);
			this.rdText.TabIndex = 7;
			this.rdText.Text = "Text";
			this.rdText.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;
			// 
			// rdBack
			// 
			this.rdBack.Font = new System.Drawing.Font("Segoe UI", 13F);
			this.rdBack.Location = new System.Drawing.Point(740, 40);
			this.rdBack.Name = "rdBack";
			this.rdBack.Size = new System.Drawing.Size(59, 27);
			this.rdBack.TabIndex = 8;
			this.rdBack.TabStop = false;
			this.rdBack.Text = "Back";
			// 
			// radButton1
			// 
			this.radButton1.BackColor = System.Drawing.Color.White;
			this.radButton1.Location = new System.Drawing.Point(801, 12);
			this.radButton1.Name = "radButton1";
			this.radButton1.Size = new System.Drawing.Size(25, 25);
			this.radButton1.TabIndex = 10;
			this.radButton1.Click += new System.EventHandler(this.radButton2_Click);
			// 
			// radButton2
			// 
			this.radButton2.BackColor = System.Drawing.Color.Red;
			this.radButton2.Location = new System.Drawing.Point(801, 43);
			this.radButton2.Name = "radButton2";
			this.radButton2.Size = new System.Drawing.Size(25, 25);
			this.radButton2.TabIndex = 11;
			this.radButton2.Click += new System.EventHandler(this.radButton2_Click);
			// 
			// radButton3
			// 
			this.radButton3.BackColor = System.Drawing.Color.Lime;
			this.radButton3.Location = new System.Drawing.Point(832, 43);
			this.radButton3.Name = "radButton3";
			this.radButton3.Size = new System.Drawing.Size(25, 25);
			this.radButton3.TabIndex = 13;
			this.radButton3.Click += new System.EventHandler(this.radButton2_Click);
			// 
			// radButton4
			// 
			this.radButton4.BackColor = System.Drawing.Color.Blue;
			this.radButton4.Location = new System.Drawing.Point(832, 12);
			this.radButton4.Name = "radButton4";
			this.radButton4.Size = new System.Drawing.Size(25, 25);
			this.radButton4.TabIndex = 12;
			this.radButton4.Click += new System.EventHandler(this.radButton2_Click);
			// 
			// radButton5
			// 
			this.radButton5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.radButton5.Location = new System.Drawing.Point(894, 43);
			this.radButton5.Name = "radButton5";
			this.radButton5.Size = new System.Drawing.Size(25, 25);
			this.radButton5.TabIndex = 17;
			this.radButton5.Click += new System.EventHandler(this.radButton2_Click);
			// 
			// radButton6
			// 
			this.radButton6.BackColor = System.Drawing.Color.Aqua;
			this.radButton6.Location = new System.Drawing.Point(894, 12);
			this.radButton6.Name = "radButton6";
			this.radButton6.Size = new System.Drawing.Size(25, 25);
			this.radButton6.TabIndex = 16;
			this.radButton6.Click += new System.EventHandler(this.radButton2_Click);
			// 
			// radButton7
			// 
			this.radButton7.BackColor = System.Drawing.Color.Fuchsia;
			this.radButton7.Location = new System.Drawing.Point(863, 43);
			this.radButton7.Name = "radButton7";
			this.radButton7.Size = new System.Drawing.Size(25, 25);
			this.radButton7.TabIndex = 15;
			this.radButton7.Click += new System.EventHandler(this.radButton2_Click);
			// 
			// radButton8
			// 
			this.radButton8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.radButton8.Location = new System.Drawing.Point(863, 12);
			this.radButton8.Name = "radButton8";
			this.radButton8.Size = new System.Drawing.Size(25, 25);
			this.radButton8.TabIndex = 14;
			this.radButton8.Click += new System.EventHandler(this.radButton2_Click);
			// 
			// radButton9
			// 
			this.radButton9.BackColor = System.Drawing.Color.Black;
			this.radButton9.Location = new System.Drawing.Point(1018, 43);
			this.radButton9.Name = "radButton9";
			this.radButton9.Size = new System.Drawing.Size(25, 25);
			this.radButton9.TabIndex = 25;
			this.radButton9.Click += new System.EventHandler(this.radButton2_Click);
			// 
			// radButton10
			// 
			this.radButton10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.radButton10.Location = new System.Drawing.Point(1018, 12);
			this.radButton10.Name = "radButton10";
			this.radButton10.Size = new System.Drawing.Size(25, 25);
			this.radButton10.TabIndex = 24;
			this.radButton10.Click += new System.EventHandler(this.radButton2_Click);
			// 
			// radButton11
			// 
			this.radButton11.BackColor = System.Drawing.Color.Purple;
			this.radButton11.Location = new System.Drawing.Point(987, 43);
			this.radButton11.Name = "radButton11";
			this.radButton11.Size = new System.Drawing.Size(25, 25);
			this.radButton11.TabIndex = 23;
			this.radButton11.Click += new System.EventHandler(this.radButton2_Click);
			// 
			// radButton12
			// 
			this.radButton12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.radButton12.Location = new System.Drawing.Point(987, 12);
			this.radButton12.Name = "radButton12";
			this.radButton12.Size = new System.Drawing.Size(25, 25);
			this.radButton12.TabIndex = 22;
			this.radButton12.Click += new System.EventHandler(this.radButton2_Click);
			// 
			// radButton13
			// 
			this.radButton13.BackColor = System.Drawing.Color.Green;
			this.radButton13.Location = new System.Drawing.Point(956, 43);
			this.radButton13.Name = "radButton13";
			this.radButton13.Size = new System.Drawing.Size(25, 25);
			this.radButton13.TabIndex = 21;
			this.radButton13.Click += new System.EventHandler(this.radButton2_Click);
			// 
			// radButton14
			// 
			this.radButton14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
			this.radButton14.Location = new System.Drawing.Point(956, 12);
			this.radButton14.Name = "radButton14";
			this.radButton14.Size = new System.Drawing.Size(25, 25);
			this.radButton14.TabIndex = 20;
			this.radButton14.Click += new System.EventHandler(this.radButton2_Click);
			// 
			// radButton15
			// 
			this.radButton15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			this.radButton15.Location = new System.Drawing.Point(925, 43);
			this.radButton15.Name = "radButton15";
			this.radButton15.Size = new System.Drawing.Size(25, 25);
			this.radButton15.TabIndex = 19;
			this.radButton15.Click += new System.EventHandler(this.radButton2_Click);
			// 
			// radButton16
			// 
			this.radButton16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
			this.radButton16.Location = new System.Drawing.Point(925, 12);
			this.radButton16.Name = "radButton16";
			this.radButton16.Size = new System.Drawing.Size(25, 25);
			this.radButton16.TabIndex = 18;
			this.radButton16.Click += new System.EventHandler(this.radButton2_Click);
			// 
			// radButton17
			// 
			this.radButton17.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
			this.radButton17.ForeColor = System.Drawing.Color.Blue;
			this.radButton17.Location = new System.Drawing.Point(1049, 12);
			this.radButton17.Name = "radButton17";
			this.radButton17.Size = new System.Drawing.Size(72, 56);
			this.radButton17.TabIndex = 26;
			this.radButton17.Text = "More Color";
			this.radButton17.Click += new System.EventHandler(this.radButton17_Click);
			// 
			// txtEditor
			// 
			this.txtEditor.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtEditor.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.txtEditor.Location = new System.Drawing.Point(-3, 71);
			this.txtEditor.Name = "txtEditor";
			this.txtEditor.Size = new System.Drawing.Size(1124, 456);
			this.txtEditor.TabIndex = 27;
			this.txtEditor.Text = resources.GetString("txtEditor.Text");
			// 
			// cbFontName
			// 
			this.cbFontName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.cbFontName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.cbFontName.Font = new System.Drawing.Font("Segoe UI", 13F);
			this.cbFontName.FormattingEnabled = true;
			this.cbFontName.Location = new System.Drawing.Point(0, 33);
			this.cbFontName.Name = "cbFontName";
			this.cbFontName.Size = new System.Drawing.Size(310, 31);
			this.cbFontName.TabIndex = 28;
			this.cbFontName.SelectedIndexChanged += new System.EventHandler(this.cbFontName_SelectedIndexChanged);
			// 
			// chbBold
			// 
			this.chbBold.AutoSize = true;
			this.chbBold.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
			this.chbBold.Location = new System.Drawing.Point(373, 36);
			this.chbBold.Name = "chbBold";
			this.chbBold.Size = new System.Drawing.Size(70, 29);
			this.chbBold.TabIndex = 29;
			this.chbBold.Text = "Bold";
			this.chbBold.UseVisualStyleBackColor = true;
			this.chbBold.CheckedChanged += new System.EventHandler(this.cbFontName_SelectedIndexChanged);
			// 
			// chbUnderline
			// 
			this.chbUnderline.AutoSize = true;
			this.chbUnderline.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Underline);
			this.chbUnderline.Location = new System.Drawing.Point(449, 36);
			this.chbUnderline.Name = "chbUnderline";
			this.chbUnderline.Size = new System.Drawing.Size(106, 29);
			this.chbUnderline.TabIndex = 30;
			this.chbUnderline.Text = "Underline";
			this.chbUnderline.UseVisualStyleBackColor = true;
			this.chbUnderline.CheckedChanged += new System.EventHandler(this.cbFontName_SelectedIndexChanged);
			// 
			// chbItalic
			// 
			this.chbItalic.AutoSize = true;
			this.chbItalic.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Italic);
			this.chbItalic.Location = new System.Drawing.Point(561, 36);
			this.chbItalic.Name = "chbItalic";
			this.chbItalic.Size = new System.Drawing.Size(70, 29);
			this.chbItalic.TabIndex = 31;
			this.chbItalic.Text = "Italic";
			this.chbItalic.UseVisualStyleBackColor = true;
			this.chbItalic.CheckedChanged += new System.EventHandler(this.cbFontName_SelectedIndexChanged);
			// 
			// chbStrike
			// 
			this.chbStrike.AutoSize = true;
			this.chbStrike.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Strikeout);
			this.chbStrike.Location = new System.Drawing.Point(637, 35);
			this.chbStrike.Name = "chbStrike";
			this.chbStrike.Size = new System.Drawing.Size(101, 29);
			this.chbStrike.TabIndex = 32;
			this.chbStrike.Text = "Strikeout";
			this.chbStrike.UseVisualStyleBackColor = true;
			this.chbStrike.CheckedChanged += new System.EventHandler(this.cbFontName_SelectedIndexChanged);
			// 
			// RadForm1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.ClientSize = new System.Drawing.Size(1120, 523);
			this.Controls.Add(this.chbStrike);
			this.Controls.Add(this.chbItalic);
			this.Controls.Add(this.chbUnderline);
			this.Controls.Add(this.chbBold);
			this.Controls.Add(this.cbFontName);
			this.Controls.Add(this.txtEditor);
			this.Controls.Add(this.radButton17);
			this.Controls.Add(this.radButton9);
			this.Controls.Add(this.radButton10);
			this.Controls.Add(this.radButton11);
			this.Controls.Add(this.radButton12);
			this.Controls.Add(this.radButton13);
			this.Controls.Add(this.radButton14);
			this.Controls.Add(this.radButton15);
			this.Controls.Add(this.radButton16);
			this.Controls.Add(this.radButton5);
			this.Controls.Add(this.radButton6);
			this.Controls.Add(this.radButton7);
			this.Controls.Add(this.radButton8);
			this.Controls.Add(this.radButton3);
			this.Controls.Add(this.radButton4);
			this.Controls.Add(this.radButton2);
			this.Controls.Add(this.radButton1);
			this.Controls.Add(this.rdBack);
			this.Controls.Add(this.rdText);
			this.Controls.Add(this.txtNum);
			this.Controls.Add(this.radLabel2);
			this.Controls.Add(this.radLabel1);
			this.MaximizeBox = false;
			this.Name = "RadForm1";
			// 
			// 
			// 
			this.RootElement.ApplyShapeToControl = true;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Text Editor";
			this.Load += new System.EventHandler(this.RadForm1_Load);
			((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtNum)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.rdText)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.rdBack)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.radButton1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.radButton2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.radButton3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.radButton4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.radButton5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.radButton6)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.radButton7)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.radButton8)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.radButton9)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.radButton10)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.radButton11)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.radButton12)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.radButton13)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.radButton14)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.radButton15)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.radButton16)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.radButton17)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Telerik.WinControls.UI.RadLabel radLabel1;
		private Telerik.WinControls.UI.RadLabel radLabel2;
		private System.Windows.Forms.NumericUpDown txtNum;
		private Telerik.WinControls.UI.RadRadioButton rdText;
		private Telerik.WinControls.UI.RadRadioButton rdBack;
		private Telerik.WinControls.UI.RadButton radButton1;
		private Telerik.WinControls.UI.RadButton radButton2;
		private Telerik.WinControls.UI.RadButton radButton3;
		private Telerik.WinControls.UI.RadButton radButton4;
		private Telerik.WinControls.UI.RadButton radButton5;
		private Telerik.WinControls.UI.RadButton radButton6;
		private Telerik.WinControls.UI.RadButton radButton7;
		private Telerik.WinControls.UI.RadButton radButton8;
		private Telerik.WinControls.UI.RadButton radButton9;
		private Telerik.WinControls.UI.RadButton radButton10;
		private Telerik.WinControls.UI.RadButton radButton11;
		private Telerik.WinControls.UI.RadButton radButton12;
		private Telerik.WinControls.UI.RadButton radButton13;
		private Telerik.WinControls.UI.RadButton radButton14;
		private Telerik.WinControls.UI.RadButton radButton15;
		private Telerik.WinControls.UI.RadButton radButton16;
		private Telerik.WinControls.UI.RadButton radButton17;
		private System.Windows.Forms.RichTextBox txtEditor;
		private System.Windows.Forms.ComboBox cbFontName;
		private System.Windows.Forms.CheckBox chbBold;
		private System.Windows.Forms.CheckBox chbUnderline;
		private System.Windows.Forms.CheckBox chbItalic;
		private System.Windows.Forms.CheckBox chbStrike;
	}
}