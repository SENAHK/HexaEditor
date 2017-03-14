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
            this.label1 = new System.Windows.Forms.Label();
            this.lblHexa = new System.Windows.Forms.Label();
            this.lblAscii = new System.Windows.Forms.Label();
            this.tbcData = new System.Windows.Forms.TabControl();
            this.tbDetails = new System.Windows.Forms.TabPage();
            this.lblFileLastAccess = new System.Windows.Forms.Label();
            this.lblModificationDate = new System.Windows.Forms.Label();
            this.lblCreationDate = new System.Windows.Forms.Label();
            this.lblFileSize = new System.Windows.Forms.Label();
            this.lblFileName = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbDataReader = new System.Windows.Forms.TabPage();
            this.label29 = new System.Windows.Forms.Label();
            this.lblDouble = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.lblFloat = new System.Windows.Forms.Label();
            this.lbl64 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.lbl32ns = new System.Windows.Forms.Label();
            this.lbl32s = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.lbl16ns = new System.Windows.Forms.Label();
            this.lbl16s = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lbl8ns = new System.Windows.Forms.Label();
            this.lbl8s = new System.Windows.Forms.Label();
            this.lblOctal = new System.Windows.Forms.Label();
            this.lblBin = new System.Windows.Forms.Label();
            this.lblChar = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.msMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiOpen = new System.Windows.Forms.ToolStripMenuItem();
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
            this.pbxAscii.Paint += new System.Windows.Forms.PaintEventHandler(this.pbxAscii_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(203, 572);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
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
            // 
            // tbDetails
            // 
            this.tbDetails.Controls.Add(this.lblFileLastAccess);
            this.tbDetails.Controls.Add(this.lblModificationDate);
            this.tbDetails.Controls.Add(this.lblCreationDate);
            this.tbDetails.Controls.Add(this.lblFileSize);
            this.tbDetails.Controls.Add(this.lblFileName);
            this.tbDetails.Controls.Add(this.label6);
            this.tbDetails.Controls.Add(this.label5);
            this.tbDetails.Controls.Add(this.label4);
            this.tbDetails.Controls.Add(this.label3);
            this.tbDetails.Controls.Add(this.label2);
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(0, 173);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Last access :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(0, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Modification date :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(0, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Creation date :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Size :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Name :";
            // 
            // tbDataReader
            // 
            this.tbDataReader.Controls.Add(this.label29);
            this.tbDataReader.Controls.Add(this.lblDouble);
            this.tbDataReader.Controls.Add(this.label25);
            this.tbDataReader.Controls.Add(this.lblFloat);
            this.tbDataReader.Controls.Add(this.lbl64);
            this.tbDataReader.Controls.Add(this.label28);
            this.tbDataReader.Controls.Add(this.label21);
            this.tbDataReader.Controls.Add(this.lbl32ns);
            this.tbDataReader.Controls.Add(this.lbl32s);
            this.tbDataReader.Controls.Add(this.label24);
            this.tbDataReader.Controls.Add(this.label17);
            this.tbDataReader.Controls.Add(this.lbl16ns);
            this.tbDataReader.Controls.Add(this.lbl16s);
            this.tbDataReader.Controls.Add(this.label20);
            this.tbDataReader.Controls.Add(this.label12);
            this.tbDataReader.Controls.Add(this.lbl8ns);
            this.tbDataReader.Controls.Add(this.lbl8s);
            this.tbDataReader.Controls.Add(this.lblOctal);
            this.tbDataReader.Controls.Add(this.lblBin);
            this.tbDataReader.Controls.Add(this.lblChar);
            this.tbDataReader.Controls.Add(this.label13);
            this.tbDataReader.Controls.Add(this.label14);
            this.tbDataReader.Controls.Add(this.label15);
            this.tbDataReader.Controls.Add(this.label16);
            this.tbDataReader.Location = new System.Drawing.Point(4, 22);
            this.tbDataReader.Name = "tbDataReader";
            this.tbDataReader.Padding = new System.Windows.Forms.Padding(3);
            this.tbDataReader.Size = new System.Drawing.Size(233, 409);
            this.tbDataReader.TabIndex = 1;
            this.tbDataReader.Text = "Data";
            this.tbDataReader.UseVisualStyleBackColor = true;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(6, 342);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(47, 13);
            this.label29.TabIndex = 34;
            this.label29.Text = "Double :";
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
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(6, 312);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(36, 13);
            this.label25.TabIndex = 32;
            this.label25.Text = "Float :";
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
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(6, 282);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(58, 13);
            this.label28.TabIndex = 29;
            this.label28.Text = "64 bits (s) :";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(6, 252);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(64, 13);
            this.label21.TabIndex = 28;
            this.label21.Text = "32 bits (ns) :";
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
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(6, 222);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(58, 13);
            this.label24.TabIndex = 25;
            this.label24.Text = "32 bits (s) :";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(6, 192);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(64, 13);
            this.label17.TabIndex = 24;
            this.label17.Text = "16 bits (ns) :";
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
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(6, 162);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(58, 13);
            this.label20.TabIndex = 21;
            this.label20.Text = "16 bits (s) :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 132);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 13);
            this.label12.TabIndex = 20;
            this.label12.Text = "8 bits (ns) :";
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
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 102);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(52, 13);
            this.label13.TabIndex = 13;
            this.label13.Text = "8 bits (s) :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 72);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(38, 13);
            this.label14.TabIndex = 12;
            this.label14.Text = "Octal :";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 42);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(42, 13);
            this.label15.TabIndex = 11;
            this.label15.Text = "Binary :";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 12);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(35, 13);
            this.label16.TabIndex = 10;
            this.label16.Text = "Char :";
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
            this.tsmiOpen});
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
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbxAscii);
            this.Controls.Add(this.pbxOutput);
            this.Controls.Add(this.msMenu);
            this.MainMenuStrip = this.msMenu;
            this.Name = "ViewHexaEditor";
            this.Text = "Hexa File Editor";
            this.Load += new System.EventHandler(this.ViewHexaEditor_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ViewHexaEditor_KeyDown);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblHexa;
        private System.Windows.Forms.Label lblAscii;
        private System.Windows.Forms.TabControl tbcData;
        private System.Windows.Forms.TabPage tbDetails;
        private System.Windows.Forms.Label lblFileLastAccess;
        private System.Windows.Forms.Label lblModificationDate;
        private System.Windows.Forms.Label lblCreationDate;
        private System.Windows.Forms.Label lblFileSize;
        private System.Windows.Forms.Label lblFileName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
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
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label lblDouble;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label lblFloat;
        private System.Windows.Forms.Label lbl64;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label lbl32ns;
        private System.Windows.Forms.Label lbl32s;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lbl16ns;
        private System.Windows.Forms.Label lbl16s;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label12;
    }
}

