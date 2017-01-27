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
            this.flowLayoutDone = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutBackLog = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonNewTask = new System.Windows.Forms.Button();
            this.flowLayoutInProgress = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutAccepted = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutMain.SuspendLayout();
            this.tableLayoutBody.SuspendLayout();
            this.flowLayoutBackLog.SuspendLayout();
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
            this.tableLayoutMain.Size = new System.Drawing.Size(1110, 575);
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
            this.tableLayoutBody.Controls.Add(this.flowLayoutDone, 2, 0);
            this.tableLayoutBody.Controls.Add(this.flowLayoutBackLog, 0, 0);
            this.tableLayoutBody.Controls.Add(this.flowLayoutInProgress, 1, 0);
            this.tableLayoutBody.Controls.Add(this.flowLayoutAccepted, 3, 0);
            this.tableLayoutBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutBody.Location = new System.Drawing.Point(4, 75);
            this.tableLayoutBody.Name = "tableLayoutBody";
            this.tableLayoutBody.RowCount = 1;
            this.tableLayoutBody.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutBody.Size = new System.Drawing.Size(1102, 496);
            this.tableLayoutBody.TabIndex = 0;
            // 
            // flowLayoutDone
            // 
            this.flowLayoutDone.AllowDrop = true;
            this.flowLayoutDone.AutoSize = true;
            this.flowLayoutDone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.flowLayoutDone.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutDone.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutDone.Location = new System.Drawing.Point(555, 5);
            this.flowLayoutDone.Name = "flowLayoutDone";
            this.flowLayoutDone.Size = new System.Drawing.Size(267, 486);
            this.flowLayoutDone.TabIndex = 2;
            this.flowLayoutDone.DragDrop += new System.Windows.Forms.DragEventHandler(this.layoutPanel_DragDrop);
            this.flowLayoutDone.DragEnter += new System.Windows.Forms.DragEventHandler(this.layoutPanel_DragEnter);
            // 
            // flowLayoutBackLog
            // 
            this.flowLayoutBackLog.AllowDrop = true;
            this.flowLayoutBackLog.AutoScroll = true;
            this.flowLayoutBackLog.AutoSize = true;
            this.flowLayoutBackLog.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutBackLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.flowLayoutBackLog.Controls.Add(this.buttonNewTask);
            this.flowLayoutBackLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutBackLog.Location = new System.Drawing.Point(5, 5);
            this.flowLayoutBackLog.Name = "flowLayoutBackLog";
            this.flowLayoutBackLog.Size = new System.Drawing.Size(267, 486);
            this.flowLayoutBackLog.TabIndex = 3;
            this.flowLayoutBackLog.DragDrop += new System.Windows.Forms.DragEventHandler(this.layoutPanel_DragDrop);
            this.flowLayoutBackLog.DragEnter += new System.Windows.Forms.DragEventHandler(this.layoutPanel_DragEnter);
            // 
            // buttonNewTask
            // 
            this.buttonNewTask.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonNewTask.BackColor = System.Drawing.Color.Transparent;
            this.buttonNewTask.Location = new System.Drawing.Point(3, 3);           
            this.buttonNewTask.Name = "buttonNewTask";
            this.buttonNewTask.Size = new System.Drawing.Size(200, 40);
            this.buttonNewTask.TabIndex = 0;
            this.buttonNewTask.Text = "add new task";
            this.buttonNewTask.UseVisualStyleBackColor = false;
            this.buttonNewTask.Click += new System.EventHandler(this.buttonNewTask_OnClick);
            // 
            // flowLayoutInProgress
            // 
            this.flowLayoutInProgress.AllowDrop = true;
            this.flowLayoutInProgress.AutoScroll = true;
            this.flowLayoutInProgress.AutoSize = true;
            this.flowLayoutInProgress.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutInProgress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.flowLayoutInProgress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutInProgress.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutInProgress.Location = new System.Drawing.Point(280, 5);
            this.flowLayoutInProgress.Name = "flowLayoutInProgress";
            this.flowLayoutInProgress.Size = new System.Drawing.Size(267, 486);
            this.flowLayoutInProgress.TabIndex = 4;
            this.flowLayoutInProgress.DragDrop += new System.Windows.Forms.DragEventHandler(this.layoutPanel_DragDrop);
            this.flowLayoutInProgress.DragEnter += new System.Windows.Forms.DragEventHandler(this.layoutPanel_DragEnter);
            // 
            // flowLayoutAccepted
            // 
            this.flowLayoutAccepted.AllowDrop = true;
            this.flowLayoutAccepted.AutoScroll = true;
            this.flowLayoutAccepted.AutoSize = true;
            this.flowLayoutAccepted.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutAccepted.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.flowLayoutAccepted.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutAccepted.Location = new System.Drawing.Point(830, 5);
            this.flowLayoutAccepted.Name = "flowLayoutAccepted";
            this.flowLayoutAccepted.Size = new System.Drawing.Size(267, 486);
            this.flowLayoutAccepted.TabIndex = 5;
            this.flowLayoutAccepted.DragDrop += new System.Windows.Forms.DragEventHandler(this.layoutPanel_DragDrop);
            this.flowLayoutAccepted.DragEnter += new System.Windows.Forms.DragEventHandler(this.layoutPanel_DragEnter);
            // 
            // TaskManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1110, 575);
            this.Controls.Add(this.tableLayoutMain);
            this.Name = "TaskManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "TaskManager";
            this.tableLayoutMain.ResumeLayout(false);
            this.tableLayoutMain.PerformLayout();
            this.tableLayoutBody.ResumeLayout(false);
            this.tableLayoutBody.PerformLayout();
            this.flowLayoutBackLog.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutMain;
        private System.Windows.Forms.TableLayoutPanel tableLayoutBody;
        private System.Windows.Forms.Button buttonNewTask;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutDone;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutBackLog;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutInProgress;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutAccepted;
    }
}

