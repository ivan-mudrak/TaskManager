using System;
using System.Drawing;
using System.Windows.Forms;
using JetBrains.Annotations;

namespace TaskManager
{
    class HeaderPanelUser : HeaderPanel
    {
        private Label labelFullRole;
        private Label labelFullName;
        private Label labelTeam;
        private Button buttonLogOut;
        private Users _user;
        private Action<Users> _userAction;

        public HeaderPanelUser(Action<Users> userAction, [NotNull] Users user)
            : base(userAction, user)
        {

            _userAction = userAction;
            _user = user;
            labelFullName = new Label();
            labelFullRole = new Label();
            labelTeam = new Label();
            buttonLogOut = new Button();


            // 
            // tableLayoutPanel2
            // 
            BackColor = SystemColors.ActiveCaption;
            ColumnCount = 3;
            ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            Controls.Add(labelFullRole, 1, 0);
            Controls.Add(labelFullName, 0, 0);
            Controls.Add(labelTeam, 1, 1);
            Controls.Add(buttonLogOut, 2, 0);
            Dock = DockStyle.Fill;
            Location = new Point(4, 4);
            Name = "tableLayoutHeaderUser";
            RowCount = 2;
            RowStyles.Add(new RowStyle(SizeType.Percent, 60F));
            RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            Size = new Size(976, 64);
            TabIndex = 1;
            // 
            // labelFullName
            // 
            labelFullName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            labelFullName.AutoSize = true;
            labelFullName.Font = new Font("Consolas", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelFullName.Location = new Point(3, 8);
            labelFullName.Name = "labelFullName";
            labelFullName.Size = new Size(482, 22);
            labelFullName.TabIndex = 0;
            labelFullName.Text = _user.FirstName + ", " + _user.SecondName;
            labelFullName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelFullRole
            // 
            labelFullRole.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            labelFullRole.AutoSize = true;
            labelFullRole.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelFullRole.Location = new Point(491, 9);
            labelFullRole.Name = "labelFullRole";
            labelFullRole.Size = new Size(384, 19);
            labelFullRole.TabIndex = 2;
            labelFullRole.Text = Enum.GetNames(typeof(Seniorities))[_user.Seniority] + " " + Enum.GetNames(typeof(Roles))[_user.Role];
            labelFullRole.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelTeam
            // 
            labelTeam.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom)
                               | AnchorStyles.Left;
            labelTeam.AutoSize = true;
            labelTeam.Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelTeam.Location = new Point(491, 38);
            labelTeam.Name = "labelTeam";
            labelTeam.Size = new Size(35, 26);
            labelTeam.TabIndex = 3;
            labelTeam.Text = _user.Teams.Name;
            labelTeam.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // buttonLogOut
            // 
            buttonLogOut.Anchor = AnchorStyles.None;
            buttonLogOut.Location = new Point(882, 4);
            buttonLogOut.Name = "buttonLogOut";
            buttonLogOut.Size = new Size(90, 30);
            buttonLogOut.TabIndex = 4;
            buttonLogOut.Text = "LogOut";
            buttonLogOut.UseVisualStyleBackColor = true;
            buttonLogOut.Click += buttonLogOut_Click;

        }

        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            _userAction(null);
        }
    }
}
