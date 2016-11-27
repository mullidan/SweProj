using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PMCS
{
    public partial class AddReq : Form
    {
        String type, description, effortMisc, effortAnalysis, effortDesign, effortImpl, effortTest, effortManage;
        public AddReq()
        {
            InitializeComponent();
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            //The magic happens here
            type = drpTypeBox.Text;
            description = tbDescription.Text;
            effortMisc = tbMiscEff.Text;
            effortAnalysis = tbAnaEff.Text;
            effortDesign = tbDesEff.Text;
            effortImpl = tbImpEff.Text;
            effortTest = tbTestEff.Text;
            effortManage = tbManEff.Text;
        }
    }
}
