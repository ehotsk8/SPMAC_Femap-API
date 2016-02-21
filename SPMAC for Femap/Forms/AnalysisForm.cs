using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SPMAC_for_Femap
{
    public partial class AnalysisForm : Form
    {
        readonly femap.model FemapModel;

        public AnalysisForm(femap.model FemapModel)
        {
            InitializeComponent();
            this.FemapModel = FemapModel;
        }

        private void MaterialButton_Click(object sender, EventArgs e)
        {
            
        }

    }
}
