using System;
using System.IO;
using System.Text;
using System.Collections;
using System.Windows.Forms;
using System.Collections.Generic;
using ProjectModels;
using ProjectModels.Model;


namespace PMCS
{
    public partial class MainUI : Form
    {
        //Form overrides dispose to clean up the component list.
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }
        private Label lblDescription;
        private Button btnSelect;
        private Button btnClose;
        private Panel pnlRequirment;
        private ListBox lstProjBox;
        private Button btNew;
        private System.ComponentModel.IContainer components;

        public MainUI() : base()
        {

            //This call is required by the Windows Form Designer.
            InitializeComponent();

            //Add any initialization after the InitializeComponent() call

        }

        //NOTE: The following procedure is required by the Windows Form Designer
        //It can be modified using the Windows Form Designer.  
        //Do not modify it using the code editor.
        [System.Diagnostics.DebuggerNonUserCode]
        private void InitializeComponent()
        {
            this.lblDescription = new System.Windows.Forms.Label();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.pnlRequirment = new System.Windows.Forms.Panel();
            this.lstProjBox = new System.Windows.Forms.ListBox();
            this.btNew = new System.Windows.Forms.Button();
            this.pnlRequirment.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(9, 4);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(82, 13);
            this.lblDescription.TabIndex = 7;
            this.lblDescription.Text = "Select a Project";
            // 
            // btnSelect
            // 
            this.btnSelect.Enabled = false;
            this.btnSelect.Location = new System.Drawing.Point(268, 259);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(75, 23);
            this.btnSelect.TabIndex = 1;
            this.btnSelect.Text = "Select";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btSelect_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(349, 260);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pnlRequirment
            // 
            this.pnlRequirment.Controls.Add(this.lstProjBox);
            this.pnlRequirment.Controls.Add(this.lblDescription);
            this.pnlRequirment.Location = new System.Drawing.Point(5, 12);
            this.pnlRequirment.Name = "pnlRequirment";
            this.pnlRequirment.Size = new System.Drawing.Size(419, 241);
            this.pnlRequirment.TabIndex = 10;
            // 
            // lstProjBox
            // 
            this.lstProjBox.FormattingEnabled = true;
            this.lstProjBox.Items.AddRange(new object[] {
            "Test Project 1",
            "Test project 2"});
            this.lstProjBox.Location = new System.Drawing.Point(12, 20);
            this.lstProjBox.Name = "lstProjBox";
            this.lstProjBox.Size = new System.Drawing.Size(383, 199);
            this.lstProjBox.TabIndex = 8;
            this.lstProjBox.SelectedIndexChanged += new System.EventHandler(this.lstProjBox_SelectedIndexChanged);
            // 
            // btNew
            // 
            this.btNew.Location = new System.Drawing.Point(187, 258);
            this.btNew.Name = "btNew";
            this.btNew.Size = new System.Drawing.Size(75, 23);
            this.btNew.TabIndex = 11;
            this.btNew.Text = "New";
            this.btNew.UseVisualStyleBackColor = true;
            // 
            // MainUI
            // 
            this.ClientSize = new System.Drawing.Size(434, 287);
            this.Controls.Add(this.btNew);
            this.Controls.Add(this.pnlRequirment);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.btnClose);
            this.Name = "MainUI";
            this.Text = "Project Management Client";
            this.pnlRequirment.ResumeLayout(false);
            this.pnlRequirment.PerformLayout();
            this.ResumeLayout(false);

        }

        private void btSelect_Click(object sender, EventArgs e)
        {
            // persist the work item data details
           // var title = txtTitle.Text;
           

            //var details = new List<string>();
            //details.Add(title);
            
            // save
            //var tw = new TextWriter();
            //string path = @"D:\development\c# Projects\PMCS\PMCS\WorkItemDetails.txt";
            //File.WriteAllLines(path, details.ToArray(), UTF8Encoding.Default);    

            ReqUI req = new ReqUI();
            req.Text = lstProjBox.SelectedItem.ToString();
            req.ShowDialog();

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lstProjBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnSelect.Enabled = true;
        }
         private void lstProjBox_DoubleClick(object sender, EventArgs e)
        {
            ReqUI req = new ReqUI();
            req.Text = lstProjBox.SelectedItem.ToString();
            req.ShowDialog();
        }
    }
}