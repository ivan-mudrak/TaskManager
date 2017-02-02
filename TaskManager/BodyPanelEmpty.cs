using System.Drawing;
using System.Windows.Forms;

namespace TaskManager
{
    class BodyPanelEmpty : BodyPanel
    {

        private readonly Label _labelEmpty;     

        public BodyPanelEmpty(UsersEntity userEntity = null) : base(userEntity)
        {
            _labelEmpty = new Label();

            // 
            // tableLayoutPanel1
            // 
            ColumnCount = 1;
            ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            Controls.Add(_labelEmpty, 0, 0);
            Dock = DockStyle.Fill;
            Location = new Point(4, 75);
            Name = "tableLayoutEmpty";
            RowCount = 1;
            RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            Size = new Size(976, 500);
            TabIndex = 1;

            // 
            // labelEmpty
            // 
            _labelEmpty.AutoSize = true;
            _labelEmpty.BackColor = SystemColors.AppWorkspace;
            _labelEmpty.Dock = DockStyle.Fill;
            _labelEmpty.Location = new Point(0, 0);
            _labelEmpty.Margin = new Padding(0);
            _labelEmpty.Name = "labelEmpty";
            _labelEmpty.Size = new Size(976, 500);
            _labelEmpty.TabIndex = 0;
            _labelEmpty.Text = "Please, log in to see your board";
            _labelEmpty.TextAlign = ContentAlignment.MiddleCenter;

        }
    }
}
