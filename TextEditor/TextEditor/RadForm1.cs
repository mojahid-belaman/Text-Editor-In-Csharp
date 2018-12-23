using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace TextEditor
{
	public partial class RadForm1 : RadForm
	{
		public RadForm1()
		{
			InitializeComponent();
		}

		private void setFont()
		{
			string strFont = "Tahoma";
			if (cbFontName.SelectedIndex > -1)
				strFont = cbFontName.SelectedItem.ToString();
			FontStyle fs = new FontStyle();
			if(chbBold.Checked)
				fs = FontStyle.Regular|FontStyle.Bold;
			if(chbUnderline.Checked)
				fs = FontStyle.Regular|FontStyle.Underline;
			if(chbItalic.Checked)
				fs = FontStyle.Regular|FontStyle.Italic;
			if(chbStrike.Checked)
				fs = FontStyle.Regular|FontStyle.Strikeout;
			Font f = new Font(strFont, Convert.ToInt32(txtNum.Text), fs);
			txtEditor.SelectionFont = f;
		}
		private void RadForm1_Load(object sender, EventArgs e)
		{
			foreach (FontFamily f in FontFamily.Families)
			{
				cbFontName.Items.Add(f.Name);
			}

			cbFontName.Text = "Tahoma";
		}

		private void cbFontName_SelectedIndexChanged(object sender, EventArgs e)
		{
			setFont();
		}

		private void setColor(Color col)
		{
			if (rdText.IsChecked) txtEditor.SelectionColor = col;
			else
				txtEditor.SelectionBackColor = col;

		}

		private void radButton2_Click(object sender, EventArgs e)
		{
			setColor(((RadButton)sender).BackColor);
		}

		private void radButton17_Click(object sender, EventArgs e)
		{
			RadColorDialog c = new RadColorDialog();
			if (c.ShowDialog() == DialogResult.OK)
			{
				setColor(c.SelectedColor);
			}
		}
	}
}
