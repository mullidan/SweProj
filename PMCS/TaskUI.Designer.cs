namespace PMCS
{
    partial class TaskUI
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
            this.btUpdate = new System.Windows.Forms.Button();
            this.pnlRequirment = new System.Windows.Forms.Panel();
            this.c = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbEstMisc = new System.Windows.Forms.Label();
            this.lbEstAn = new System.Windows.Forms.Label();
            this.lbEstImp = new System.Windows.Forms.Label();
            this.lbEstDes = new System.Windows.Forms.Label();
            this.lbEstTest = new System.Windows.Forms.Label();
            this.lbEstMan = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbManTotal = new System.Windows.Forms.Label();
            this.lbTestTotal = new System.Windows.Forms.Label();
            this.lbDesTotal = new System.Windows.Forms.Label();
            this.lbImpTotal = new System.Windows.Forms.Label();
            this.lbAnaTotal = new System.Windows.Forms.Label();
            this.lbMiscTotal = new System.Windows.Forms.Label();
            this.tbManEff = new System.Windows.Forms.TextBox();
            this.tbTestEff = new System.Windows.Forms.TextBox();
            this.tbDesEff = new System.Windows.Forms.TextBox();
            this.tbImpEff = new System.Windows.Forms.TextBox();
            this.tbAnaEff = new System.Windows.Forms.TextBox();
            this.tbMiscEff = new System.Windows.Forms.TextBox();
            this.pnlRequirment.SuspendLayout();
            this.SuspendLayout();
            // 
            // btUpdate
            // 
            this.btUpdate.Location = new System.Drawing.Point(101, 202);
            this.btUpdate.Name = "btUpdate";
            this.btUpdate.Size = new System.Drawing.Size(75, 23);
            this.btUpdate.TabIndex = 17;
            this.btUpdate.Text = "Update";
            this.btUpdate.UseVisualStyleBackColor = true;
            this.btUpdate.Click += new System.EventHandler(this.btUpdate_Click);
            // 
            // pnlRequirment
            // 
            this.pnlRequirment.Controls.Add(this.tbManEff);
            this.pnlRequirment.Controls.Add(this.tbTestEff);
            this.pnlRequirment.Controls.Add(this.tbDesEff);
            this.pnlRequirment.Controls.Add(this.tbImpEff);
            this.pnlRequirment.Controls.Add(this.tbAnaEff);
            this.pnlRequirment.Controls.Add(this.tbMiscEff);
            this.pnlRequirment.Controls.Add(this.lbManTotal);
            this.pnlRequirment.Controls.Add(this.lbTestTotal);
            this.pnlRequirment.Controls.Add(this.lbDesTotal);
            this.pnlRequirment.Controls.Add(this.lbImpTotal);
            this.pnlRequirment.Controls.Add(this.lbAnaTotal);
            this.pnlRequirment.Controls.Add(this.lbMiscTotal);
            this.pnlRequirment.Controls.Add(this.label1);
            this.pnlRequirment.Controls.Add(this.label8);
            this.pnlRequirment.Controls.Add(this.btUpdate);
            this.pnlRequirment.Controls.Add(this.lbEstMan);
            this.pnlRequirment.Controls.Add(this.lbEstTest);
            this.pnlRequirment.Controls.Add(this.lbEstDes);
            this.pnlRequirment.Controls.Add(this.lbEstImp);
            this.pnlRequirment.Controls.Add(this.lbEstAn);
            this.pnlRequirment.Controls.Add(this.lbEstMisc);
            this.pnlRequirment.Controls.Add(this.label7);
            this.pnlRequirment.Controls.Add(this.label6);
            this.pnlRequirment.Controls.Add(this.label5);
            this.pnlRequirment.Controls.Add(this.label4);
            this.pnlRequirment.Controls.Add(this.label3);
            this.pnlRequirment.Controls.Add(this.label2);
            this.pnlRequirment.Controls.Add(this.c);
            this.pnlRequirment.Controls.Add(this.lblDescription);
            this.pnlRequirment.Location = new System.Drawing.Point(8, 8);
            this.pnlRequirment.Name = "pnlRequirment";
            this.pnlRequirment.Size = new System.Drawing.Size(419, 241);
            this.pnlRequirment.TabIndex = 15;
            // 
            // c
            // 
            this.c.AutoSize = true;
            this.c.Location = new System.Drawing.Point(318, 3);
            this.c.Name = "c";
            this.c.Size = new System.Drawing.Size(81, 13);
            this.c.TabIndex = 10;
            this.c.Text = "Estimated Effort";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(9, 3);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(31, 13);
            this.lblDescription.TabIndex = 7;
            this.lblDescription.Text = "Task";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(352, 255);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 18;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Miscellaneous";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Analysis";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Design";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Implementation";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 151);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Testing";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 179);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Management";
            // 
            // lbEstMisc
            // 
            this.lbEstMisc.AutoSize = true;
            this.lbEstMisc.Location = new System.Drawing.Point(341, 31);
            this.lbEstMisc.Name = "lbEstMisc";
            this.lbEstMisc.Size = new System.Drawing.Size(19, 13);
            this.lbEstMisc.TabIndex = 17;
            this.lbEstMisc.Text = "10";
            // 
            // lbEstAn
            // 
            this.lbEstAn.AutoSize = true;
            this.lbEstAn.Location = new System.Drawing.Point(341, 63);
            this.lbEstAn.Name = "lbEstAn";
            this.lbEstAn.Size = new System.Drawing.Size(19, 13);
            this.lbEstAn.TabIndex = 18;
            this.lbEstAn.Text = "10";
            // 
            // lbEstImp
            // 
            this.lbEstImp.AutoSize = true;
            this.lbEstImp.Location = new System.Drawing.Point(341, 122);
            this.lbEstImp.Name = "lbEstImp";
            this.lbEstImp.Size = new System.Drawing.Size(19, 13);
            this.lbEstImp.TabIndex = 19;
            this.lbEstImp.Text = "10";
            // 
            // lbEstDes
            // 
            this.lbEstDes.AutoSize = true;
            this.lbEstDes.Location = new System.Drawing.Point(341, 93);
            this.lbEstDes.Name = "lbEstDes";
            this.lbEstDes.Size = new System.Drawing.Size(19, 13);
            this.lbEstDes.TabIndex = 20;
            this.lbEstDes.Text = "10";
            // 
            // lbEstTest
            // 
            this.lbEstTest.AutoSize = true;
            this.lbEstTest.Location = new System.Drawing.Point(341, 149);
            this.lbEstTest.Name = "lbEstTest";
            this.lbEstTest.Size = new System.Drawing.Size(19, 13);
            this.lbEstTest.TabIndex = 21;
            this.lbEstTest.Text = "10";
            // 
            // lbEstMan
            // 
            this.lbEstMan.AutoSize = true;
            this.lbEstMan.Location = new System.Drawing.Point(341, 177);
            this.lbEstMan.Name = "lbEstMan";
            this.lbEstMan.Size = new System.Drawing.Size(19, 13);
            this.lbEstMan.TabIndex = 22;
            this.lbEstMan.Text = "10";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(229, 3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "Total Effort";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(115, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "Apply Effort";
            // 
            // lbManTotal
            // 
            this.lbManTotal.AutoSize = true;
            this.lbManTotal.Location = new System.Drawing.Point(244, 177);
            this.lbManTotal.Name = "lbManTotal";
            this.lbManTotal.Size = new System.Drawing.Size(19, 13);
            this.lbManTotal.TabIndex = 36;
            this.lbManTotal.Text = "10";
            // 
            // lbTestTotal
            // 
            this.lbTestTotal.AutoSize = true;
            this.lbTestTotal.Location = new System.Drawing.Point(244, 149);
            this.lbTestTotal.Name = "lbTestTotal";
            this.lbTestTotal.Size = new System.Drawing.Size(19, 13);
            this.lbTestTotal.TabIndex = 35;
            this.lbTestTotal.Text = "10";
            // 
            // lbDesTotal
            // 
            this.lbDesTotal.AutoSize = true;
            this.lbDesTotal.Location = new System.Drawing.Point(244, 93);
            this.lbDesTotal.Name = "lbDesTotal";
            this.lbDesTotal.Size = new System.Drawing.Size(19, 13);
            this.lbDesTotal.TabIndex = 34;
            this.lbDesTotal.Text = "10";
            // 
            // lbImpTotal
            // 
            this.lbImpTotal.AutoSize = true;
            this.lbImpTotal.Location = new System.Drawing.Point(244, 122);
            this.lbImpTotal.Name = "lbImpTotal";
            this.lbImpTotal.Size = new System.Drawing.Size(19, 13);
            this.lbImpTotal.TabIndex = 33;
            this.lbImpTotal.Text = "10";
            // 
            // lbAnaTotal
            // 
            this.lbAnaTotal.AutoSize = true;
            this.lbAnaTotal.Location = new System.Drawing.Point(244, 63);
            this.lbAnaTotal.Name = "lbAnaTotal";
            this.lbAnaTotal.Size = new System.Drawing.Size(19, 13);
            this.lbAnaTotal.TabIndex = 32;
            this.lbAnaTotal.Text = "10";
            // 
            // lbMiscTotal
            // 
            this.lbMiscTotal.AutoSize = true;
            this.lbMiscTotal.Location = new System.Drawing.Point(244, 32);
            this.lbMiscTotal.Name = "lbMiscTotal";
            this.lbMiscTotal.Size = new System.Drawing.Size(19, 13);
            this.lbMiscTotal.TabIndex = 31;
            this.lbMiscTotal.Text = "10";
            // 
            // tbManEff
            // 
            this.tbManEff.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tbManEff.Location = new System.Drawing.Point(118, 176);
            this.tbManEff.Name = "tbManEff";
            this.tbManEff.Size = new System.Drawing.Size(36, 20);
            this.tbManEff.TabIndex = 59;
            // 
            // tbTestEff
            // 
            this.tbTestEff.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tbTestEff.Location = new System.Drawing.Point(118, 147);
            this.tbTestEff.Name = "tbTestEff";
            this.tbTestEff.Size = new System.Drawing.Size(36, 20);
            this.tbTestEff.TabIndex = 58;
            // 
            // tbDesEff
            // 
            this.tbDesEff.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tbDesEff.Location = new System.Drawing.Point(118, 89);
            this.tbDesEff.Name = "tbDesEff";
            this.tbDesEff.Size = new System.Drawing.Size(36, 20);
            this.tbDesEff.TabIndex = 57;
            // 
            // tbImpEff
            // 
            this.tbImpEff.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tbImpEff.Location = new System.Drawing.Point(118, 119);
            this.tbImpEff.Name = "tbImpEff";
            this.tbImpEff.Size = new System.Drawing.Size(36, 20);
            this.tbImpEff.TabIndex = 56;
            // 
            // tbAnaEff
            // 
            this.tbAnaEff.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tbAnaEff.Location = new System.Drawing.Point(118, 60);
            this.tbAnaEff.Name = "tbAnaEff";
            this.tbAnaEff.Size = new System.Drawing.Size(36, 20);
            this.tbAnaEff.TabIndex = 55;
            // 
            // tbMiscEff
            // 
            this.tbMiscEff.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tbMiscEff.Location = new System.Drawing.Point(118, 32);
            this.tbMiscEff.Name = "tbMiscEff";
            this.tbMiscEff.Size = new System.Drawing.Size(36, 20);
            this.tbMiscEff.TabIndex = 54;
            // 
            // TaskUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 287);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.pnlRequirment);
            this.Name = "TaskUI";
            this.Text = "TaskUI";
            this.pnlRequirment.ResumeLayout(false);
            this.pnlRequirment.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btUpdate;
        private System.Windows.Forms.Panel pnlRequirment;
        private System.Windows.Forms.Label c;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lbEstMan;
        private System.Windows.Forms.Label lbEstTest;
        private System.Windows.Forms.Label lbEstDes;
        private System.Windows.Forms.Label lbEstImp;
        private System.Windows.Forms.Label lbEstAn;
        private System.Windows.Forms.Label lbEstMisc;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbManTotal;
        private System.Windows.Forms.Label lbTestTotal;
        private System.Windows.Forms.Label lbDesTotal;
        private System.Windows.Forms.Label lbImpTotal;
        private System.Windows.Forms.Label lbAnaTotal;
        private System.Windows.Forms.Label lbMiscTotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbManEff;
        private System.Windows.Forms.TextBox tbTestEff;
        private System.Windows.Forms.TextBox tbDesEff;
        private System.Windows.Forms.TextBox tbImpEff;
        private System.Windows.Forms.TextBox tbAnaEff;
        private System.Windows.Forms.TextBox tbMiscEff;
    }
}