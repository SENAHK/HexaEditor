namespace HexaEditor
{
    partial class ViewHexaEditor
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.pbxOutput = new System.Windows.Forms.PictureBox();
            this.pbxAscii = new System.Windows.Forms.PictureBox();
            this.lblHexa = new System.Windows.Forms.Label();
            this.lblAscii = new System.Windows.Forms.Label();
            this.tbcData = new System.Windows.Forms.TabControl();
            this.tbDetails = new System.Windows.Forms.TabPage();
            this.lblFileLastAccess = new System.Windows.Forms.Label();
            this.lblModificationDate = new System.Windows.Forms.Label();
            this.lblCreationDate = new System.Windows.Forms.Label();
            this.lblFileSize = new System.Windows.Forms.Label();
            this.lblFileName = new System.Windows.Forms.Label();
            this.lblTitleLastAccess = new System.Windows.Forms.Label();
            this.lblTitleModDate = new System.Windows.Forms.Label();
            this.lblTitleCreationDate = new System.Windows.Forms.Label();
            this.lblTitleSize = new System.Windows.Forms.Label();
            this.lblTitleName = new System.Windows.Forms.Label();
            this.tbDataReader = new System.Windows.Forms.TabPage();
            this.lblTitleDouble = new System.Windows.Forms.Label();
            this.lblDouble = new System.Windows.Forms.Label();
            this.lblTitleFloat = new System.Windows.Forms.Label();
            this.lblFloat = new System.Windows.Forms.Label();
            this.lbl64 = new System.Windows.Forms.Label();
            this.lblTitleLong = new System.Windows.Forms.Label();
            this.lblTitleUint32 = new System.Windows.Forms.Label();
            this.lbl32ns = new System.Windows.Forms.Label();
            this.lbl32s = new System.Windows.Forms.Label();
            this.lblTitleInt32 = new System.Windows.Forms.Label();
            this.lblTitleUint16 = new System.Windows.Forms.Label();
            this.lbl16ns = new System.Windows.Forms.Label();
            this.lbl16s = new System.Windows.Forms.Label();
            this.lblTitleInt16 = new System.Windows.Forms.Label();
            this.lblTitleSByte = new System.Windows.Forms.Label();
            this.lbl8ns = new System.Windows.Forms.Label();
            this.lbl8s = new System.Windows.Forms.Label();
            this.lblOctal = new System.Windows.Forms.Label();
            this.lblBin = new System.Windows.Forms.Label();
            this.lblChar = new System.Windows.Forms.Label();
            this.lblTitbleByte = new System.Windows.Forms.Label();
            this.lblTitleOctal = new System.Windows.Forms.Label();
            this.LblTitleBinary = new System.Windows.Forms.Label();
            this.lblTitleChar = new System.Windows.Forms.Label();
            this.msMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSave = new System.Windows.Forms.ToolStripMenuItem();
            this.ofdOpenFile = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pbxOutput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAscii)).BeginInit();
            this.tbcData.SuspendLayout();
            this.tbDetails.SuspendLayout();
            this.tbDataReader.SuspendLayout();
            this.msMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbxOutput
            // 
            this.pbxOutput.BackColor = System.Drawing.Color.White;
            this.pbxOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbxOutput.Location = new System.Drawing.Point(259, 44);
            this.pbxOutput.Name = "pbxOutput";
            this.pbxOutput.Size = new System.Drawing.Size(463, 435);
            this.pbxOutput.TabIndex = 0;
            this.pbxOutput.TabStop = false;
            this.pbxOutput.Click += new System.EventHandler(this.pbxOutput_Click);
            this.pbxOutput.Paint += new System.Windows.Forms.PaintEventHandler(this.pbxOutput_Paint);
            // 
            // pbxAscii
            // 
            this.pbxAscii.BackColor = System.Drawing.Color.White;
            this.pbxAscii.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbxAscii.Location = new System.Drawing.Point(733, 44);
            this.pbxAscii.Name = "pbxAscii";
            this.pbxAscii.Size = new System.Drawing.Size(313, 435);
            this.pbxAscii.TabIndex = 1;
            this.pbxAscii.TabStop = false;
            this.pbxAscii.Click += new System.EventHandler(this.pbxAscii_Click);
            this.pbxAscii.Paint += new System.Windows.Forms.PaintEventHandler(this.pbxAscii_Paint);
            // 
            // lblHexa
            // 
            this.lblHexa.AutoSize = true;
            this.lblHexa.Location = new System.Drawing.Point(256, 29);
            this.lblHexa.Name = "lblHexa";
            this.lblHexa.Size = new System.Drawing.Size(102, 13);
            this.lblHexa.TabIndex = 0;
            this.lblHexa.Text = "Hexadecimal values";
            // 
            // lblAscii
            // 
            this.lblAscii.AutoSize = true;
            this.lblAscii.Location = new System.Drawing.Point(730, 28);
            this.lblAscii.Name = "lblAscii";
            this.lblAscii.Size = new System.Drawing.Size(68, 13);
            this.lblAscii.TabIndex = 4;
            this.lblAscii.Text = "ASCII values";
            // 
            // tbcData
            // 
            this.tbcData.Controls.Add(this.tbDetails);
            this.tbcData.Controls.Add(this.tbDataReader);
            this.tbcData.Location = new System.Drawing.Point(12, 44);
            this.tbcData.Name = "tbcData";
            this.tbcData.SelectedIndex = 0;
            this.tbcData.Size = new System.Drawing.Size(241, 435);
            this.tbcData.TabIndex = 9999;
            this.tbcData.TabStop = false;
            this.tbcData.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbcData_KeyDown);
            this.tbcData.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbcData_KeyPress);
            // 
            // tbDetails
            // 
            this.tbDetails.Controls.Add(this.lblFileLastAccess);
            this.tbDetails.Controls.Add(this.lblModificationDate);
            this.tbDetails.Controls.Add(this.lblCreationDate);
            this.tbDetails.Controls.Add(this.lblFileSize);
            this.tbDetails.Controls.Add(this.lblFileName);
            this.tbDetails.Controls.Add(this.lblTitleLastAccess);
            this.tbDetails.Controls.Add(this.lblTitleModDate);
            this.tbDetails.Controls.Add(this.lblTitleCreationDate);
            this.tbDetails.Controls.Add(this.lblTitleSize);
            this.tbDetails.Controls.Add(this.lblTitleName);
            this.tbDetails.Location = new System.Drawing.Point(4, 22);
            this.tbDetails.Name = "tbDetails";
            this.tbDetails.Padding = new System.Windows.Forms.Padding(3);
            this.tbDetails.Size = new System.Drawing.Size(233, 409);
            this.tbDetails.TabIndex = 0;
            this.tbDetails.Text = "File";
            this.tbDetails.UseVisualStyleBackColor = true;
            // 
            // lblFileLastAccess
            // 
            this.lblFileLastAccess.AutoSize = true;
            this.lblFileLastAccess.Location = new System.Drawing.Point(105, 173);
            this.lblFileLastAccess.Name = "lblFileLastAccess";
            this.lblFileLastAccess.Size = new System.Drawing.Size(10, 13);
            this.lblFileLastAccess.TabIndex = 9;
            this.lblFileLastAccess.Text = "-";
            // 
            // lblModificationDate
            // 
            this.lblModificationDate.AutoSize = true;
            this.lblModificationDate.Location = new System.Drawing.Point(105, 134);
            this.lblModificationDate.Name = "lblModificationDate";
            this.lblModificationDate.Size = new System.Drawing.Size(10, 13);
            this.lblModificationDate.TabIndex = 8;
            this.lblModificationDate.Text = "-";
            // 
            // lblCreationDate
            // 
            this.lblCreationDate.AutoSize = true;
            this.lblCreationDate.Location = new System.Drawing.Point(105, 95);
            this.lblCreationDate.Name = "lblCreationDate";
            this.lblCreationDate.Size = new System.Drawing.Size(10, 13);
            this.lblCreationDate.TabIndex = 7;
            this.lblCreationDate.Text = "-";
            // 
            // lblFileSize
            // 
            this.lblFileSize.AutoSize = true;
            this.lblFileSize.Location = new System.Drawing.Point(105, 56);
            this.lblFileSize.Name = "lblFileSize";
            this.lblFileSize.Size = new System.Drawing.Size(10, 13);
            this.lblFileSize.TabIndex = 6;
            this.lblFileSize.Text = "-";
            // 
            // lblFileName
            // 
            this.lblFileName.AutoSize = true;
            this.lblFileName.Location = new System.Drawing.Point(105, 17);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(10, 13);
            this.lblFileName.TabIndex = 5;
            this.lblFileName.Text = "-";
            // 
            // lblTitleLastAccess
            // 
            this.lblTitleLastAccess.AutoSize = true;
            this.lblTitleLastAccess.Location = new System.Drawing.Point(0, 173);
            this.lblTitleLastAccess.Name = "lblTitleLastAccess";
            this.lblTitleLastAccess.Size = new System.Drawing.Size(70, 13);
            this.lblTitleLastAccess.TabIndex = 4;
            this.lblTitleLastAccess.Text = "Last access :";
            // 
            // lblTitleModDate
            // 
            this.lblTitleModDate.AutoSize = true;
            this.lblTitleModDate.Location = new System.Drawing.Point(0, 134);
            this.lblTitleModDate.Name = "lblTitleModDate";
            this.lblTitleModDate.Size = new System.Drawing.Size(94, 13);
            this.lblTitleModDate.TabIndex = 3;
            this.lblTitleModDate.Text = "Modification date :";
            // 
            // lblTitleCreationDate
            // 
            this.lblTitleCreationDate.AutoSize = true;
            this.lblTitleCreationDate.Location = new System.Drawing.Point(0, 95);
            this.lblTitleCreationDate.Name = "lblTitleCreationDate";
            this.lblTitleCreationDate.Size = new System.Drawing.Size(76, 13);
            this.lblTitleCreationDate.TabIndex = 2;
            this.lblTitleCreationDate.Text = "Creation date :";
            // 
            // lblTitleSize
            // 
            this.lblTitleSize.AutoSize = true;
            this.lblTitleSize.Location = new System.Drawing.Point(0, 56);
            this.lblTitleSize.Name = "lblTitleSize";
            this.lblTitleSize.Size = new System.Drawing.Size(33, 13);
            this.lblTitleSize.TabIndex = 1;
            this.lblTitleSize.Text = "Size :";
            // 
            // lblTitleName
            // 
            this.lblTitleName.AutoSize = true;
            this.lblTitleName.Location = new System.Drawing.Point(0, 17);
            this.lblTitleName.Name = "lblTitleName";
            this.lblTitleName.Size = new System.Drawing.Size(41, 13);
            this.lblTitleName.TabIndex = 0;
            this.lblTitleName.Text = "Name :";
            // 
            // tbDataReader
            // 
            this.tbDataReader.Controls.Add(this.lblTitleDouble);
            this.tbDataReader.Controls.Add(this.lblDouble);
            this.tbDataReader.Controls.Add(this.lblTitleFloat);
            this.tbDataReader.Controls.Add(this.lblFloat);
            this.tbDataReader.Controls.Add(this.lbl64);
            this.tbDataReader.Controls.Add(this.lblTitleLong);
            this.tbDataReader.Controls.Add(this.lblTitleUint32);
            this.tbDataReader.Controls.Add(this.lbl32ns);
            this.tbDataReader.Controls.Add(this.lbl32s);
            this.tbDataReader.Controls.Add(this.lblTitleInt32);
            this.tbDataReader.Controls.Add(this.lblTitleUint16);
            this.tbDataReader.Controls.Add(this.lbl16ns);
            this.tbDataReader.Controls.Add(this.lbl16s);
            this.tbDataReader.Controls.Add(this.lblTitleInt16);
            this.tbDataReader.Controls.Add(this.lblTitleSByte);
            this.tbDataReader.Controls.Add(this.lbl8ns);
            this.tbDataReader.Controls.Add(this.lbl8s);
            this.tbDataReader.Controls.Add(this.lblOctal);
            this.tbDataReader.Controls.Add(this.lblBin);
            this.tbDataReader.Controls.Add(this.lblChar);
            this.tbDataReader.Controls.Add(this.lblTitbleByte);
            this.tbDataReader.Controls.Add(this.lblTitleOctal);
            this.tbDataReader.Controls.Add(this.LblTitleBinary);
            this.tbDataReader.Controls.Add(this.lblTitleChar);
            this.tbDataReader.Location = new System.Drawing.Point(4, 22);
            this.tbDataReader.Name = "tbDataReader";
            this.tbDataReader.Padding = new System.Windows.Forms.Padding(3);
            this.tbDataReader.Size = new System.Drawing.Size(233, 409);
            this.tbDataReader.TabIndex = 1;
            this.tbDataReader.Text = "Data";
            this.tbDataReader.UseVisualStyleBackColor = true;
            // 
            // lblTitleDouble
            // 
            this.lblTitleDouble.AutoSize = true;
            this.lblTitleDouble.Location = new System.Drawing.Point(6, 342);
            this.lblTitleDouble.Name = "lblTitleDouble";
            this.lblTitleDouble.Size = new System.Drawing.Size(47, 13);
            this.lblTitleDouble.TabIndex = 34;
            this.lblTitleDouble.Text = "Double :";
            // 
            // lblDouble
            // 
            this.lblDouble.AutoSize = true;
            this.lblDouble.Location = new System.Drawing.Point(76, 342);
            this.lblDouble.Name = "lblDouble";
            this.lblDouble.Size = new System.Drawing.Size(10, 13);
            this.lblDouble.TabIndex = 33;
            this.lblDouble.Text = "-";
            // 
            // lblTitleFloat
            // 
            this.lblTitleFloat.AutoSize = true;
            this.lblTitleFloat.Location = new System.Drawing.Point(6, 312);
            this.lblTitleFloat.Name = "lblTitleFloat";
            this.lblTitleFloat.Size = new System.Drawing.Size(36, 13);
            this.lblTitleFloat.TabIndex = 32;
            this.lblTitleFloat.Text = "Float :";
            // 
            // lblFloat
            // 
            this.lblFloat.AutoSize = true;
            this.lblFloat.Location = new System.Drawing.Point(76, 312);
            this.lblFloat.Name = "lblFloat";
            this.lblFloat.Size = new System.Drawing.Size(10, 13);
            this.lblFloat.TabIndex = 31;
            this.lblFloat.Text = "-";
            // 
            // lbl64
            // 
            this.lbl64.AutoSize = true;
            this.lbl64.Location = new System.Drawing.Point(76, 282);
            this.lbl64.Name = "lbl64";
            this.lbl64.Size = new System.Drawing.Size(10, 13);
            this.lbl64.TabIndex = 30;
            this.lbl64.Text = "-";
            // 
            // lblTitleLong
            // 
            this.lblTitleLong.AutoSize = true;
            this.lblTitleLong.Location = new System.Drawing.Point(6, 282);
            this.lblTitleLong.Name = "lblTitleLong";
            this.lblTitleLong.Size = new System.Drawing.Size(58, 13);
            this.lblTitleLong.TabIndex = 29;
            this.lblTitleLong.Text = "64 bits (s) :";
            // 
            // lblTitleUint32
            // 
            this.lblTitleUint32.AutoSize = true;
            this.lblTitleUint32.Location = new System.Drawing.Point(6, 252);
            this.lblTitleUint32.Name = "lblTitleUint32";
            this.lblTitleUint32.Size = new System.Drawing.Size(64, 13);
            this.lblTitleUint32.TabIndex = 28;
            this.lblTitleUint32.Text = "32 bits (ns) :";
            // 
            // lbl32ns
            // 
            this.lbl32ns.AutoSize = true;
            this.lbl32ns.Location = new System.Drawing.Point(76, 252);
            this.lbl32ns.Name = "lbl32ns";
            this.lbl32ns.Size = new System.Drawing.Size(10, 13);
            this.lbl32ns.TabIndex = 27;
            this.lbl32ns.Text = "-";
            // 
            // lbl32s
            // 
            this.lbl32s.AutoSize = true;
            this.lbl32s.Location = new System.Drawing.Point(76, 222);
            this.lbl32s.Name = "lbl32s";
            this.lbl32s.Size = new System.Drawing.Size(10, 13);
            this.lbl32s.TabIndex = 26;
            this.lbl32s.Text = "-";
            // 
            // lblTitleInt32
            // 
            this.lblTitleInt32.AutoSize = true;
            this.lblTitleInt32.Location = new System.Drawing.Point(6, 222);
            this.lblTitleInt32.Name = "lblTitleInt32";
            this.lblTitleInt32.Size = new System.Drawing.Size(58, 13);
            this.lblTitleInt32.TabIndex = 25;
            this.lblTitleInt32.Text = "32 bits (s) :";
            // 
            // lblTitleUint16
            // 
            this.lblTitleUint16.AutoSize = true;
            this.lblTitleUint16.Location = new System.Drawing.Point(6, 192);
            this.lblTitleUint16.Name = "lblTitleUint16";
            this.lblTitleUint16.Size = new System.Drawing.Size(64, 13);
            this.lblTitleUint16.TabIndex = 24;
            this.lblTitleUint16.Text = "16 bits (ns) :";
            // 
            // lbl16ns
            // 
            this.lbl16ns.AutoSize = true;
            this.lbl16ns.Location = new System.Drawing.Point(76, 192);
            this.lbl16ns.Name = "lbl16ns";
            this.lbl16ns.Size = new System.Drawing.Size(10, 13);
            this.lbl16ns.TabIndex = 23;
            this.lbl16ns.Text = "-";
            // 
            // lbl16s
            // 
            this.lbl16s.AutoSize = true;
            this.lbl16s.Location = new System.Drawing.Point(76, 162);
            this.lbl16s.Name = "lbl16s";
            this.lbl16s.Size = new System.Drawing.Size(10, 13);
            this.lbl16s.TabIndex = 22;
            this.lbl16s.Text = "-";
            // 
            // lblTitleInt16
            // 
            this.lblTitleInt16.AutoSize = true;
            this.lblTitleInt16.Location = new System.Drawing.Point(6, 162);
            this.lblTitleInt16.Name = "lblTitleInt16";
            this.lblTitleInt16.Size = new System.Drawing.Size(58, 13);
            this.lblTitleInt16.TabIndex = 21;
            this.lblTitleInt16.Text = "16 bits (s) :";
            // 
            // lblTitleSByte
            // 
            this.lblTitleSByte.AutoSize = true;
            this.lblTitleSByte.Location = new System.Drawing.Point(6, 132);
            this.lblTitleSByte.Name = "lblTitleSByte";
            this.lblTitleSByte.Size = new System.Drawing.Size(58, 13);
            this.lblTitleSByte.TabIndex = 20;
            this.lblTitleSByte.Text = "8 bits (ns) :";
            // 
            // lbl8ns
            // 
            this.lbl8ns.AutoSize = true;
            this.lbl8ns.Location = new System.Drawing.Point(76, 132);
            this.lbl8ns.Name = "lbl8ns";
            this.lbl8ns.Size = new System.Drawing.Size(10, 13);
            this.lbl8ns.TabIndex = 19;
            this.lbl8ns.Text = "-";
            // 
            // lbl8s
            // 
            this.lbl8s.AutoSize = true;
            this.lbl8s.Location = new System.Drawing.Point(76, 102);
            this.lbl8s.Name = "lbl8s";
            this.lbl8s.Size = new System.Drawing.Size(10, 13);
            this.lbl8s.TabIndex = 18;
            this.lbl8s.Text = "-";
            // 
            // lblOctal
            // 
            this.lblOctal.AutoSize = true;
            this.lblOctal.Location = new System.Drawing.Point(76, 72);
            this.lblOctal.Name = "lblOctal";
            this.lblOctal.Size = new System.Drawing.Size(10, 13);
            this.lblOctal.TabIndex = 17;
            this.lblOctal.Text = "-";
            // 
            // lblBin
            // 
            this.lblBin.AutoSize = true;
            this.lblBin.Location = new System.Drawing.Point(76, 42);
            this.lblBin.Name = "lblBin";
            this.lblBin.Size = new System.Drawing.Size(10, 13);
            this.lblBin.TabIndex = 16;
            this.lblBin.Text = "-";
            // 
            // lblChar
            // 
            this.lblChar.AutoSize = true;
            this.lblChar.Location = new System.Drawing.Point(76, 12);
            this.lblChar.Name = "lblChar";
            this.lblChar.Size = new System.Drawing.Size(10, 13);
            this.lblChar.TabIndex = 15;
            this.lblChar.Text = "-";
            // 
            // lblTitbleByte
            // 
            this.lblTitbleByte.AutoSize = true;
            this.lblTitbleByte.Location = new System.Drawing.Point(6, 102);
            this.lblTitbleByte.Name = "lblTitbleByte";
            this.lblTitbleByte.Size = new System.Drawing.Size(52, 13);
            this.lblTitbleByte.TabIndex = 13;
            this.lblTitbleByte.Text = "8 bits (s) :";
            // 
            // lblTitleOctal
            // 
            this.lblTitleOctal.AutoSize = true;
            this.lblTitleOctal.Location = new System.Drawing.Point(6, 72);
            this.lblTitleOctal.Name = "lblTitleOctal";
            this.lblTitleOctal.Size = new System.Drawing.Size(38, 13);
            this.lblTitleOctal.TabIndex = 12;
            this.lblTitleOctal.Text = "Octal :";
            // 
            // LblTitleBinary
            // 
            this.LblTitleBinary.AutoSize = true;
            this.LblTitleBinary.Location = new System.Drawing.Point(6, 42);
            this.LblTitleBinary.Name = "LblTitleBinary";
            this.LblTitleBinary.Size = new System.Drawing.Size(42, 13);
            this.LblTitleBinary.TabIndex = 11;
            this.LblTitleBinary.Text = "Binary :";
            // 
            // lblTitleChar
            // 
            this.lblTitleChar.AutoSize = true;
            this.lblTitleChar.Location = new System.Drawing.Point(6, 12);
            this.lblTitleChar.Name = "lblTitleChar";
            this.lblTitleChar.Size = new System.Drawing.Size(35, 13);
            this.lblTitleChar.TabIndex = 10;
            this.lblTitleChar.Text = "Char :";
            // 
            // msMenu
            // 
            this.msMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.msMenu.Location = new System.Drawing.Point(0, 0);
            this.msMenu.Name = "msMenu";
            this.msMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.msMenu.Size = new System.Drawing.Size(1070, 24);
            this.msMenu.TabIndex = 0;
            this.msMenu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiOpen,
            this.tsmiSave});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // tsmiOpen
            // 
            this.tsmiOpen.Name = "tsmiOpen";
            this.tsmiOpen.Size = new System.Drawing.Size(115, 22);
            this.tsmiOpen.Text = "Open ...";
            this.tsmiOpen.Click += new System.EventHandler(this.tsmiOpen_Click);
            // 
            // tsmiSave
            // 
            this.tsmiSave.Name = "tsmiSave";
            this.tsmiSave.Size = new System.Drawing.Size(115, 22);
            this.tsmiSave.Text = "Save";
            this.tsmiSave.Click += new System.EventHandler(this.tsmiSave_Click);
            // 
            // ofdOpenFile
            // 
            this.ofdOpenFile.FileName = "openFileDialog1";
            // 
            // ViewHexaEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 594);
            this.Controls.Add(this.tbcData);
            this.Controls.Add(this.lblAscii);
            this.Controls.Add(this.lblHexa);
            this.Controls.Add(this.pbxAscii);
            this.Controls.Add(this.pbxOutput);
            this.Controls.Add(this.msMenu);
            this.MainMenuStrip = this.msMenu;
            this.Name = "ViewHexaEditor";
            this.Text = "Hexa File Editor";
            this.Load += new System.EventHandler(this.ViewHexaEditor_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ViewHexaEditor_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ViewHexaEditor_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.pbxOutput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAscii)).EndInit();
            this.tbcData.ResumeLayout(false);
            this.tbDetails.ResumeLayout(false);
            this.tbDetails.PerformLayout();
            this.tbDataReader.ResumeLayout(false);
            this.tbDataReader.PerformLayout();
            this.msMenu.ResumeLayout(false);
            this.msMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxOutput;
        private System.Windows.Forms.PictureBox pbxAscii;
        private System.Windows.Forms.Label lblHexa;
        private System.Windows.Forms.Label lblAscii;
        private System.Windows.Forms.TabControl tbcData;
        private System.Windows.Forms.TabPage tbDetails;
        private System.Windows.Forms.Label lblFileLastAccess;
        private System.Windows.Forms.Label lblModificationDate;
        private System.Windows.Forms.Label lblCreationDate;
        private System.Windows.Forms.Label lblFileSize;
        private System.Windows.Forms.Label lblFileName;
        private System.Windows.Forms.Label lblTitleLastAccess;
        private System.Windows.Forms.Label lblTitleModDate;
        private System.Windows.Forms.Label lblTitleCreationDate;
        private System.Windows.Forms.Label lblTitleSize;
        private System.Windows.Forms.Label lblTitleName;
        private System.Windows.Forms.TabPage tbDataReader;
        private System.Windows.Forms.MenuStrip msMenu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiOpen;
        private System.Windows.Forms.OpenFileDialog ofdOpenFile;
        private System.Windows.Forms.Label lbl8ns;
        private System.Windows.Forms.Label lbl8s;
        private System.Windows.Forms.Label lblOctal;
        private System.Windows.Forms.Label lblBin;
        private System.Windows.Forms.Label lblChar;
        private System.Windows.Forms.Label lblTitbleByte;
        private System.Windows.Forms.Label lblTitleOctal;
        private System.Windows.Forms.Label LblTitleBinary;
        private System.Windows.Forms.Label lblTitleChar;
        private System.Windows.Forms.Label lblTitleDouble;
        private System.Windows.Forms.Label lblDouble;
        private System.Windows.Forms.Label lblTitleFloat;
        private System.Windows.Forms.Label lblFloat;
        private System.Windows.Forms.Label lbl64;
        private System.Windows.Forms.Label lblTitleLong;
        private System.Windows.Forms.Label lblTitleUint32;
        private System.Windows.Forms.Label lbl32ns;
        private System.Windows.Forms.Label lbl32s;
        private System.Windows.Forms.Label lblTitleInt32;
        private System.Windows.Forms.Label lblTitleUint16;
        private System.Windows.Forms.Label lbl16ns;
        private System.Windows.Forms.Label lbl16s;
        private System.Windows.Forms.Label lblTitleInt16;
        private System.Windows.Forms.Label lblTitleSByte;
        private System.Windows.Forms.ToolStripMenuItem tsmiSave;
    }
}

