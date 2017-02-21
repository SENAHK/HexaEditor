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
            ((System.ComponentModel.ISupportInitialize)(this.pbxOutput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAscii)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxOutput
            // 
            this.pbxOutput.Location = new System.Drawing.Point(179, 59);
            this.pbxOutput.Name = "pbxOutput";
            this.pbxOutput.Size = new System.Drawing.Size(425, 341);
            this.pbxOutput.TabIndex = 0;
            this.pbxOutput.TabStop = false;
            this.pbxOutput.Click += new System.EventHandler(this.pbxOutput_Click);
            // 
            // pbxAscii
            // 
            this.pbxAscii.Location = new System.Drawing.Point(631, 59);
            this.pbxAscii.Name = "pbxAscii";
            this.pbxAscii.Size = new System.Drawing.Size(313, 341);
            this.pbxAscii.TabIndex = 1;
            this.pbxAscii.TabStop = false;
            // 
            // ViewHexaEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1095, 475);
            this.Controls.Add(this.pbxAscii);
            this.Controls.Add(this.pbxOutput);
            this.Name = "ViewHexaEditor";
            this.Text = "Hexa File Editor";
            this.Load += new System.EventHandler(this.ViewHexaEditor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxOutput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAscii)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxOutput;
        private System.Windows.Forms.PictureBox pbxAscii;
    }
}

