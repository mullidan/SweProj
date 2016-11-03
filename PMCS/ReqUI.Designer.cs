namespace PMCS
{
    partial class ReqUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlRequirment = new System.Windows.Forms.Panel();
            this.lstFunc = new System.Windows.Forms.ListBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.btNew = new System.Windows.Forms.Button();
            this.btSelect = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lstNon = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlRequirment.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlRequirment
            // 
            this.pnlRequirment.Controls.Add(this.label1);
            this.pnlRequirment.Controls.Add(this.lstNon);
            this.pnlRequirment.Controls.Add(this.lstFunc);
            this.pnlRequirment.Controls.Add(this.lblDescription);
            this.pnlRequirment.Location = new System.Drawing.Point(5, 12);
            this.pnlRequirment.Name = "pnlRequirment";
            this.pnlRequirment.Size = new System.Drawing.Size(419, 241);
            this.pnlRequirment.TabIndex = 11;
            // 
            // lstFunc
            // 
            this.lstFunc.FormattingEnabled = true;
            this.lstFunc.Items.AddRange(new object[] {
            "FRequirement 1 ",
            "FRequirement 2",
            "FRequirement 3"});
            this.lstFunc.Location = new System.Drawing.Point(12, 19);
            this.lstFunc.Name = "lstFunc";
            this.lstFunc.Size = new System.Drawing.Size(404, 82);
            this.lstFunc.TabIndex = 8;
            this.lstFunc.SelectedIndexChanged += new System.EventHandler(this.lstFunc_SelectedIndexChanged);
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(9, 3);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(124, 13);
            this.lblDescription.TabIndex = 7;
            this.lblDescription.Text = "Functional Requirements";
            // 
            // btNew
            // 
            this.btNew.Location = new System.Drawing.Point(187, 258);
            this.btNew.Name = "btNew";
            this.btNew.Size = new System.Drawing.Size(75, 23);
            this.btNew.TabIndex = 14;
            this.btNew.Text = "New";
            this.btNew.UseVisualStyleBackColor = true;
            this.btNew.Click += new System.EventHandler(this.btNew_Click);
            // 
            // btSelect
            // 
            this.btSelect.Location = new System.Drawing.Point(268, 259);
            this.btSelect.Name = "btSelect";
            this.btSelect.Size = new System.Drawing.Size(75, 23);
            this.btSelect.TabIndex = 12;
            this.btSelect.Text = "Select";
            this.btSelect.UseVisualStyleBackColor = true;
            this.btSelect.Click += new System.EventHandler(this.btSelect_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(349, 260);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 13;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lstNon
            // 
            this.lstNon.FormattingEnabled = true;
            this.lstNon.Items.AddRange(new object[] {
            "NFRequirement 1 ",
            "NFRequirement 2",
            "NFRequirement 3"});
            this.lstNon.Location = new System.Drawing.Point(12, 126);
            this.lstNon.Name = "lstNon";
            this.lstNon.Size = new System.Drawing.Size(404, 82);
            this.lstNon.TabIndex = 9;
            this.lstNon.SelectedIndexChanged += new System.EventHandler(this.lstNon_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Non Functional Requirement";
            // 
            // ReqUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 287);
            this.Controls.Add(this.btNew);
            this.Controls.Add(this.btSelect);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.pnlRequirment);
            this.Name = "ReqUI";
            this.Text = "Requirements";
            this.pnlRequirment.ResumeLayout(false);
            this.pnlRequirment.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlRequirment;
        private System.Windows.Forms.ListBox lstFunc;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Button btNew;
        private System.Windows.Forms.Button btSelect;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstNon;

    }
}