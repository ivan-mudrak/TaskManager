using System;
using System.Drawing;
using System.Windows.Forms;
using JetBrains.Annotations;

namespace TaskManager
{
    class BodyPanelUser : BodyPanel
    {

        private Button buttonNewTask;
        private GroupBox groupBoxDone;
        private FlowLayoutPanel flowLayoutDone;
        private GroupBox groupBoxTest;
        private FlowLayoutPanel flowLayoutTest;
        private GroupBox groupBoxDevelopment;
        private FlowLayoutPanel flowLayoutDevelopment;
        private GroupBox groupBoxBackLog;
        private TableLayoutPanel tableLayoutPanelBackLog;
        private FlowLayoutPanel flowLayoutBackLog;
        private UsersEntity _userEntity;


        public BodyPanelUser([NotNull]UsersEntity userEntity)
            : base(userEntity)
        {
            _userEntity = userEntity;

            groupBoxDone = new GroupBox();
            flowLayoutDone = new FlowLayoutPanel();
            groupBoxTest = new GroupBox();
            flowLayoutTest = new FlowLayoutPanel();
            groupBoxDevelopment = new GroupBox();
            flowLayoutDevelopment = new FlowLayoutPanel();
            groupBoxBackLog = new GroupBox();
            tableLayoutPanelBackLog = new TableLayoutPanel();
            buttonNewTask = new Button();
            flowLayoutBackLog = new FlowLayoutPanel();
            // 
            // tableLayoutBody
            // 
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            CellBorderStyle = TableLayoutPanelCellBorderStyle.Outset;
            ColumnCount = 4;
            ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            Controls.Add(groupBoxDone, 3, 0);
            Controls.Add(groupBoxTest, 2, 0);
            Controls.Add(groupBoxDevelopment, 1, 0);
            Controls.Add(groupBoxBackLog, 0, 0);
            Dock = DockStyle.Fill;
            Location = new Point(4, 75);
            Name = "tableLayoutBody";
            RowCount = 1;
            RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            Size = new Size(976, 500);
            TabIndex = 0;
            // 
            // groupBoxDone
            // 
            groupBoxDone.AllowDrop = true;
            groupBoxDone.Anchor = ((AnchorStyles.Top | AnchorStyles.Bottom)
                                   | AnchorStyles.Left)
                                  | AnchorStyles.Right;
            groupBoxDone.BackColor = Color.FromArgb(192, 255, 192);
            groupBoxDone.Controls.Add(flowLayoutDone);
            groupBoxDone.Location = new Point(734, 5);
            groupBoxDone.Name = "groupBoxDone";
            groupBoxDone.Size = new Size(237, 490);
            groupBoxDone.TabIndex = 5;
            groupBoxDone.TabStop = false;
            groupBoxDone.Text = "Done";
            // 
            // flowLayoutDone
            // 
            flowLayoutDone.AllowDrop = true;
            flowLayoutDone.BackColor = Color.Transparent;
            flowLayoutDone.Dock = DockStyle.Fill;
            flowLayoutDone.FlowDirection = FlowDirection.TopDown;
            flowLayoutDone.Location = new Point(3, 16);
            flowLayoutDone.Name = "flowLayoutDone";
            flowLayoutDone.Size = new Size(231, 471);
            flowLayoutDone.TabIndex = 0;
            flowLayoutDone.DragDrop += this.layoutPanel_DragDrop;
            flowLayoutDone.DragEnter += this.layoutPanel_DragEnter;
            // 
            // groupBoxTest
            // 
            groupBoxTest.BackColor = Color.FromArgb(255, 255, 192);
            groupBoxTest.Controls.Add(flowLayoutTest);
            groupBoxTest.Dock = DockStyle.Fill;
            groupBoxTest.Location = new Point(491, 5);
            groupBoxTest.Name = "groupBoxTest";
            groupBoxTest.Size = new Size(235, 490);
            groupBoxTest.TabIndex = 6;
            groupBoxTest.TabStop = false;
            groupBoxTest.Text = "Test";
            // 
            // flowLayoutTest
            // 
            flowLayoutTest.AllowDrop = true;
            flowLayoutTest.Dock = DockStyle.Fill;
            flowLayoutTest.FlowDirection = FlowDirection.TopDown;
            flowLayoutTest.Location = new Point(3, 16);
            flowLayoutTest.Name = "flowLayoutTest";
            flowLayoutTest.Size = new Size(229, 471);
            flowLayoutTest.TabIndex = 0;
            flowLayoutTest.DragDrop += this.layoutPanel_DragDrop;
            flowLayoutTest.DragEnter += this.layoutPanel_DragEnter;
            // 
            // groupBoxDevelopment
            // 
            groupBoxDevelopment.BackColor = Color.FromArgb(255, 224, 192);
            groupBoxDevelopment.Controls.Add(flowLayoutDevelopment);
            groupBoxDevelopment.Dock = DockStyle.Fill;
            groupBoxDevelopment.Location = new Point(248, 5);
            groupBoxDevelopment.Name = "groupBoxDevelopment";
            groupBoxDevelopment.Size = new Size(235, 490);
            groupBoxDevelopment.TabIndex = 7;
            groupBoxDevelopment.TabStop = false;
            groupBoxDevelopment.Text = "Development";
            // 
            // flowLayoutDevelopment
            // 
            flowLayoutDevelopment.AllowDrop = true;
            flowLayoutDevelopment.Dock = DockStyle.Fill;
            flowLayoutDevelopment.FlowDirection = FlowDirection.TopDown;
            flowLayoutDevelopment.Location = new Point(3, 16);
            flowLayoutDevelopment.Name = "flowLayoutDevelopment";
            flowLayoutDevelopment.Size = new Size(229, 471);
            flowLayoutDevelopment.TabIndex = 0;
            flowLayoutDevelopment.DragDrop += this.layoutPanel_DragDrop;
            flowLayoutDevelopment.DragEnter += this.layoutPanel_DragEnter;
            // 
            // groupBoxBackLog
            // 
            groupBoxBackLog.BackColor = Color.FromArgb(255, 128, 128);
            groupBoxBackLog.Controls.Add(tableLayoutPanelBackLog);
            groupBoxBackLog.Dock = DockStyle.Fill;
            groupBoxBackLog.Location = new Point(5, 5);
            groupBoxBackLog.Name = "groupBoxBackLog";
            groupBoxBackLog.Size = new Size(235, 490);
            groupBoxBackLog.TabIndex = 8;
            groupBoxBackLog.TabStop = false;
            groupBoxBackLog.Text = "Back Log";
            // 
            // tableLayoutPanelBackLog
            // 
            tableLayoutPanelBackLog.ColumnCount = 1;
            tableLayoutPanelBackLog.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanelBackLog.Controls.Add(buttonNewTask, 0, 0);
            tableLayoutPanelBackLog.Controls.Add(flowLayoutBackLog, 0, 1);
            tableLayoutPanelBackLog.Dock = DockStyle.Fill;
            tableLayoutPanelBackLog.Location = new Point(3, 16);
            tableLayoutPanelBackLog.Name = "tableLayoutPanelBackLog";
            tableLayoutPanelBackLog.RowCount = 2;
            tableLayoutPanelBackLog.RowStyles.Add(new RowStyle(SizeType.Absolute, 26F));
            tableLayoutPanelBackLog.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanelBackLog.Size = new Size(229, 471);
            tableLayoutPanelBackLog.TabIndex = 0;
            // 
            // buttonNewTask
            // 
            buttonNewTask.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            buttonNewTask.AutoSize = true;
            buttonNewTask.BackColor = Color.Transparent;
            buttonNewTask.FlatStyle = FlatStyle.Popup;
            buttonNewTask.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonNewTask.ForeColor = Color.White;
            buttonNewTask.Location = new Point(3, 3);
            buttonNewTask.Name = "buttonNewTask";
            buttonNewTask.Size = new Size(223, 20);
            buttonNewTask.TabIndex = 0;
            buttonNewTask.Text = "add new task";
            buttonNewTask.UseVisualStyleBackColor = false;
            buttonNewTask.Enabled = _userEntity.Role == (short)Roles.Admin ? true : false;
            buttonNewTask.Click += this.buttonNewTask_OnClick;
        
            // 
            // flowLayoutBackLog
            // 
            flowLayoutBackLog.AllowDrop = true;
            flowLayoutBackLog.Dock = DockStyle.Fill;
            flowLayoutBackLog.FlowDirection = FlowDirection.TopDown;
            flowLayoutBackLog.Location = new Point(0, 26);
            flowLayoutBackLog.Margin = new Padding(0);
            flowLayoutBackLog.Name = "flowLayoutBackLog";
            flowLayoutBackLog.Size = new Size(229, 445);
            flowLayoutBackLog.TabIndex = 1;
            flowLayoutBackLog.DragDrop += this.layoutPanel_DragDrop;
            flowLayoutBackLog.DragEnter += this.layoutPanel_DragEnter;
        }
    
        private void layoutPanel_DragDrop(object sender, DragEventArgs e)
        {

            if (e.Data.GetDataPresent(typeof(TaskCard)))
            {
                if (sender is Panel)
                {
                    ((Panel)sender).Controls.Add(e.Data.GetData(typeof(TaskCard)) as TaskCard);
                }
            }
        }

        private void layoutPanel_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(TaskCard)))
            {
                e.Effect = DragDropEffects.All;
            }
        }

        private void buttonNewTask_OnClick(object sender, EventArgs e)
        {
            TaskDialog dialog = new TaskDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                TaskBuilder taskBuilder = new TaskBuilder();
                taskBuilder.SetTitle(() => dialog.Title);
                taskBuilder.SetDescription(() => dialog.Description);
                Task task = taskBuilder.GetTask();


                using (var dbContainer = new DataModelContainer1())
                {

                    
                }

                flowLayoutBackLog.Controls.Add(task.GetView());
            }
        }

    }
}
