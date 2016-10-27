using System;
using System.IO;
using System.Text;
using System.Collections;
using System.Windows.Forms;
using System.Collections.Generic;

namespace PMCS
{
    public partial class Form1 : Form
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
        private Label label1;
        private TextBox txtTitle;
        private Label lblDescription;
        private RichTextBox rtbDescription;
        private Button btnSave;
        private Button btnClose;
        private TableLayoutPanel tableLayoutPanel1;
        private LinkLabel llblOther;
        private LinkLabel llblBug;
        private LinkLabel llblTask;
        private LinkLabel llblRequirement;
        private Panel pnlRequirment;
        private System.ComponentModel.IContainer components;

        public Form1() : base()
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.rtbDescription = new System.Windows.Forms.RichTextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.llblRequirement = new System.Windows.Forms.LinkLabel();
            this.llblTask = new System.Windows.Forms.LinkLabel();
            this.llblBug = new System.Windows.Forms.LinkLabel();
            this.llblOther = new System.Windows.Forms.LinkLabel();
            this.pnlRequirment = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1.SuspendLayout();
            this.pnlRequirment.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Title";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(36, 6);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(360, 20);
            this.txtTitle.TabIndex = 6;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(3, 39);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(60, 13);
            this.lblDescription.TabIndex = 7;
            this.lblDescription.Text = "Description";
            // 
            // rtbDescription
            // 
            this.rtbDescription.Location = new System.Drawing.Point(69, 39);
            this.rtbDescription.Name = "rtbDescription";
            this.rtbDescription.Size = new System.Drawing.Size(331, 193);
            this.rtbDescription.TabIndex = 4;
            this.rtbDescription.Text = "";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(268, 294);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(349, 294);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 95F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 86F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 108F));
            this.tableLayoutPanel1.Controls.Add(this.llblOther, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.llblBug, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.llblTask, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.llblRequirement, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(5, 13);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(375, 19);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // llblRequirement
            // 
            this.llblRequirement.AutoSize = true;
            this.llblRequirement.Location = new System.Drawing.Point(3, 0);
            this.llblRequirement.Name = "llblRequirement";
            this.llblRequirement.Size = new System.Drawing.Size(67, 13);
            this.llblRequirement.TabIndex = 0;
            this.llblRequirement.TabStop = true;
            this.llblRequirement.Text = "Requirement";
            // 
            // llblTask
            // 
            this.llblTask.AutoSize = true;
            this.llblTask.Location = new System.Drawing.Point(89, 0);
            this.llblTask.Name = "llblTask";
            this.llblTask.Size = new System.Drawing.Size(31, 13);
            this.llblTask.TabIndex = 1;
            this.llblTask.TabStop = true;
            this.llblTask.Text = "Task";
            // 
            // llblBug
            // 
            this.llblBug.AutoSize = true;
            this.llblBug.Location = new System.Drawing.Point(184, 0);
            this.llblBug.Name = "llblBug";
            this.llblBug.Size = new System.Drawing.Size(26, 13);
            this.llblBug.TabIndex = 2;
            this.llblBug.TabStop = true;
            this.llblBug.Text = "Bug";
            // 
            // llblOther
            // 
            this.llblOther.AutoSize = true;
            this.llblOther.Location = new System.Drawing.Point(270, 0);
            this.llblOther.Name = "llblOther";
            this.llblOther.Size = new System.Drawing.Size(33, 13);
            this.llblOther.TabIndex = 3;
            this.llblOther.TabStop = true;
            this.llblOther.Text = "Other";
            // 
            // pnlRequirment
            // 
            this.pnlRequirment.Controls.Add(this.txtTitle);
            this.pnlRequirment.Controls.Add(this.rtbDescription);
            this.pnlRequirment.Controls.Add(this.label1);
            this.pnlRequirment.Controls.Add(this.lblDescription);
            this.pnlRequirment.Location = new System.Drawing.Point(5, 38);
            this.pnlRequirment.Name = "pnlRequirment";
            this.pnlRequirment.Size = new System.Drawing.Size(419, 241);
            this.pnlRequirment.TabIndex = 10;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(438, 336);
            this.Controls.Add(this.pnlRequirment);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClose);
            this.Name = "Form1";
            this.Text = "Project Management Client";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.pnlRequirment.ResumeLayout(false);
            this.pnlRequirment.PerformLayout();
            this.ResumeLayout(false);

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // persist the work item data details
            var title = txtTitle.Text;
            var desc = this.rtbDescription.Text;

            var details = new List<string>();
            details.Add(title);
            details.Add(desc);

            // save
            //var tw = new TextWriter();
            string path = @"D:\development\c# Projects\PMCS\PMCS\WorkItemDetails.txt";
            File.WriteAllLines(path, details.ToArray(), UTF8Encoding.Default);           
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}