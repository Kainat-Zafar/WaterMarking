using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;

namespace imageprocessing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            grpTextWatermark.Top = grpImgWatermark.Top;
            grpTextWatermark.Left = grpImgWatermark.Left;

            cmbWatermarkType.SelectedIndex = 1;
            cmbTextFont.SelectedIndex = 3;
            cmbTextColor.SelectedIndex = 0;
            cmbTextSize.SelectedIndex = 0;
        }

        private void cmbWatermarkType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbWatermarkType.SelectedIndex == 0)
            {
                grpTextWatermark.Visible = true;
                grpImgWatermark.Visible = false;
            }
            else
            {
                grpImgWatermark.Visible = true;
                grpTextWatermark.Visible = false;
            }
        }

        private void cmbTextColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTextColor.SelectedIndex == 0)
                lblTextPreview.ForeColor = Color.Black;
            else if (cmbTextColor.SelectedIndex == 1)
                lblTextPreview.ForeColor = Color.White;
            else if (cmbTextColor.SelectedIndex == 2)
                lblTextPreview.ForeColor = Color.Red;
            else if (cmbTextColor.SelectedIndex == 3)
                lblTextPreview.ForeColor = Color.Blue;
            else if (cmbTextColor.SelectedIndex == 4)
                lblTextPreview.ForeColor = Color.Green;
            else if (cmbTextColor.SelectedIndex == 5)
                lblTextPreview.ForeColor = Color.Yellow;
        }

        private void cmbTextSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            changelabel();
        }

        private void changelabel()
        {
            string fontname = "";
            Single fontsize = 8;

            if (cmbTextFont.SelectedIndex == 0)
                fontname = "Arial";
            else if (cmbTextFont.SelectedIndex == 1)
                fontname = "Calibri";
            else if (cmbTextFont.SelectedIndex == 2)
                fontname = "Cambria";
            else if (cmbTextFont.SelectedIndex == 3)
                fontname = "Microsoft Sans Serif";
            else if (cmbTextFont.SelectedIndex == 4)
                fontname = "Tahoma";
            else if (cmbTextFont.SelectedIndex == 5)
                fontname = "Times New Roman";

            if (cmbTextSize.SelectedIndex >= 0)
                fontsize = Convert.ToSingle(cmbTextSize.Text);

            lblTextPreview.Font = new System.Drawing.Font(fontname, fontsize, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        }

        private void cmbTextFont_SelectedIndexChanged(object sender, EventArgs e)
        {
            changelabel();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();

            if (openFileDialog1.FileName != "")
            {
                lstInitialFiles.Items.Add(openFileDialog1.FileName);
            }
        }

        private void lstInitialFiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            picPreviewInitFile.BackgroundImage = Image.FromFile(lstInitialFiles.Text);
        }
    }
}