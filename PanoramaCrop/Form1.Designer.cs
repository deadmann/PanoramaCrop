namespace PanoramaCrop
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.picturePreview = new System.Windows.Forms.PictureBox();
            this.chooseFile = new System.Windows.Forms.Button();
            this.chooseOutput = new System.Windows.Forms.Button();
            this.lblLoadedFilePath = new System.Windows.Forms.Label();
            this.lblExportPath = new System.Windows.Forms.Label();
            this.rbFindResolution = new System.Windows.Forms.RadioButton();
            this.rbFindNumber = new System.Windows.Forms.RadioButton();
            this.numHorSlide = new System.Windows.Forms.NumericUpDown();
            this.numVerSlide = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numWidth = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numHeight = new System.Windows.Forms.NumericUpDown();
            this.chkNoCrop = new System.Windows.Forms.CheckBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.txtPrefix = new System.Windows.Forms.TextBox();
            this.txtSuffix = new System.Windows.Forms.TextBox();
            this.btnExecute = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picturePreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHorSlide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numVerSlide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHeight)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // picturePreview
            // 
            this.picturePreview.Location = new System.Drawing.Point(15, 73);
            this.picturePreview.Name = "picturePreview";
            this.picturePreview.Size = new System.Drawing.Size(801, 348);
            this.picturePreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picturePreview.TabIndex = 0;
            this.picturePreview.TabStop = false;
            // 
            // chooseFile
            // 
            this.chooseFile.Location = new System.Drawing.Point(719, 12);
            this.chooseFile.Name = "chooseFile";
            this.chooseFile.Size = new System.Drawing.Size(97, 23);
            this.chooseFile.TabIndex = 1;
            this.chooseFile.Text = "Load File";
            this.chooseFile.UseVisualStyleBackColor = true;
            this.chooseFile.Click += new System.EventHandler(this.chooseFile_Click);
            // 
            // chooseOutput
            // 
            this.chooseOutput.Location = new System.Drawing.Point(719, 41);
            this.chooseOutput.Name = "chooseOutput";
            this.chooseOutput.Size = new System.Drawing.Size(97, 23);
            this.chooseOutput.TabIndex = 2;
            this.chooseOutput.Text = "Export Location";
            this.chooseOutput.UseVisualStyleBackColor = true;
            this.chooseOutput.Click += new System.EventHandler(this.chooseOutput_Click);
            // 
            // lblLoadedFilePath
            // 
            this.lblLoadedFilePath.AutoSize = true;
            this.lblLoadedFilePath.Location = new System.Drawing.Point(12, 17);
            this.lblLoadedFilePath.Name = "lblLoadedFilePath";
            this.lblLoadedFilePath.Size = new System.Drawing.Size(91, 13);
            this.lblLoadedFilePath.TabIndex = 3;
            this.lblLoadedFilePath.Text = "lblLoadedFilePath";
            // 
            // lblExportPath
            // 
            this.lblExportPath.AutoSize = true;
            this.lblExportPath.Location = new System.Drawing.Point(12, 46);
            this.lblExportPath.Name = "lblExportPath";
            this.lblExportPath.Size = new System.Drawing.Size(69, 13);
            this.lblExportPath.TabIndex = 4;
            this.lblExportPath.Text = "lblExportPath";
            // 
            // rbFindResolution
            // 
            this.rbFindResolution.AutoSize = true;
            this.rbFindResolution.Checked = true;
            this.rbFindResolution.Location = new System.Drawing.Point(15, 458);
            this.rbFindResolution.Name = "rbFindResolution";
            this.rbFindResolution.Size = new System.Drawing.Size(98, 17);
            this.rbFindResolution.TabIndex = 5;
            this.rbFindResolution.TabStop = true;
            this.rbFindResolution.Text = "Find Resolution";
            this.rbFindResolution.UseVisualStyleBackColor = true;
            this.rbFindResolution.CheckedChanged += new System.EventHandler(this.rbFindResolution_CheckedChanged);
            // 
            // rbFindNumber
            // 
            this.rbFindNumber.AutoSize = true;
            this.rbFindNumber.Location = new System.Drawing.Point(304, 458);
            this.rbFindNumber.Name = "rbFindNumber";
            this.rbFindNumber.Size = new System.Drawing.Size(85, 17);
            this.rbFindNumber.TabIndex = 6;
            this.rbFindNumber.Text = "Find Number";
            this.rbFindNumber.UseVisualStyleBackColor = true;
            this.rbFindNumber.CheckedChanged += new System.EventHandler(this.rbFindNumber_CheckedChanged);
            // 
            // numHorSlide
            // 
            this.numHorSlide.Location = new System.Drawing.Point(140, 458);
            this.numHorSlide.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numHorSlide.Name = "numHorSlide";
            this.numHorSlide.Size = new System.Drawing.Size(57, 20);
            this.numHorSlide.TabIndex = 7;
            this.numHorSlide.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // numVerSlide
            // 
            this.numVerSlide.Location = new System.Drawing.Point(223, 458);
            this.numVerSlide.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numVerSlide.Name = "numVerSlide";
            this.numVerSlide.Size = new System.Drawing.Size(57, 20);
            this.numVerSlide.TabIndex = 8;
            this.numVerSlide.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(119, 460);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "H";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(203, 460);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "V";
            // 
            // numWidth
            // 
            this.numWidth.Location = new System.Drawing.Point(436, 458);
            this.numWidth.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numWidth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numWidth.Name = "numWidth";
            this.numWidth.Size = new System.Drawing.Size(91, 20);
            this.numWidth.TabIndex = 11;
            this.numWidth.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(395, 460);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Width";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(533, 460);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Height";
            // 
            // numHeight
            // 
            this.numHeight.Location = new System.Drawing.Point(577, 458);
            this.numHeight.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numHeight.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numHeight.Name = "numHeight";
            this.numHeight.Size = new System.Drawing.Size(82, 20);
            this.numHeight.TabIndex = 14;
            this.numHeight.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // chkNoCrop
            // 
            this.chkNoCrop.AutoSize = true;
            this.chkNoCrop.Location = new System.Drawing.Point(673, 459);
            this.chkNoCrop.Name = "chkNoCrop";
            this.chkNoCrop.Size = new System.Drawing.Size(68, 17);
            this.chkNoCrop.TabIndex = 15;
            this.chkNoCrop.Text = "!No Crop";
            this.chkNoCrop.UseVisualStyleBackColor = true;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(741, 455);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 16;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // txtPrefix
            // 
            this.txtPrefix.Location = new System.Drawing.Point(567, 43);
            this.txtPrefix.Name = "txtPrefix";
            this.txtPrefix.Size = new System.Drawing.Size(70, 20);
            this.txtPrefix.TabIndex = 17;
            this.txtPrefix.TextChanged += new System.EventHandler(this.txtPrefix_TextChanged);
            // 
            // txtSuffix
            // 
            this.txtSuffix.Location = new System.Drawing.Point(643, 43);
            this.txtSuffix.Name = "txtSuffix";
            this.txtSuffix.Size = new System.Drawing.Size(70, 20);
            this.txtSuffix.TabIndex = 18;
            this.txtSuffix.TextChanged += new System.EventHandler(this.txtSuffix_TextChanged);
            // 
            // btnExecute
            // 
            this.btnExecute.Enabled = false;
            this.btnExecute.Location = new System.Drawing.Point(567, 12);
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Size = new System.Drawing.Size(146, 23);
            this.btnExecute.TabIndex = 19;
            this.btnExecute.Text = "Execute";
            this.btnExecute.UseVisualStyleBackColor = true;
            this.btnExecute.Click += new System.EventHandler(this.btnExecute_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 487);
            this.Controls.Add(this.btnExecute);
            this.Controls.Add(this.txtSuffix);
            this.Controls.Add(this.txtPrefix);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.chkNoCrop);
            this.Controls.Add(this.numHeight);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numWidth);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numVerSlide);
            this.Controls.Add(this.numHorSlide);
            this.Controls.Add(this.rbFindNumber);
            this.Controls.Add(this.rbFindResolution);
            this.Controls.Add(this.lblExportPath);
            this.Controls.Add(this.lblLoadedFilePath);
            this.Controls.Add(this.chooseOutput);
            this.Controls.Add(this.chooseFile);
            this.Controls.Add(this.picturePreview);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picturePreview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHorSlide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numVerSlide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHeight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox picturePreview;
        private System.Windows.Forms.Button chooseFile;
        private System.Windows.Forms.Button chooseOutput;
        private System.Windows.Forms.Label lblLoadedFilePath;
        private System.Windows.Forms.Label lblExportPath;
        private System.Windows.Forms.RadioButton rbFindResolution;
        private System.Windows.Forms.RadioButton rbFindNumber;
        private System.Windows.Forms.NumericUpDown numHorSlide;
        private System.Windows.Forms.NumericUpDown numVerSlide;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numWidth;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numHeight;
        private System.Windows.Forms.CheckBox chkNoCrop;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TextBox txtPrefix;
        private System.Windows.Forms.TextBox txtSuffix;
        private System.Windows.Forms.Button btnExecute;
    }
}

