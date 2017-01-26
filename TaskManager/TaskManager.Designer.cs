namespace TaskManager
{
    partial class TaskManager
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
            this.tableLayoutMain = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutBody = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutBacklog = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutInProgress = new System.Windows.Forms.TableLayoutPanel();
            this.buttonNewTask = new System.Windows.Forms.Button();
            this.tableLayoutMain.SuspendLayout();
            this.tableLayoutBody.SuspendLayout();
            this.tableLayoutBacklog.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutMain
            // 
            this.tableLayoutMain.AutoSize = true;
            this.tableLayoutMain.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutMain.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutMain.ColumnCount = 1;
            this.tableLayoutMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutMain.Controls.Add(this.tableLayoutBody, 0, 1);
            this.tableLayoutMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutMain.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutMain.Name = "tableLayoutMain";
            this.tableLayoutMain.RowCount = 2;
            this.tableLayoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.2807F));
            this.tableLayoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 87.7193F));
            this.tableLayoutMain.Size = new System.Drawing.Size(834, 461);
            this.tableLayoutMain.TabIndex = 0;
            // 
            // tableLayoutBody
            // 
            this.tableLayoutBody.AutoSize = true;
            this.tableLayoutBody.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutBody.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Outset;
            this.tableLayoutBody.ColumnCount = 4;
            this.tableLayoutBody.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutBody.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutBody.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutBody.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutBody.Controls.Add(this.tableLayoutBacklog, 0, 0);
            this.tableLayoutBody.Controls.Add(this.tableLayoutInProgress, 1, 0);
            this.tableLayoutBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutBody.Location = new System.Drawing.Point(4, 61);
            this.tableLayoutBody.Name = "tableLayoutBody";
            this.tableLayoutBody.RowCount = 1;
            this.tableLayoutBody.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutBody.Size = new System.Drawing.Size(826, 396);
            this.tableLayoutBody.TabIndex = 0;
            // 
            // tableLayoutBacklog
            // 
            this.tableLayoutBacklog.AllowDrop = true;
            this.tableLayoutBacklog.AutoSize = true;
            this.tableLayoutBacklog.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutBacklog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.tableLayoutBacklog.ColumnCount = 1;
            this.tableLayoutBacklog.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutBacklog.Controls.Add(this.buttonNewTask, 0, 0);
            this.tableLayoutBacklog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutBacklog.Location = new System.Drawing.Point(5, 5);
            this.tableLayoutBacklog.Name = "tableLayoutBacklog";
            this.tableLayoutBacklog.RowCount = 1;
            this.tableLayoutBacklog.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutBacklog.Size = new System.Drawing.Size(198, 386);
            this.tableLayoutBacklog.TabIndex = 0;
            this.tableLayoutBacklog.DragDrop += new System.Windows.Forms.DragEventHandler(this.tableLayoutBody_DragDrop);
            this.tableLayoutBacklog.DragEnter += new System.Windows.Forms.DragEventHandler(this.tableLayoutBody_DragEnter);
            // 
            // tableLayoutInProgress
            // 
            this.tableLayoutInProgress.AllowDrop = true;
            this.tableLayoutInProgress.AutoSize = true;
            this.tableLayoutInProgress.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutInProgress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tableLayoutInProgress.ColumnCount = 1;
            this.tableLayoutInProgress.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutInProgress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutInProgress.Location = new System.Drawing.Point(211, 5);
            this.tableLayoutInProgress.Name = "tableLayoutInProgress";
            this.tableLayoutInProgress.RowCount = 1;
            this.tableLayoutInProgress.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutInProgress.Size = new System.Drawing.Size(198, 386);
            this.tableLayoutInProgress.TabIndex = 1;
            this.tableLayoutInProgress.DragDrop += new System.Windows.Forms.DragEventHandler(this.tableLayoutBody_DragDrop);
            this.tableLayoutInProgress.DragEnter += new System.Windows.Forms.DragEventHandler(this.tableLayoutBody_DragEnter);
            // 
            // buttonNewTask
            // 
            this.buttonNewTask.AutoSize = true;
            this.buttonNewTask.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonNewTask.BackColor = System.Drawing.Color.White;
            this.buttonNewTask.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonNewTask.Location = new System.Drawing.Point(3, 3);
            this.buttonNewTask.Name = "buttonNewTask";
            this.buttonNewTask.Size = new System.Drawing.Size(192, 23);
            this.buttonNewTask.TabIndex = 0;
            this.buttonNewTask.Text = "add new task";
            this.buttonNewTask.UseVisualStyleBackColor = false;
            this.buttonNewTask.Click += new System.EventHandler(this.buttonNewTask_OnClick);
            // 
            // TaskManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 461);
            this.Controls.Add(this.tableLayoutMain);
            this.Name = "TaskManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "TaskManager";
            this.tableLayoutMain.ResumeLayout(false);
            this.tableLayoutMain.PerformLayout();
            this.tableLayoutBody.ResumeLayout(false);
            this.tableLayoutBody.PerformLayout();
            this.tableLayoutBacklog.ResumeLayout(false);
            this.tableLayoutBacklog.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutMain;
        private System.Windows.Forms.TableLayoutPanel tableLayoutBody;
        private System.Windows.Forms.TableLayoutPanel tableLayoutBacklog;
        private System.Windows.Forms.TableLayoutPanel tableLayoutInProgress;
        private System.Windows.Forms.Button buttonNewTask;
    }
}

