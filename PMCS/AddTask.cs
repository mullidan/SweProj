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
    public partial class AddTask : Form
    {
        String taskName, discription, parentRequirement, taskType, estimatedEffort, appliedEffort;
        DateTime dueDate;
         
        public AddTask()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //insert magic here
            taskName = textBox1.Text;
            discription = textBox2.Text;
            parentRequirement = comboBox2.Text;
            taskType = comboBox1.Text;
            dueDate = dateTimePicker1.Value.Date;
            estimatedEffort = textBox3.Text;
            appliedEffort = textBox4.Text;
        }
    }
}
