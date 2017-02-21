using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HexaEditor
{
    public partial class ViewHexaEditor : Form
    {
        private ModelHexaEditor _model;

        public ModelHexaEditor Model
        {
            get { return _model; }
            set { _model = value; }
        }

        private const int ARRAY_WIDTH = 16;

        public ViewHexaEditor()
        {
            InitializeComponent();
            Model = new ModelHexaEditor();
        }

        private void ViewHexaEditor_Load(object sender, EventArgs e)
        {

            Model.initReader(@"C:\Users\ramusim_info\Desktop\sample.dll");
            string[] values = Model.getPageContent(0);
            pbxOutput.Image = Model.GenerateDrawnValues(values, pbxOutput.Width, pbxOutput.Height);

            pbxAscii.Image = Model.generateDrawnValuesAsAscii(values, pbxAscii.Width, pbxAscii.Height);
        }

        

        private void pbxOutput_Click(object sender, EventArgs e)
        {

        }
    }
}
