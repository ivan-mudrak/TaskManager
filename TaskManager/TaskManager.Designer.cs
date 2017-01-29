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
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.groupBoxBackLog = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonNewTask = new System.Windows.Forms.Button();
            this.flowLayoutBackLog = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutHeader = new System.Windows.Forms.TableLayoutPanel();
            this.buttonSignIn = new System.Windows.Forms.Button();
            this.buttonLogIn = new System.Windows.Forms.Button();
            this.labelPassword = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.labelUser = new System.Windows.Forms.Label();
            this.textBoxUser = new System.Windows.Forms.TextBox();
            this.tableLayoutMain.SuspendLayout();
            this.tableLayoutBody.SuspendLayout();
            this.groupBoxDone.SuspendLayout();
            this.groupBoxTest.SuspendLayout();
            this.groupBoxDevelopment.SuspendLayout();
            this.flowLayoutDevelopment.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.groupBoxBackLog.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutHeader.SuspendLayout();
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
            this.tableLayoutMain.Controls.Add(this.tableLayoutHeader, 0, 0);
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
            this.flowLayoutDevelopment.Controls.Add(this.tableLayoutPanel2);
            this.flowLayoutDevelopment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutDevelopment.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutDevelopment.Location = new System.Drawing.Point(3, 16);
            this.flowLayoutDevelopment.Name = "flowLayoutDevelopment";
            this.flowLayoutDevelopment.Size = new System.Drawing.Size(229, 471);
            this.flowLayoutDevelopment.TabIndex = 0;
            this.flowLayoutDevelopment.DragDrop += new System.Windows.Forms.DragEventHandler(this.layoutPanel_DragDrop);
            this.flowLayoutDevelopment.DragEnter += new System.Windows.Forms.DragEventHandler(this.layoutPanel_DragEnter);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel4, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.richTextBox1, 0, 1);
            this.tableLayoutPanel2.Cursor = System.Windows.Forms.Cursors.Default;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.63636F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 59.09091F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.63636F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.63636F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(223, 116);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel3.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.label4, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(1, 83);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(221, 15);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(3, 1);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Developer(s):";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoEllipsis = true;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(88, 1);
            this.label4.Margin = new System.Windows.Forms.Padding(0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Balmer";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel4.Controls.Add(this.label5, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(1, 99);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(221, 16);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoEllipsis = true;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(88, 1);
            this.label5.Margin = new System.Windows.Forms.Padding(0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Balmer";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(21, 1);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tester(s):";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoEllipsis = true;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(1, 1);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(221, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Caption";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.EnableAutoDragDrop = true;
            this.richTextBox1.Location = new System.Drawing.Point(1, 17);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.richTextBox1.Size = new System.Drawing.Size(221, 65);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "\n";
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
            // tableLayoutHeader
            // 
            this.tableLayoutHeader.BackColor = System.Drawing.Color.PowderBlue;
            this.tableLayoutHeader.ColumnCount = 7;
            this.tableLayoutHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutHeader.Controls.Add(this.buttonSignIn, 6, 0);
            this.tableLayoutHeader.Controls.Add(this.buttonLogIn, 5, 0);
            this.tableLayoutHeader.Controls.Add(this.labelPassword, 3, 0);
            this.tableLayoutHeader.Controls.Add(this.textBoxPassword, 4, 0);
            this.tableLayoutHeader.Controls.Add(this.labelUser, 1, 0);
            this.tableLayoutHeader.Controls.Add(this.textBoxUser, 2, 0);
            this.tableLayoutHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutHeader.Location = new System.Drawing.Point(4, 4);
            this.tableLayoutHeader.Name = "tableLayoutHeader";
            this.tableLayoutHeader.RowCount = 1;
            this.tableLayoutHeader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutHeader.Size = new System.Drawing.Size(976, 64);
            this.tableLayoutHeader.TabIndex = 1;
            // 
            // buttonSignIn
            // 
            this.buttonSignIn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonSignIn.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSignIn.Location = new System.Drawing.Point(891, 17);
            this.buttonSignIn.Name = "buttonSignIn";
            this.buttonSignIn.Size = new System.Drawing.Size(70, 30);
            this.buttonSignIn.TabIndex = 0;
            this.buttonSignIn.Text = "SignIn";
            this.buttonSignIn.UseVisualStyleBackColor = true;
            // 
            // buttonLogIn
            // 
            this.buttonLogIn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonLogIn.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonLogIn.Location = new System.Drawing.Point(792, 17);
            this.buttonLogIn.Name = "buttonLogIn";
            this.buttonLogIn.Size = new System.Drawing.Size(70, 30);
            this.buttonLogIn.TabIndex = 2;
            this.buttonLogIn.Text = "LogIn";
            this.buttonLogIn.UseVisualStyleBackColor = true;
            // 
            // labelPassword
            // 
            this.labelPassword.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelPassword.AutoSize = true;
            this.labelPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelPassword.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPassword.Location = new System.Drawing.Point(501, 23);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(80, 18);
            this.labelPassword.TabIndex = 3;
            this.labelPassword.Text = "Password:";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxPassword.Location = new System.Drawing.Point(587, 22);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(140, 20);
            this.textBoxPassword.TabIndex = 4;
            // 
            // labelUser
            // 
            this.labelUser.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelUser.AutoSize = true;
            this.labelUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelUser.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelUser.Location = new System.Drawing.Point(241, 23);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(48, 18);
            this.labelUser.TabIndex = 5;
            this.labelUser.Text = "User:";
            // 
            // textBoxUser
            // 
            this.textBoxUser.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxUser.Location = new System.Drawing.Point(295, 22);
            this.textBoxUser.Name = "textBoxUser";
            this.textBoxUser.Size = new System.Drawing.Size(140, 20);
            this.textBoxUser.TabIndex = 6;
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
            this.flowLayoutDevelopment.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.groupBoxBackLog.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutHeader.ResumeLayout(false);
            this.tableLayoutHeader.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutMain;
        private System.Windows.Forms.TableLayoutPanel tableLayoutBody;
        private System.Windows.Forms.Button buttonNewTask;
        private System.Windows.Forms.TableLayoutPanel tableLayoutHeader;
        private System.Windows.Forms.Button buttonSignIn;
        private System.Windows.Forms.Button buttonLogIn;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.TextBox textBoxUser;
        private System.Windows.Forms.GroupBox groupBoxDone;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutDone;
        private System.Windows.Forms.GroupBox groupBoxTest;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutTest;
        private System.Windows.Forms.GroupBox groupBoxDevelopment;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutDevelopment;
        private System.Windows.Forms.GroupBox groupBoxBackLog;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutBackLog;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

