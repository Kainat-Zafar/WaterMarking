namespace imageprocessing
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtBrowseFile = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.picPreviewInitFile = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBrowseWatermark = new System.Windows.Forms.TextBox();
            this.btnBrowseWatermark = new System.Windows.Forms.Button();
            this.picWatermark = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtXLocation = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtYLocation = new System.Windows.Forms.TextBox();
            this.btnAddWatermark = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lstInitialFiles = new System.Windows.Forms.CheckedListBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.grpTextWatermark = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbTextColor = new System.Windows.Forms.ComboBox();
            this.cmbTextSize = new System.Windows.Forms.ComboBox();
            this.cmbTextFont = new System.Windows.Forms.ComboBox();
            this.lblTextPreview = new System.Windows.Forms.Label();
            this.btnMosaicImg = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.grpImgWatermark = new System.Windows.Forms.GroupBox();
            this.cmbWatermarkType = new System.Windows.Forms.ComboBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.picFinalImgPreview = new System.Windows.Forms.PictureBox();
            this.lisFinalImages = new System.Windows.Forms.ListBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.picPreviewInitFile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWatermark)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.grpTextWatermark.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.grpImgWatermark.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFinalImgPreview)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "File";
            // 
            // txtBrowseFile
            // 
            this.txtBrowseFile.Location = new System.Drawing.Point(47, 18);
            this.txtBrowseFile.Name = "txtBrowseFile";
            this.txtBrowseFile.ReadOnly = true;
            this.txtBrowseFile.Size = new System.Drawing.Size(577, 20);
            this.txtBrowseFile.TabIndex = 1;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(630, 18);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 2;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Files";
            // 
            // picPreviewInitFile
            // 
            this.picPreviewInitFile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picPreviewInitFile.Location = new System.Drawing.Point(246, 70);
            this.picPreviewInitFile.Name = "picPreviewInitFile";
            this.picPreviewInitFile.Size = new System.Drawing.Size(459, 381);
            this.picPreviewInitFile.TabIndex = 5;
            this.picPreviewInitFile.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 14);
            this.label3.TabIndex = 6;
            this.label3.Text = "Watermark Type";
            // 
            // txtBrowseWatermark
            // 
            this.txtBrowseWatermark.Location = new System.Drawing.Point(15, 32);
            this.txtBrowseWatermark.Name = "txtBrowseWatermark";
            this.txtBrowseWatermark.ReadOnly = true;
            this.txtBrowseWatermark.Size = new System.Drawing.Size(494, 20);
            this.txtBrowseWatermark.TabIndex = 12;
            // 
            // btnBrowseWatermark
            // 
            this.btnBrowseWatermark.Location = new System.Drawing.Point(515, 30);
            this.btnBrowseWatermark.Name = "btnBrowseWatermark";
            this.btnBrowseWatermark.Size = new System.Drawing.Size(75, 23);
            this.btnBrowseWatermark.TabIndex = 13;
            this.btnBrowseWatermark.Text = "Browse";
            this.btnBrowseWatermark.UseVisualStyleBackColor = true;
            // 
            // picWatermark
            // 
            this.picWatermark.Location = new System.Drawing.Point(15, 58);
            this.picWatermark.Name = "picWatermark";
            this.picWatermark.Size = new System.Drawing.Size(206, 133);
            this.picWatermark.TabIndex = 14;
            this.picWatermark.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(43, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "X";
            // 
            // txtXLocation
            // 
            this.txtXLocation.Location = new System.Drawing.Point(63, 42);
            this.txtXLocation.Name = "txtXLocation";
            this.txtXLocation.Size = new System.Drawing.Size(100, 20);
            this.txtXLocation.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(217, 45);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(14, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Y";
            // 
            // txtYLocation
            // 
            this.txtYLocation.Location = new System.Drawing.Point(237, 42);
            this.txtYLocation.Name = "txtYLocation";
            this.txtYLocation.Size = new System.Drawing.Size(100, 20);
            this.txtYLocation.TabIndex = 20;
            // 
            // btnAddWatermark
            // 
            this.btnAddWatermark.Location = new System.Drawing.Point(601, 423);
            this.btnAddWatermark.Name = "btnAddWatermark";
            this.btnAddWatermark.Size = new System.Drawing.Size(93, 23);
            this.btnAddWatermark.TabIndex = 26;
            this.btnAddWatermark.Text = "Add Watermark";
            this.btnAddWatermark.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(719, 488);
            this.tabControl1.TabIndex = 27;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lstInitialFiles);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.txtBrowseFile);
            this.tabPage1.Controls.Add(this.btnBrowse);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.picPreviewInitFile);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(711, 462);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Select Files";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lstInitialFiles
            // 
            this.lstInitialFiles.FormattingEnabled = true;
            this.lstInitialFiles.Location = new System.Drawing.Point(9, 70);
            this.lstInitialFiles.Name = "lstInitialFiles";
            this.lstInitialFiles.Size = new System.Drawing.Size(231, 379);
            this.lstInitialFiles.TabIndex = 7;
            this.lstInitialFiles.SelectedIndexChanged += new System.EventHandler(this.lstInitialFiles_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(243, 54);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(45, 13);
            this.label11.TabIndex = 6;
            this.label11.Text = "Preview";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.grpTextWatermark);
            this.tabPage2.Controls.Add(this.btnMosaicImg);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Controls.Add(this.grpImgWatermark);
            this.tabPage2.Controls.Add(this.cmbWatermarkType);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.btnAddWatermark);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(711, 462);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Configuration";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // grpTextWatermark
            // 
            this.grpTextWatermark.Controls.Add(this.label8);
            this.grpTextWatermark.Controls.Add(this.label5);
            this.grpTextWatermark.Controls.Add(this.label4);
            this.grpTextWatermark.Controls.Add(this.cmbTextColor);
            this.grpTextWatermark.Controls.Add(this.cmbTextSize);
            this.grpTextWatermark.Controls.Add(this.cmbTextFont);
            this.grpTextWatermark.Controls.Add(this.lblTextPreview);
            this.grpTextWatermark.Location = new System.Drawing.Point(9, 185);
            this.grpTextWatermark.Name = "grpTextWatermark";
            this.grpTextWatermark.Size = new System.Drawing.Size(596, 191);
            this.grpTextWatermark.TabIndex = 28;
            this.grpTextWatermark.TabStop = false;
            this.grpTextWatermark.Text = "Settings";
            this.grpTextWatermark.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(392, 51);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 33;
            this.label8.Text = "Color";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 32;
            this.label5.Text = "Size";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 31;
            this.label4.Text = "Font";
            // 
            // cmbTextColor
            // 
            this.cmbTextColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTextColor.FormattingEnabled = true;
            this.cmbTextColor.Items.AddRange(new object[] {
            "Black",
            "White",
            "Red",
            "Blue",
            "Green",
            "Yellow"});
            this.cmbTextColor.Location = new System.Drawing.Point(469, 48);
            this.cmbTextColor.Name = "cmbTextColor";
            this.cmbTextColor.Size = new System.Drawing.Size(121, 21);
            this.cmbTextColor.TabIndex = 30;
            this.cmbTextColor.SelectedIndexChanged += new System.EventHandler(this.cmbTextColor_SelectedIndexChanged);
            // 
            // cmbTextSize
            // 
            this.cmbTextSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTextSize.FormattingEnabled = true;
            this.cmbTextSize.Items.AddRange(new object[] {
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20"});
            this.cmbTextSize.Location = new System.Drawing.Point(88, 45);
            this.cmbTextSize.Name = "cmbTextSize";
            this.cmbTextSize.Size = new System.Drawing.Size(121, 21);
            this.cmbTextSize.TabIndex = 29;
            this.cmbTextSize.SelectedIndexChanged += new System.EventHandler(this.cmbTextSize_SelectedIndexChanged);
            // 
            // cmbTextFont
            // 
            this.cmbTextFont.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTextFont.FormattingEnabled = true;
            this.cmbTextFont.Items.AddRange(new object[] {
            "Arial",
            "Calibri",
            "Cambria",
            "Microsoft Sans Serif",
            "Tahoma",
            "Times New Roman"});
            this.cmbTextFont.Location = new System.Drawing.Point(88, 18);
            this.cmbTextFont.Name = "cmbTextFont";
            this.cmbTextFont.Size = new System.Drawing.Size(502, 21);
            this.cmbTextFont.TabIndex = 28;
            this.cmbTextFont.SelectedIndexChanged += new System.EventHandler(this.cmbTextFont_SelectedIndexChanged);
            // 
            // lblTextPreview
            // 
            this.lblTextPreview.Location = new System.Drawing.Point(85, 90);
            this.lblTextPreview.Name = "lblTextPreview";
            this.lblTextPreview.Size = new System.Drawing.Size(505, 95);
            this.lblTextPreview.TabIndex = 12;
            this.lblTextPreview.Text = "PREVIEW";
            this.lblTextPreview.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnMosaicImg
            // 
            this.btnMosaicImg.Location = new System.Drawing.Point(497, 423);
            this.btnMosaicImg.Name = "btnMosaicImg";
            this.btnMosaicImg.Size = new System.Drawing.Size(93, 23);
            this.btnMosaicImg.TabIndex = 31;
            this.btnMosaicImg.Text = "Masaic Images";
            this.btnMosaicImg.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtXLocation);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.txtYLocation);
            this.groupBox3.Location = new System.Drawing.Point(98, 265);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(596, 111);
            this.groupBox3.TabIndex = 30;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Location";
            // 
            // grpImgWatermark
            // 
            this.grpImgWatermark.Controls.Add(this.txtBrowseWatermark);
            this.grpImgWatermark.Controls.Add(this.btnBrowseWatermark);
            this.grpImgWatermark.Controls.Add(this.picWatermark);
            this.grpImgWatermark.Location = new System.Drawing.Point(98, 50);
            this.grpImgWatermark.Name = "grpImgWatermark";
            this.grpImgWatermark.Size = new System.Drawing.Size(596, 191);
            this.grpImgWatermark.TabIndex = 29;
            this.grpImgWatermark.TabStop = false;
            this.grpImgWatermark.Text = "Settings";
            // 
            // cmbWatermarkType
            // 
            this.cmbWatermarkType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbWatermarkType.FormattingEnabled = true;
            this.cmbWatermarkType.Items.AddRange(new object[] {
            "Text",
            "Image"});
            this.cmbWatermarkType.Location = new System.Drawing.Point(98, 12);
            this.cmbWatermarkType.Name = "cmbWatermarkType";
            this.cmbWatermarkType.Size = new System.Drawing.Size(121, 21);
            this.cmbWatermarkType.TabIndex = 27;
            this.cmbWatermarkType.SelectedIndexChanged += new System.EventHandler(this.cmbWatermarkType_SelectedIndexChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.picFinalImgPreview);
            this.tabPage3.Controls.Add(this.lisFinalImages);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(711, 462);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Output";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // picFinalImgPreview
            // 
            this.picFinalImgPreview.Location = new System.Drawing.Point(280, 21);
            this.picFinalImgPreview.Name = "picFinalImgPreview";
            this.picFinalImgPreview.Size = new System.Drawing.Size(425, 423);
            this.picFinalImgPreview.TabIndex = 1;
            this.picFinalImgPreview.TabStop = false;
            // 
            // lisFinalImages
            // 
            this.lisFinalImages.FormattingEnabled = true;
            this.lisFinalImages.Location = new System.Drawing.Point(20, 21);
            this.lisFinalImages.Name = "lisFinalImages";
            this.lisFinalImages.Size = new System.Drawing.Size(254, 433);
            this.lisFinalImages.TabIndex = 0;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "JPEG Images|*.jpg|GIF Files|*.gif|PNG Files|*.png";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 513);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Watermark";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picPreviewInitFile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWatermark)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.grpTextWatermark.ResumeLayout(false);
            this.grpTextWatermark.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.grpImgWatermark.ResumeLayout(false);
            this.grpImgWatermark.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picFinalImgPreview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBrowseFile;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox picPreviewInitFile;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBrowseWatermark;
        private System.Windows.Forms.Button btnBrowseWatermark;
        private System.Windows.Forms.PictureBox picWatermark;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtXLocation;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtYLocation;
        private System.Windows.Forms.Button btnAddWatermark;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox grpImgWatermark;
        private System.Windows.Forms.GroupBox grpTextWatermark;
        private System.Windows.Forms.Label lblTextPreview;
        private System.Windows.Forms.ComboBox cmbWatermarkType;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.PictureBox picFinalImgPreview;
        private System.Windows.Forms.ListBox lisFinalImages;
        private System.Windows.Forms.CheckedListBox lstInitialFiles;
        private System.Windows.Forms.ComboBox cmbTextFont;
        private System.Windows.Forms.Button btnMosaicImg;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbTextColor;
        private System.Windows.Forms.ComboBox cmbTextSize;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

