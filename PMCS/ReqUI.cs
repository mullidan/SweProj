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
    public partial class ReqUI : Form
    {
        public ReqUI()
        {
            InitializeComponent();            
            btSelect.Enabled = false;
        }

        private void btNew_Click(object sender, EventArgs e)
        {
            AddReq newReq = new AddReq();
            newReq.ShowDialog();
        }

        private void btSelect_Click(object sender, EventArgs e)
        {
            TaskUI task = new TaskUI();
            if (lstFunc.SelectedIndex < 0)
            {
                task.Text = lstNon.SelectedItem.ToString();
            }
            else
            {
                task.Text = lstFunc.SelectedItem.ToString();
            }
            task.ShowDialog();
        }

        private void lstFunc_SelectedIndexChanged(object sender, EventArgs e)
        {
            btSelect.Enabled = true;
            if (lstFunc.SelectedIndex >= 0)
            {
                lstNon.ClearSelected();
            }                        
        }

        private void lstNon_SelectedIndexChanged(object sender, EventArgs e)
        {
            btSelect.Enabled = true;
            if (lstFunc.SelectedIndex >=0)
            {
                lstFunc.ClearSelected();
            }
            
        }

        private void lstFunc_DoubleClick(object sender, EventArgs e)
        {
            TaskUI task = new TaskUI();
            task.Text = lstNon.SelectedItem.ToString();
            task.ShowDialog();
        }

        private void lstNon_DoubleClick(object sender, EventArgs e)
        {
            TaskUI task = new TaskUI();
            task.Text = lstNon.SelectedItem.ToString();
            task.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
