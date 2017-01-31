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
            this.groupBoxDone = new System.Windows.Forms.GroupBox();
            this.flowLayoutDone = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBoxTest = new System.Windows.Forms.GroupBox();
            this.flowLayoutTest = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBoxDevelopment = new System.Windows.Forms.GroupBox();
            this.flowLayoutDevelopment = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBoxBackLog = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonNewTask = new System.Windows.Forms.Button();
            this.flowLayoutBackLog = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutMain.SuspendLayout();
            this.tableLayoutBody.SuspendLayout();
            this.groupBoxDone.SuspendLayout();
            this.groupBoxTest.SuspendLayout();
            this.groupBoxDevelopment.SuspendLayout();
            this.groupBoxBackLog.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();    
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
            this.tableLayoutMain.Size = new System.Drawing.Size(984, 579);
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
            this.tableLayoutBody.Controls.Add(this.groupBoxDone, 3, 0);
            this.tableLayoutBody.Controls.Add(this.groupBoxTest, 2, 0);
            this.tableLayoutBody.Controls.Add(this.groupBoxDevelopment, 1, 0);
            this.tableLayoutBody.Controls.Add(this.groupBoxBackLog, 0, 0);
            this.tableLayoutBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutBody.Location = new System.Drawing.Point(4, 75);
            this.tableLayoutBody.Name = "tableLayoutBody";
            this.tableLayoutBody.RowCount = 1;
            this.tableLayoutBody.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutBody.Size = new System.Drawing.Size(976, 500);
            this.tableLayoutBody.TabIndex = 0;
            // 
            // groupBoxDone
            // 
            this.groupBoxDone.AllowDrop = true;
            this.groupBoxDone.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxDone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBoxDone.Controls.Add(this.flowLayoutDone);
            this.groupBoxDone.Location = new System.Drawing.Point(734, 5);
            this.groupBoxDone.Name = "groupBoxDone";
            this.groupBoxDone.Size = new System.Drawing.Size(237, 490);
            this.groupBoxDone.TabIndex = 5;
            this.groupBoxDone.TabStop = false;
            this.groupBoxDone.Text = "Done";
            // 
            // flowLayoutDone
            // 
            this.flowLayoutDone.AllowDrop = true;
            this.flowLayoutDone.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutDone.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutDone.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutDone.Location = new System.Drawing.Point(3, 16);
            this.flowLayoutDone.Name = "flowLayoutDone";
            this.flowLayoutDone.Size = new System.Drawing.Size(231, 471);
            this.flowLayoutDone.TabIndex = 0;
            this.flowLayoutDone.DragDrop += new System.Windows.Forms.DragEventHandler(this.layoutPanel_DragDrop);
            this.flowLayoutDone.DragEnter += new System.Windows.Forms.DragEventHandler(this.layoutPanel_DragEnter);
            // 
            // groupBoxTest
            // 
            this.groupBoxTest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBoxTest.Controls.Add(this.flowLayoutTest);
            this.groupBoxTest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxTest.Location = new System.Drawing.Point(491, 5);
            this.groupBoxTest.Name = "groupBoxTest";
            this.groupBoxTest.Size = new System.Drawing.Size(235, 490);
            this.groupBoxTest.TabIndex = 6;
            this.groupBoxTest.TabStop = false;
            this.groupBoxTest.Text = "Test";
            // 
            // flowLayoutTest
            // 
            this.flowLayoutTest.AllowDrop = true;
            this.flowLayoutTest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutTest.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutTest.Location = new System.Drawing.Point(3, 16);
            this.flowLayoutTest.Name = "flowLayoutTest";
            this.flowLayoutTest.Size = new System.Drawing.Size(229, 471);
            this.flowLayoutTest.TabIndex = 0;
            this.flowLayoutTest.DragDrop += new System.Windows.Forms.DragEventHandler(this.layoutPanel_DragDrop);
            this.flowLayoutTest.DragEnter += new System.Windows.Forms.DragEventHandler(this.layoutPanel_DragEnter);
            // 
            // groupBoxDevelopment
            // 
            this.groupBoxDevelopment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.groupBoxDevelopment.Controls.Add(this.flowLayoutDevelopment);
            this.groupBoxDevelopment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxDevelopment.Location = new System.Drawing.Point(248, 5);
            this.groupBoxDevelopment.Name = "groupBoxDevelopment";
            this.groupBoxDevelopment.Size = new System.Drawing.Size(235, 490);
            this.groupBoxDevelopment.TabIndex = 7;
            this.groupBoxDevelopment.TabStop = false;
            this.groupBoxDevelopment.Text = "Development";
            // 
            // flowLayoutDevelopment
            // 
            this.flowLayoutDevelopment.AllowDrop = true;
            this.flowLayoutDevelopment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutDevelopment.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutDevelopment.Location = new System.Drawing.Point(3, 16);
            this.flowLayoutDevelopment.Name = "flowLayoutDevelopment";
            this.flowLayoutDevelopment.Size = new System.Drawing.Size(229, 471);
            this.flowLayoutDevelopment.TabIndex = 0;
            this.flowLayoutDevelopment.DragDrop += new System.Windows.Forms.DragEventHandler(this.layoutPanel_DragDrop);
            this.flowLayoutDevelopment.DragEnter += new System.Windows.Forms.DragEventHandler(this.layoutPanel_DragEnter);
            // 
            // groupBoxBackLog
            // 
            this.groupBoxBackLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.groupBoxBackLog.Controls.Add(this.tableLayoutPanel1);
            this.groupBoxBackLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxBackLog.Location = new System.Drawing.Point(5, 5);
            this.groupBoxBackLog.Name = "groupBoxBackLog";
            this.groupBoxBackLog.Size = new System.Drawing.Size(235, 490);
            this.groupBoxBackLog.TabIndex = 8;
            this.groupBoxBackLog.TabStop = false;
            this.groupBoxBackLog.Text = "Back Log";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.buttonNewTask, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutBackLog, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(229, 471);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // buttonNewTask
            // 
            this.buttonNewTask.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonNewTask.AutoSize = true;
            this.buttonNewTask.BackColor = System.Drawing.Color.Transparent;
            this.buttonNewTask.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonNewTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonNewTask.ForeColor = System.Drawing.Color.White;
            this.buttonNewTask.Location = new System.Drawing.Point(3, 3);
            this.buttonNewTask.Name = "buttonNewTask";
            this.buttonNewTask.Size = new System.Drawing.Size(223, 20);
            this.buttonNewTask.TabIndex = 0;
            this.buttonNewTask.Text = "add new task";
            this.buttonNewTask.UseVisualStyleBackColor = false;
            this.buttonNewTask.Click += new System.EventHandler(this.buttonNewTask_OnClick);
            // 
            // flowLayoutBackLog
            // 
            this.flowLayoutBackLog.AllowDrop = true;
            this.flowLayoutBackLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutBackLog.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutBackLog.Location = new System.Drawing.Point(0, 26);
            this.flowLayoutBackLog.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutBackLog.Name = "flowLayoutBackLog";
            this.flowLayoutBackLog.Size = new System.Drawing.Size(229, 445);
            this.flowLayoutBackLog.TabIndex = 1;
            this.flowLayoutBackLog.DragDrop += new System.Windows.Forms.DragEventHandler(this.layoutPanel_DragDrop);
            this.flowLayoutBackLog.DragEnter += new System.Windows.Forms.DragEventHandler(this.layoutPanel_DragEnter);
            // 
            // TaskManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 579);
            this.Controls.Add(this.tableLayoutMain);
            this.MinimumSize = new System.Drawing.Size(1000, 618);
            this.Name = "TaskManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "TaskManager";
            this.tableLayoutMain.ResumeLayout(false);
            this.tableLayoutMain.PerformLayout();
            this.tableLayoutBody.ResumeLayout(false);
            this.groupBoxDone.ResumeLayout(false);
            this.groupBoxTest.ResumeLayout(false);
            this.groupBoxDevelopment.ResumeLayout(false);
            this.groupBoxBackLog.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();       
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutMain;
        private System.Windows.Forms.TableLayoutPanel tableLayoutBody;
        private System.Windows.Forms.Button buttonNewTask;        
        private System.Windows.Forms.GroupBox groupBoxDone;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutDone;
        private System.Windows.Forms.GroupBox groupBoxTest;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutTest;
        private System.Windows.Forms.GroupBox groupBoxDevelopment;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutDevelopment;
        private System.Windows.Forms.GroupBox groupBoxBackLog;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutBackLog;  
    }
}

