
namespace minecraft_qr_generator_setting
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.OKButton = new System.Windows.Forms.Button();
            this.InputFilePathBox = new System.Windows.Forms.TextBox();
            this.InputFilePathLabel = new System.Windows.Forms.Label();
            this.OutputPathLabel = new System.Windows.Forms.Label();
            this.OutputPathBox = new System.Windows.Forms.TextBox();
            this.xLabel = new System.Windows.Forms.Label();
            this.xBox = new System.Windows.Forms.TextBox();
            this.yLabel = new System.Windows.Forms.Label();
            this.zLabel = new System.Windows.Forms.Label();
            this.yBox = new System.Windows.Forms.TextBox();
            this.zBox = new System.Windows.Forms.TextBox();
            this.modeBox = new System.Windows.Forms.TextBox();
            this.modeLabel = new System.Windows.Forms.Label();
            this.EditionLabel = new System.Windows.Forms.Label();
            this.EditionBox = new System.Windows.Forms.TextBox();
            this.CloseButton_Cancel = new System.Windows.Forms.Button();
            this.StatusBox = new System.Windows.Forms.TextBox();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.infoButton = new System.Windows.Forms.Button();
            this.info_EditionButton = new System.Windows.Forms.Button();
            this.AppFullPathBox = new System.Windows.Forms.TextBox();
            this.AppFullPathLabel = new System.Windows.Forms.Label();
            this.ResetButton = new System.Windows.Forms.Button();
            this.BlockIDBox = new System.Windows.Forms.TextBox();
            this.BlockIDLabel = new System.Windows.Forms.Label();
            this.BlockNameLabel = new System.Windows.Forms.Label();
            this.BlockNameBox = new System.Windows.Forms.TextBox();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.BackGroundBlockName = new System.Windows.Forms.Label();
            this.BackGroundBlockNameBox = new System.Windows.Forms.TextBox();
            this.BackGroundBlockID = new System.Windows.Forms.Label();
            this.BackGroundBlockIDBox = new System.Windows.Forms.TextBox();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.FileSaveButton = new System.Windows.Forms.Button();
            this.FileReferenceButton = new System.Windows.Forms.Button();
            this.ExeFileReferenceButton = new System.Windows.Forms.Button();
            this.QRStringLabel = new System.Windows.Forms.Label();
            this.QRStringBox = new System.Windows.Forms.TextBox();
            this.SaveQRButton = new System.Windows.Forms.Button();
            this.VersionLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // OKButton
            // 
            this.OKButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.OKButton.Location = new System.Drawing.Point(185, 458);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(187, 23);
            this.OKButton.TabIndex = 18;
            this.OKButton.Text = "保存して実行";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // InputFilePathBox
            // 
            this.InputFilePathBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InputFilePathBox.Location = new System.Drawing.Point(12, 194);
            this.InputFilePathBox.Name = "InputFilePathBox";
            this.InputFilePathBox.Size = new System.Drawing.Size(288, 23);
            this.InputFilePathBox.TabIndex = 6;
            this.InputFilePathBox.TextChanged += new System.EventHandler(this.InputFilePathBox_TextChanged);
            // 
            // InputFilePathLabel
            // 
            this.InputFilePathLabel.AutoSize = true;
            this.InputFilePathLabel.Location = new System.Drawing.Point(12, 176);
            this.InputFilePathLabel.Name = "InputFilePathLabel";
            this.InputFilePathLabel.Size = new System.Drawing.Size(155, 15);
            this.InputFilePathLabel.TabIndex = 4;
            this.InputFilePathLabel.Text = "InputFilePath(入力する画像):";
            // 
            // OutputPathLabel
            // 
            this.OutputPathLabel.AutoSize = true;
            this.OutputPathLabel.Location = new System.Drawing.Point(12, 224);
            this.OutputPathLabel.Name = "OutputPathLabel";
            this.OutputPathLabel.Size = new System.Drawing.Size(116, 15);
            this.OutputPathLabel.TabIndex = 5;
            this.OutputPathLabel.Text = "OutputPath(出力先):";
            // 
            // OutputPathBox
            // 
            this.OutputPathBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OutputPathBox.Location = new System.Drawing.Point(12, 242);
            this.OutputPathBox.Name = "OutputPathBox";
            this.OutputPathBox.Size = new System.Drawing.Size(288, 23);
            this.OutputPathBox.TabIndex = 8;
            this.OutputPathBox.Text = "例:C:\\Users\\ユーザー名\\Documents\\output\\output.txt";
            // 
            // xLabel
            // 
            this.xLabel.AutoSize = true;
            this.xLabel.Location = new System.Drawing.Point(12, 272);
            this.xLabel.Name = "xLabel";
            this.xLabel.Size = new System.Drawing.Size(16, 15);
            this.xLabel.TabIndex = 7;
            this.xLabel.Text = "x:";
            // 
            // xBox
            // 
            this.xBox.Location = new System.Drawing.Point(34, 269);
            this.xBox.Name = "xBox";
            this.xBox.Size = new System.Drawing.Size(91, 23);
            this.xBox.TabIndex = 10;
            this.xBox.Text = "0";
            // 
            // yLabel
            // 
            this.yLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.yLabel.AutoSize = true;
            this.yLabel.Location = new System.Drawing.Point(131, 272);
            this.yLabel.Name = "yLabel";
            this.yLabel.Size = new System.Drawing.Size(16, 15);
            this.yLabel.TabIndex = 9;
            this.yLabel.Text = "y:";
            // 
            // zLabel
            // 
            this.zLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.zLabel.AutoSize = true;
            this.zLabel.Location = new System.Drawing.Point(253, 272);
            this.zLabel.Name = "zLabel";
            this.zLabel.Size = new System.Drawing.Size(15, 15);
            this.zLabel.TabIndex = 10;
            this.zLabel.Text = "z:";
            // 
            // yBox
            // 
            this.yBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.yBox.Location = new System.Drawing.Point(153, 269);
            this.yBox.Name = "yBox";
            this.yBox.Size = new System.Drawing.Size(94, 23);
            this.yBox.TabIndex = 11;
            this.yBox.Text = "4";
            // 
            // zBox
            // 
            this.zBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.zBox.Location = new System.Drawing.Point(274, 269);
            this.zBox.Name = "zBox";
            this.zBox.Size = new System.Drawing.Size(98, 23);
            this.zBox.TabIndex = 12;
            this.zBox.Text = "0";
            // 
            // modeBox
            // 
            this.modeBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.modeBox.Location = new System.Drawing.Point(12, 317);
            this.modeBox.Name = "modeBox";
            this.modeBox.Size = new System.Drawing.Size(360, 23);
            this.modeBox.TabIndex = 13;
            this.modeBox.Text = "0";
            // 
            // modeLabel
            // 
            this.modeLabel.AutoSize = true;
            this.modeLabel.Location = new System.Drawing.Point(12, 296);
            this.modeLabel.Name = "modeLabel";
            this.modeLabel.Size = new System.Drawing.Size(41, 15);
            this.modeLabel.TabIndex = 14;
            this.modeLabel.Text = "Mode:";
            // 
            // EditionLabel
            // 
            this.EditionLabel.AutoSize = true;
            this.EditionLabel.Location = new System.Drawing.Point(12, 350);
            this.EditionLabel.Name = "EditionLabel";
            this.EditionLabel.Size = new System.Drawing.Size(47, 15);
            this.EditionLabel.TabIndex = 15;
            this.EditionLabel.Text = "Edition:";
            // 
            // EditionBox
            // 
            this.EditionBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EditionBox.Location = new System.Drawing.Point(12, 368);
            this.EditionBox.Name = "EditionBox";
            this.EditionBox.Size = new System.Drawing.Size(360, 23);
            this.EditionBox.TabIndex = 14;
            this.EditionBox.Text = "1";
            // 
            // CloseButton_Cancel
            // 
            this.CloseButton_Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CloseButton_Cancel.Location = new System.Drawing.Point(12, 458);
            this.CloseButton_Cancel.Name = "CloseButton_Cancel";
            this.CloseButton_Cancel.Size = new System.Drawing.Size(167, 23);
            this.CloseButton_Cancel.TabIndex = 17;
            this.CloseButton_Cancel.Text = "キャンセル";
            this.CloseButton_Cancel.UseVisualStyleBackColor = true;
            this.CloseButton_Cancel.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // StatusBox
            // 
            this.StatusBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.StatusBox.Enabled = false;
            this.StatusBox.Location = new System.Drawing.Point(0, 504);
            this.StatusBox.Multiline = true;
            this.StatusBox.Name = "StatusBox";
            this.StatusBox.ReadOnly = true;
            this.StatusBox.Size = new System.Drawing.Size(384, 48);
            this.StatusBox.TabIndex = 22;
            this.StatusBox.TabStop = false;
            // 
            // StatusLabel
            // 
            this.StatusLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Location = new System.Drawing.Point(12, 484);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(54, 15);
            this.StatusLabel.TabIndex = 21;
            this.StatusLabel.Text = "ステータス:";
            // 
            // infoButton
            // 
            this.infoButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.infoButton.Font = new System.Drawing.Font("Yu Gothic UI", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.infoButton.Location = new System.Drawing.Point(65, 295);
            this.infoButton.Name = "infoButton";
            this.infoButton.Size = new System.Drawing.Size(19, 19);
            this.infoButton.TabIndex = 20;
            this.infoButton.TabStop = false;
            this.infoButton.Text = "?";
            this.infoButton.UseVisualStyleBackColor = true;
            this.infoButton.Click += new System.EventHandler(this.infoButton_Click);
            // 
            // info_EditionButton
            // 
            this.info_EditionButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.info_EditionButton.Font = new System.Drawing.Font("Yu Gothic UI", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.info_EditionButton.Location = new System.Drawing.Point(65, 346);
            this.info_EditionButton.Name = "info_EditionButton";
            this.info_EditionButton.Size = new System.Drawing.Size(19, 19);
            this.info_EditionButton.TabIndex = 21;
            this.info_EditionButton.TabStop = false;
            this.info_EditionButton.Text = "?";
            this.info_EditionButton.UseVisualStyleBackColor = true;
            this.info_EditionButton.Click += new System.EventHandler(this.info_EditionButton_Click);
            // 
            // AppFullPathBox
            // 
            this.AppFullPathBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AppFullPathBox.Location = new System.Drawing.Point(182, 397);
            this.AppFullPathBox.Name = "AppFullPathBox";
            this.AppFullPathBox.Size = new System.Drawing.Size(118, 23);
            this.AppFullPathBox.TabIndex = 15;
            this.AppFullPathBox.Text = "C:\\Program Files (x86)\\Columba_Karasu\\Minecraft QR Genererator\\minecraft_qr_gener" +
    "ator.exe";
            // 
            // AppFullPathLabel
            // 
            this.AppFullPathLabel.AutoSize = true;
            this.AppFullPathLabel.Location = new System.Drawing.Point(12, 401);
            this.AppFullPathLabel.Name = "AppFullPathLabel";
            this.AppFullPathLabel.Size = new System.Drawing.Size(164, 15);
            this.AppFullPathLabel.TabIndex = 25;
            this.AppFullPathLabel.Text = "Minecraft QR Generatorのパス:";
            // 
            // ResetButton
            // 
            this.ResetButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ResetButton.FlatAppearance.BorderSize = 0;
            this.ResetButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.ResetButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.ResetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ResetButton.Location = new System.Drawing.Point(320, 12);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(52, 45);
            this.ResetButton.TabIndex = 19;
            this.ResetButton.Text = "リセット";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // BlockIDBox
            // 
            this.BlockIDBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BlockIDBox.Location = new System.Drawing.Point(315, 121);
            this.BlockIDBox.Name = "BlockIDBox";
            this.BlockIDBox.Size = new System.Drawing.Size(57, 23);
            this.BlockIDBox.TabIndex = 4;
            this.BlockIDBox.Text = "15";
            // 
            // BlockIDLabel
            // 
            this.BlockIDLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BlockIDLabel.AutoSize = true;
            this.BlockIDLabel.Location = new System.Drawing.Point(254, 124);
            this.BlockIDLabel.Name = "BlockIDLabel";
            this.BlockIDLabel.Size = new System.Drawing.Size(59, 15);
            this.BlockIDLabel.TabIndex = 27;
            this.BlockIDLabel.Text = " ブロックID:";
            // 
            // BlockNameLabel
            // 
            this.BlockNameLabel.AutoSize = true;
            this.BlockNameLabel.Location = new System.Drawing.Point(46, 124);
            this.BlockNameLabel.Name = "BlockNameLabel";
            this.BlockNameLabel.Size = new System.Drawing.Size(57, 15);
            this.BlockNameLabel.TabIndex = 28;
            this.BlockNameLabel.Text = "ブロック名:";
            // 
            // BlockNameBox
            // 
            this.BlockNameBox.Location = new System.Drawing.Point(109, 121);
            this.BlockNameBox.Name = "BlockNameBox";
            this.BlockNameBox.Size = new System.Drawing.Size(142, 23);
            this.BlockNameBox.TabIndex = 2;
            this.BlockNameBox.Text = "concrete";
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Location = new System.Drawing.Point(12, 9);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(31, 15);
            this.TitleLabel.TabIndex = 30;
            this.TitleLabel.Text = "設定";
            // 
            // BackGroundBlockName
            // 
            this.BackGroundBlockName.AutoSize = true;
            this.BackGroundBlockName.Location = new System.Drawing.Point(12, 153);
            this.BackGroundBlockName.Name = "BackGroundBlockName";
            this.BackGroundBlockName.Size = new System.Drawing.Size(91, 15);
            this.BackGroundBlockName.TabIndex = 31;
            this.BackGroundBlockName.Text = "背景のブロック名:";
            // 
            // BackGroundBlockNameBox
            // 
            this.BackGroundBlockNameBox.Location = new System.Drawing.Point(109, 150);
            this.BackGroundBlockNameBox.Name = "BackGroundBlockNameBox";
            this.BackGroundBlockNameBox.Size = new System.Drawing.Size(142, 23);
            this.BackGroundBlockNameBox.TabIndex = 3;
            this.BackGroundBlockNameBox.Text = "concrete";
            // 
            // BackGroundBlockID
            // 
            this.BackGroundBlockID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BackGroundBlockID.AutoSize = true;
            this.BackGroundBlockID.Location = new System.Drawing.Point(257, 153);
            this.BackGroundBlockID.Name = "BackGroundBlockID";
            this.BackGroundBlockID.Size = new System.Drawing.Size(56, 15);
            this.BackGroundBlockID.TabIndex = 33;
            this.BackGroundBlockID.Text = "ブロックID:";
            // 
            // BackGroundBlockIDBox
            // 
            this.BackGroundBlockIDBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BackGroundBlockIDBox.Location = new System.Drawing.Point(315, 150);
            this.BackGroundBlockIDBox.Name = "BackGroundBlockIDBox";
            this.BackGroundBlockIDBox.Size = new System.Drawing.Size(57, 23);
            this.BackGroundBlockIDBox.TabIndex = 5;
            this.BackGroundBlockIDBox.Text = "0";
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.AutoEllipsis = true;
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.Font = new System.Drawing.Font("Yu Gothic UI", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DescriptionLabel.Location = new System.Drawing.Point(12, 30);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(47, 11);
            this.DescriptionLabel.TabIndex = 35;
            this.DescriptionLabel.Text = "Description";
            // 
            // FileSaveButton
            // 
            this.FileSaveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FileSaveButton.Location = new System.Drawing.Point(306, 242);
            this.FileSaveButton.Name = "FileSaveButton";
            this.FileSaveButton.Size = new System.Drawing.Size(66, 23);
            this.FileSaveButton.TabIndex = 9;
            this.FileSaveButton.Text = "参照";
            this.FileSaveButton.UseVisualStyleBackColor = true;
            this.FileSaveButton.Click += new System.EventHandler(this.FileSaveButton_Click);
            // 
            // FileReferenceButton
            // 
            this.FileReferenceButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FileReferenceButton.Location = new System.Drawing.Point(306, 194);
            this.FileReferenceButton.Name = "FileReferenceButton";
            this.FileReferenceButton.Size = new System.Drawing.Size(66, 23);
            this.FileReferenceButton.TabIndex = 7;
            this.FileReferenceButton.Text = "参照";
            this.FileReferenceButton.UseVisualStyleBackColor = true;
            this.FileReferenceButton.Click += new System.EventHandler(this.FileReferenceButton_Click);
            // 
            // ExeFileReferenceButton
            // 
            this.ExeFileReferenceButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ExeFileReferenceButton.Location = new System.Drawing.Point(306, 397);
            this.ExeFileReferenceButton.Name = "ExeFileReferenceButton";
            this.ExeFileReferenceButton.Size = new System.Drawing.Size(66, 23);
            this.ExeFileReferenceButton.TabIndex = 16;
            this.ExeFileReferenceButton.Text = "参照";
            this.ExeFileReferenceButton.UseVisualStyleBackColor = true;
            this.ExeFileReferenceButton.Click += new System.EventHandler(this.ExeFileReferenceButton_Click);
            // 
            // QRStringLabel
            // 
            this.QRStringLabel.AutoSize = true;
            this.QRStringLabel.Location = new System.Drawing.Point(12, 74);
            this.QRStringLabel.Name = "QRStringLabel";
            this.QRStringLabel.Size = new System.Drawing.Size(93, 15);
            this.QRStringLabel.TabIndex = 39;
            this.QRStringLabel.Text = "QRコードの文字列";
            // 
            // QRStringBox
            // 
            this.QRStringBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.QRStringBox.Location = new System.Drawing.Point(12, 92);
            this.QRStringBox.Name = "QRStringBox";
            this.QRStringBox.Size = new System.Drawing.Size(288, 23);
            this.QRStringBox.TabIndex = 0;
            this.QRStringBox.TextChanged += new System.EventHandler(this.QRStringBox_TextChanged);
            // 
            // SaveQRButton
            // 
            this.SaveQRButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveQRButton.Enabled = false;
            this.SaveQRButton.Location = new System.Drawing.Point(306, 92);
            this.SaveQRButton.Name = "SaveQRButton";
            this.SaveQRButton.Size = new System.Drawing.Size(66, 23);
            this.SaveQRButton.TabIndex = 1;
            this.SaveQRButton.Text = "保存";
            this.SaveQRButton.UseVisualStyleBackColor = true;
            this.SaveQRButton.Click += new System.EventHandler(this.SaveQRButton_Click);
            // 
            // VersionLabel
            // 
            this.VersionLabel.AutoSize = true;
            this.VersionLabel.Location = new System.Drawing.Point(12, 429);
            this.VersionLabel.Name = "VersionLabel";
            this.VersionLabel.Size = new System.Drawing.Size(25, 15);
            this.VersionLabel.TabIndex = 40;
            this.VersionLabel.Text = "Ver.";
            // 
            // Form1
            // 
            this.AcceptButton = this.OKButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CloseButton_Cancel;
            this.ClientSize = new System.Drawing.Size(384, 552);
            this.Controls.Add(this.VersionLabel);
            this.Controls.Add(this.SaveQRButton);
            this.Controls.Add(this.QRStringBox);
            this.Controls.Add(this.QRStringLabel);
            this.Controls.Add(this.ExeFileReferenceButton);
            this.Controls.Add(this.FileReferenceButton);
            this.Controls.Add(this.FileSaveButton);
            this.Controls.Add(this.DescriptionLabel);
            this.Controls.Add(this.BackGroundBlockIDBox);
            this.Controls.Add(this.BackGroundBlockNameBox);
            this.Controls.Add(this.BackGroundBlockName);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.BlockNameBox);
            this.Controls.Add(this.BlockNameLabel);
            this.Controls.Add(this.BlockIDBox);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.AppFullPathLabel);
            this.Controls.Add(this.info_EditionButton);
            this.Controls.Add(this.infoButton);
            this.Controls.Add(this.StatusLabel);
            this.Controls.Add(this.StatusBox);
            this.Controls.Add(this.CloseButton_Cancel);
            this.Controls.Add(this.EditionBox);
            this.Controls.Add(this.EditionLabel);
            this.Controls.Add(this.modeLabel);
            this.Controls.Add(this.modeBox);
            this.Controls.Add(this.yLabel);
            this.Controls.Add(this.xBox);
            this.Controls.Add(this.xLabel);
            this.Controls.Add(this.OutputPathBox);
            this.Controls.Add(this.OutputPathLabel);
            this.Controls.Add(this.InputFilePathLabel);
            this.Controls.Add(this.InputFilePathBox);
            this.Controls.Add(this.BlockIDLabel);
            this.Controls.Add(this.BackGroundBlockID);
            this.Controls.Add(this.zLabel);
            this.Controls.Add(this.zBox);
            this.Controls.Add(this.yBox);
            this.Controls.Add(this.AppFullPathBox);
            this.Controls.Add(this.OKButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(400, 591);
            this.Name = "Form1";
            this.Text = "設定";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AppExit);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.TextBox InputFilePathBox;
        private System.Windows.Forms.Label InputFilePathLabel;
        private System.Windows.Forms.Label OutputPathLabel;
        private System.Windows.Forms.TextBox OutputPathBox;
        private System.Windows.Forms.Label xLabel;
        private System.Windows.Forms.TextBox xBox;
        private System.Windows.Forms.Label yLabel;
        private System.Windows.Forms.Label zLabel;
        private System.Windows.Forms.TextBox yBox;
        private System.Windows.Forms.TextBox zBox;
        private System.Windows.Forms.TextBox modeBox;
        private System.Windows.Forms.Label modeLabel;
        private System.Windows.Forms.Label EditionLabel;
        private System.Windows.Forms.TextBox EditionBox;
        private System.Windows.Forms.Button CloseButton_Cancel;
        private System.Windows.Forms.TextBox StatusBox;
        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.Button infoButton;
        private System.Windows.Forms.Button info_EditionButton;
        private System.Windows.Forms.TextBox AppFullPathBox;
        private System.Windows.Forms.Label AppFullPathLabel;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.TextBox BlockIDBox;
        private System.Windows.Forms.Label BlockIDLabel;
        private System.Windows.Forms.Label BlockNameLabel;
        private System.Windows.Forms.TextBox BlockNameBox;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label BackGroundBlockName;
        private System.Windows.Forms.TextBox BackGroundBlockNameBox;
        private System.Windows.Forms.Label BackGroundBlockID;
        private System.Windows.Forms.TextBox BackGroundBlockIDBox;
        private System.Windows.Forms.Label DescriptionLabel;
        private System.Windows.Forms.Button FileSaveButton;
        private System.Windows.Forms.Button FileReferenceButton;
        private System.Windows.Forms.Button ExeFileReferenceButton;
        private System.Windows.Forms.Label QRStringLabel;
        private System.Windows.Forms.TextBox QRStringBox;
        private System.Windows.Forms.Button SaveQRButton;
        private System.Windows.Forms.Label VersionLabel;
    }
}

