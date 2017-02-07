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
            ((System.ComponentModel.ISupportInitialize)(this.pbxOutput)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxOutput
            // 
            this.pbxOutput.Location = new System.Drawing.Point(179, 59);
            this.pbxOutput.Name = "pbxOutput";
            this.pbxOutput.Size = new System.Drawing.Size(425, 341);
            this.pbxOutput.TabIndex = 0;
            this.pbxOutput.TabStop = false;
            // 
            // ViewHexaEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 436);
            this.Controls.Add(this.pbxOutput);
            this.Name = "ViewHexaEditor";
            this.Text = "Hexa File Editor";
            this.Load += new System.EventHandler(this.ViewHexaEditor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxOutput)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxOutput;
    }
}

