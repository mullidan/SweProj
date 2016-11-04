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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("Task 1");
            this.btnClose = new System.Windows.Forms.Button();
            this.btUpdate = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.colTask = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDesc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colApp = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colEst = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colRem = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.btSelectTask = new System.Windows.Forms.Button();
            this.btClose = new System.Windows.Forms.Button();
            this.btNewTask = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(347, 365);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 18;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btUpdate
            // 
            this.btUpdate.Location = new System.Drawing.Point(255, 365);
            this.btUpdate.Name = "btUpdate";
            this.btUpdate.Size = new System.Drawing.Size(75, 23);
            this.btUpdate.TabIndex = 17;
            this.btUpdate.Text = "Update";
            this.btUpdate.UseVisualStyleBackColor = true;
            this.btUpdate.Click += new System.EventHandler(this.btUpdate_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colTask,
            this.colType,
            this.colDesc,
            this.colApp,
            this.colEst,
            this.colRem});
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.listView1.Location = new System.Drawing.Point(66, 29);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(468, 172);
            this.listView1.TabIndex = 19;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // colTask
            // 
            this.colTask.Text = "Task";
            // 
            // colType
            // 
            this.colType.DisplayIndex = 5;
            this.colType.Text = "Task Type";
            this.colType.Width = 69;
            // 
            // colDesc
            // 
            this.colDesc.DisplayIndex = 1;
            this.colDesc.Text = "Description";
            this.colDesc.Width = 71;
            // 
            // colApp
            // 
            this.colApp.DisplayIndex = 2;
            this.colApp.Text = "Applied Effort";
            this.colApp.Width = 82;
            // 
            // colEst
            // 
            this.colEst.DisplayIndex = 3;
            this.colEst.Text = "Estimated Effort";
            this.colEst.Width = 94;
            // 
            // colRem
            // 
            this.colRem.DisplayIndex = 4;
            this.colRem.Text = "Remaining Time";
            this.colRem.Width = 91;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Tasks";
            // 
            // btSelectTask
            // 
            this.btSelectTask.Location = new System.Drawing.Point(248, 225);
            this.btSelectTask.Name = "btSelectTask";
            this.btSelectTask.Size = new System.Drawing.Size(75, 23);
            this.btSelectTask.TabIndex = 21;
            this.btSelectTask.Text = "Select";
            this.btSelectTask.UseVisualStyleBackColor = true;
            this.btSelectTask.Click += new System.EventHandler(this.btSelectTask_Click);
            // 
            // btClose
            // 
            this.btClose.Location = new System.Drawing.Point(329, 225);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(75, 23);
            this.btClose.TabIndex = 22;
            this.btClose.Text = "Cancel";
            this.btClose.UseVisualStyleBackColor = true;
            this.btClose.Click += new System.EventHandler(this.button2_Click);
            // 
            // btNewTask
            // 
            this.btNewTask.Location = new System.Drawing.Point(169, 225);
            this.btNewTask.Name = "btNewTask";
            this.btNewTask.Size = new System.Drawing.Size(75, 23);
            this.btNewTask.TabIndex = 23;
            this.btNewTask.Text = "New";
            this.btNewTask.UseVisualStyleBackColor = true;
            this.btNewTask.Click += new System.EventHandler(this.button3_Click);
            // 
            // TaskUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 260);
            this.Controls.Add(this.btNewTask);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.btSelectTask);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btUpdate);
            this.Name = "TaskUI";
            this.Text = "TaskUI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btUpdate;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader colTask;
        private System.Windows.Forms.ColumnHeader colType;
        private System.Windows.Forms.ColumnHeader colDesc;
        private System.Windows.Forms.ColumnHeader colApp;
        private System.Windows.Forms.ColumnHeader colEst;
        private System.Windows.Forms.ColumnHeader colRem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btSelectTask;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.Button btNewTask;
    }
}