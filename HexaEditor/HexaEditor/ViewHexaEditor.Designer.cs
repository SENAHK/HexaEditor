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
            ((System.ComponentModel.ISupportInitialize)(this.pbxOutput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAscii)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxOutput
            // 
            this.pbxOutput.Location = new System.Drawing.Point(41, 12);
            this.pbxOutput.Name = "pbxOutput";
            this.pbxOutput.Size = new System.Drawing.Size(463, 435);
            this.pbxOutput.TabIndex = 0;
            this.pbxOutput.TabStop = false;
            this.pbxOutput.Paint += new System.Windows.Forms.PaintEventHandler(this.pbxOutput_Paint);
            // 
            // pbxAscii
            // 
            this.pbxAscii.Location = new System.Drawing.Point(631, 12);
            this.pbxAscii.Name = "pbxAscii";
            this.pbxAscii.Size = new System.Drawing.Size(313, 435);
            this.pbxAscii.TabIndex = 1;
            this.pbxAscii.TabStop = false;
            this.pbxAscii.Paint += new System.Windows.Forms.PaintEventHandler(this.pbxAscii_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(191, 514);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // ViewHexaEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 594);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbxAscii);
            this.Controls.Add(this.pbxOutput);
            this.Name = "ViewHexaEditor";
            this.Text = "Hexa File Editor";
            this.Load += new System.EventHandler(this.ViewHexaEditor_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ViewHexaEditor_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pbxOutput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAscii)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxOutput;
        private System.Windows.Forms.PictureBox pbxAscii;
        private System.Windows.Forms.Label label1;
    }
}

