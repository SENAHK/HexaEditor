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
            this.msMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.ofdOpenFile = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pbxOutput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAscii)).BeginInit();
            this.tbcData.SuspendLayout();
            this.tbDetails.SuspendLayout();
            this.msMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbxOutput
            // 
            this.pbxOutput.BackColor = System.Drawing.Color.White;
            this.pbxOutput.Location = new System.Drawing.Point(246, 44);
            this.pbxOutput.Name = "pbxOutput";
            this.pbxOutput.Size = new System.Drawing.Size(463, 435);
            this.pbxOutput.TabIndex = 0;
            this.pbxOutput.TabStop = false;
            this.pbxOutput.Paint += new System.Windows.Forms.PaintEventHandler(this.pbxOutput_Paint);
            // 
            // pbxAscii
            // 
            this.pbxAscii.BackColor = System.Drawing.Color.White;
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
            this.lblHexa.Location = new System.Drawing.Point(243, 29);
            this.lblHexa.Name = "lblHexa";
            this.lblHexa.Size = new System.Drawing.Size(102, 13);
            this.lblHexa.TabIndex = 3;
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
            this.tbcData.Size = new System.Drawing.Size(206, 435);
            this.tbcData.TabIndex = 5;
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
            this.tbDetails.Size = new System.Drawing.Size(198, 409);
            this.tbDetails.TabIndex = 0;
            this.tbDetails.Text = "File";
            this.tbDetails.UseVisualStyleBackColor = true;
            // 
            // lblFileLastAccess
            // 
            this.lblFileLastAccess.AutoSize = true;
            this.lblFileLastAccess.Location = new System.Drawing.Point(111, 173);
            this.lblFileLastAccess.Name = "lblFileLastAccess";
            this.lblFileLastAccess.Size = new System.Drawing.Size(41, 13);
            this.lblFileLastAccess.TabIndex = 9;
            this.lblFileLastAccess.Text = "label11";
            // 
            // lblModificationDate
            // 
            this.lblModificationDate.AutoSize = true;
            this.lblModificationDate.Location = new System.Drawing.Point(111, 134);
            this.lblModificationDate.Name = "lblModificationDate";
            this.lblModificationDate.Size = new System.Drawing.Size(41, 13);
            this.lblModificationDate.TabIndex = 8;
            this.lblModificationDate.Text = "label10";
            // 
            // lblCreationDate
            // 
            this.lblCreationDate.AutoSize = true;
            this.lblCreationDate.Location = new System.Drawing.Point(111, 95);
            this.lblCreationDate.Name = "lblCreationDate";
            this.lblCreationDate.Size = new System.Drawing.Size(35, 13);
            this.lblCreationDate.TabIndex = 7;
            this.lblCreationDate.Text = "label9";
            // 
            // lblFileSize
            // 
            this.lblFileSize.AutoSize = true;
            this.lblFileSize.Location = new System.Drawing.Point(111, 56);
            this.lblFileSize.Name = "lblFileSize";
            this.lblFileSize.Size = new System.Drawing.Size(35, 13);
            this.lblFileSize.TabIndex = 6;
            this.lblFileSize.Text = "label8";
            // 
            // lblFileName
            // 
            this.lblFileName.AutoSize = true;
            this.lblFileName.Location = new System.Drawing.Point(111, 17);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(35, 13);
            this.lblFileName.TabIndex = 5;
            this.lblFileName.Text = "label7";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 173);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Last access :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.lblFileName.Location = new System.Drawing.Point(111, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Modification date :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Creation date :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Size :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Name :";
            // 
            // tbDataReader
            // 
            this.tbDataReader.Location = new System.Drawing.Point(4, 22);
            this.tbDataReader.Name = "tbDataReader";
            this.tbDataReader.Padding = new System.Windows.Forms.Padding(3);
            this.tbDataReader.Size = new System.Drawing.Size(198, 409);
            this.tbDataReader.TabIndex = 1;
            this.tbDataReader.Text = "Data";
            this.tbDataReader.UseVisualStyleBackColor = true;
            // 
            // msMenu
            // 
            this.msMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.msMenu.Location = new System.Drawing.Point(0, 0);
            this.msMenu.Name = "msMenu";
            this.msMenu.Size = new System.Drawing.Size(1070, 24);
            this.msMenu.TabIndex = 6;
            this.msMenu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiOpen});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
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
    }
}

