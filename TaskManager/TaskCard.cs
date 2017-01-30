
using System.Windows.Forms;

namespace TaskManager
{

    class TaskCard : TableLayoutPanel
    {
        private TableLayoutPanel _developerLayoutPanel, _testerLayoutPanel;
        private Label _developerLabel, _testerLabel;
        private Label _title, _developers, _testers;
        private RichTextBox _description;
        private MouseEventHandler _childMouseDown;

        public TaskCard(string title, string description, Developer developer, Tester tester)
        {
            // 
            // _title
            // 
            _title = new Label();
            _title.Anchor = (AnchorStyles.Left | AnchorStyles.Right);
            _title.AutoEllipsis = true;
            _title.AutoSize = true;
            _title.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            _title.Location = new System.Drawing.Point(1, 1);
            _title.Margin = new Padding(0);
            _title.Name = "title";
            _title.Size = new System.Drawing.Size(221, 15);
            _title.TabIndex = 2;
            _title.Text = title;
            _title.MouseDown += new MouseEventHandler(taskCardChild_MouseDown);
            // 
            // _description
            // 
            _description = new RichTextBox();      
            _description.BorderStyle = BorderStyle.None;
            _description.Dock = DockStyle.Fill;               
            _description.Location = new System.Drawing.Point(1, 17);
            _description.Margin = new Padding(0);
            _description.Name = "description";
            _description.ReadOnly = true;            
            _description.ScrollBars = RichTextBoxScrollBars.Vertical;
            _description.Size = new System.Drawing.Size(221, 65);
            _description.TabIndex = 3;
            _description.Text = description;
            _description.MouseDown += new MouseEventHandler(taskCardChild_MouseDown);
            // 
            // _developerLabel
            // 
            _developerLabel = new Label();
            _developerLabel.Anchor = AnchorStyles.Right;
            _developerLabel.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            _developerLabel.AutoSize = true;
            _developerLabel.Location = new System.Drawing.Point(3, 1);
            _developerLabel.Name = "_developerLabel";
            _developerLabel.Size = new System.Drawing.Size(85, 13);
            _developerLabel.TabIndex = 0;
            _developerLabel.Text = "Developer(s):";
            _developerLabel.MouseDown += new MouseEventHandler(taskCardChild_MouseDown);
            // 
            // _developers
            // 
            _developers = new Label();
            _developers.Anchor = AnchorStyles.Left;
            _developers.AutoEllipsis = true;
            _developers.AutoSize = true;
            _developers.Location = new System.Drawing.Point(88, 1);
            _developers.Margin = new Padding(0);
            _developers.Name = "developers";
            _developers.Size = new System.Drawing.Size(39, 13);
            _developers.TabIndex = 2;
            _developers.Text = developer.ToString();
            _developers.MouseDown += new MouseEventHandler(taskCardChild_MouseDown);
            // 
            // _developerLayoutPanel
            // 
            _developerLayoutPanel = new TableLayoutPanel();
            _developerLayoutPanel.ColumnCount = 2;
            _developerLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 42F));
            _developerLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 58F));
            _developerLayoutPanel.Controls.Add(_developerLabel, 0, 0);
            _developerLayoutPanel.Controls.Add(_developers, 1, 0);
            _developerLayoutPanel.Dock = DockStyle.Fill;
            _developerLayoutPanel.Location = new System.Drawing.Point(1, 83);
            _developerLayoutPanel.Margin = new Padding(0);
            _developerLayoutPanel.Name = "_develperLayouPanel";
            _developerLayoutPanel.RowCount = 1;
            _developerLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            _developerLayoutPanel.Size = new System.Drawing.Size(221, 15);
            _developerLayoutPanel.TabIndex = 0;
            // 
            // _testerLabel
            // 
            _testerLabel = new Label();
            _testerLabel.Anchor = AnchorStyles.Right;
            _testerLabel.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            _testerLabel.AutoSize = true;
            _testerLabel.Location = new System.Drawing.Point(34, 1);
            _testerLabel.Name = "_testerLabel";
            _testerLabel.Size = new System.Drawing.Size(51, 13);
            _testerLabel.TabIndex = 0;
            _testerLabel.Text = "Tester(s):";
            _testerLabel.MouseDown += new MouseEventHandler(taskCardChild_MouseDown);
            // 
            // _testers
            // 
            _testers = new Label();
            _testers.Anchor = AnchorStyles.Left;
            _testers.AutoEllipsis = true;
            _testers.AutoSize = true;
            _testers.Location = new System.Drawing.Point(88, 1);
            _testers.Margin = new Padding(0);
            _testers.Name = "testers";
            _testers.Size = new System.Drawing.Size(39, 13);
            _testers.TabIndex = 2;
            _testers.Text = tester.ToString();
            _testers.MouseDown += new MouseEventHandler(taskCardChild_MouseDown);
            // 
            // _testerLayoutPanel
            // 
            _testerLayoutPanel = new TableLayoutPanel();
            _testerLayoutPanel.ColumnCount = 2;
            _testerLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 42F));
            _testerLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 58F));
            _testerLayoutPanel.Controls.Add(_testerLabel, 0, 0);
            _testerLayoutPanel.Controls.Add(_testers, 1, 0);
            _testerLayoutPanel.Dock = DockStyle.Fill;
            _testerLayoutPanel.Location = new System.Drawing.Point(1, 99);
            _testerLayoutPanel.Margin = new Padding(0);
            _testerLayoutPanel.Name = "_testerLayoutPanel";
            _testerLayoutPanel.RowCount = 1;
            _testerLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            _testerLayoutPanel.Size = new System.Drawing.Size(221, 16);
            _testerLayoutPanel.TabIndex = 1;
            _testerLayoutPanel. MouseDown += new MouseEventHandler(taskCardChild_MouseDown);


            CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            ColumnCount = 1;
            ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            Controls.Add(_title, 0, 0);
            Controls.Add(_description, 0, 1);
            Controls.Add(_developerLayoutPanel, 0, 2);
            Controls.Add(_testerLayoutPanel, 0, 3);
            Cursor = Cursors.Default;
            Location = new System.Drawing.Point(0, 0);
            Name = "tableLayoutTask";
            RowCount = 4;
            RowStyles.Add(new RowStyle(SizeType.Percent, 13.63636F));
            RowStyles.Add(new RowStyle(SizeType.Percent, 59.09091F));
            RowStyles.Add(new RowStyle(SizeType.Percent, 13.63636F));
            RowStyles.Add(new RowStyle(SizeType.Percent, 13.63636F));
            Size = new System.Drawing.Size(223, 116);
            TabIndex = 0;     
            _childMouseDown += new MouseEventHandler(taskCard_ChildMouseDown);
        }

        private void taskCardChild_MouseDown(object sender, MouseEventArgs e)
        {
            taskCard_ChildMouseDown(sender, e);
        }

        private void taskCard_ChildMouseDown(object sender, MouseEventArgs e)
        {
            DoDragDrop(this, DragDropEffects.All);
        }  
    }
}
