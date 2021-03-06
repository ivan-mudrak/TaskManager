﻿using System;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace TaskManager
{
    class BodyPanelAdmin : BodyPanel
    {
        private const string NewUserNodeName = "NewUserNodeName";
        private TableLayoutPanel tableLayoutPanelUserInfo;
        private Label labelUser;
        private Label labelFirstName;
        private GroupBox activeGroupBox;
        private GroupBox groupBoxTeams;
        private GroupBox groupBoxUserInfo;
        private Label labelSecondName;
        private Label labelRole;
        private Label labelSeniority;
        private Label labelTeam;
        private Label labelPassword;
        private Button buttonSave;
        private Button buttonCancel;
        private TextBox textBoxUser;
        private TextBox textBoxSecondName;
        private TextBox textBoxFirstName;
        private TextBox textBoxPassword;
        private ComboBox comboBoxTeam;
        private ComboBox comboBoxSeniority;
        private ComboBox comboBoxRole;
        private TreeView treeViewUsers;
        private TreeNode treeNodeNewTeam;

        public BodyPanelAdmin(UsersEntity userEntity = null)
            : base(userEntity)
        {


            #region Layout

            tableLayoutPanelUserInfo = new TableLayoutPanel();
            labelUser = new Label();
            labelFirstName = new Label();
            groupBoxUserInfo = new GroupBox();
            labelSecondName = new Label();
            labelRole = new Label();
            labelSeniority = new Label();
            labelTeam = new Label();
            labelPassword = new Label();
            buttonSave = new Button();
            buttonCancel = new Button();
            textBoxUser = new TextBox();
            textBoxPassword = new TextBox();
            textBoxFirstName = new TextBox();
            textBoxSecondName = new TextBox();
            comboBoxRole = new ComboBox();
            comboBoxSeniority = new ComboBox();
            comboBoxTeam = new ComboBox();
            groupBoxTeams = new GroupBox();
            treeViewUsers = new TreeView();
            treeNodeNewTeam = new TreeNode();

            // 
            // tableLayoutBodyAdmin
            // 
            ColumnCount = 2;
            ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 55F));
            ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45F));
            Controls.Add(groupBoxUserInfo, 1, 0);
            Controls.Add(groupBoxTeams, 0, 0);
            Dock = DockStyle.Fill;
            Location = new Point(4, 75);
            Name = "tableLayoutBodyAdmin";
            RowCount = 1;
            RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            Size = new Size(976, 500);
            TabIndex = 0;

            // 
            // tableLayoutPanelUserInfo
            // 
            tableLayoutPanelUserInfo.BackColor = SystemColors.GradientActiveCaption;
            tableLayoutPanelUserInfo.ColumnCount = 2;
            tableLayoutPanelUserInfo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanelUserInfo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tableLayoutPanelUserInfo.Controls.Add(comboBoxTeam, 1, 7);
            tableLayoutPanelUserInfo.Controls.Add(comboBoxSeniority, 1, 6);
            tableLayoutPanelUserInfo.Controls.Add(textBoxSecondName, 1, 4);
            tableLayoutPanelUserInfo.Controls.Add(textBoxFirstName, 1, 3);
            tableLayoutPanelUserInfo.Controls.Add(textBoxPassword, 1, 2);
            tableLayoutPanelUserInfo.Controls.Add(labelUser, 0, 1);
            tableLayoutPanelUserInfo.Controls.Add(labelTeam, 0, 7);
            tableLayoutPanelUserInfo.Controls.Add(labelSeniority, 0, 6);
            tableLayoutPanelUserInfo.Controls.Add(labelRole, 0, 5);
            tableLayoutPanelUserInfo.Controls.Add(labelSecondName, 0, 4);
            tableLayoutPanelUserInfo.Controls.Add(labelFirstName, 0, 3);
            tableLayoutPanelUserInfo.Controls.Add(labelPassword, 0, 2);
            tableLayoutPanelUserInfo.Controls.Add(buttonCancel, 0, 9);
            tableLayoutPanelUserInfo.Controls.Add(buttonSave, 1, 9);
            tableLayoutPanelUserInfo.Controls.Add(textBoxUser, 1, 1);
            tableLayoutPanelUserInfo.Controls.Add(comboBoxRole, 1, 5);
            tableLayoutPanelUserInfo.Dock = DockStyle.Fill;
            tableLayoutPanelUserInfo.Location = new Point(3, 16);
            tableLayoutPanelUserInfo.Name = "tableLayoutPanelUserInfo";
            tableLayoutPanelUserInfo.Padding = new Padding(0, 0, 10, 0);
            tableLayoutPanelUserInfo.RowCount = 10;
            tableLayoutPanelUserInfo.RowStyles.Add(new RowStyle(SizeType.Percent, 4.109589F));
            tableLayoutPanelUserInfo.RowStyles.Add(new RowStyle(SizeType.Percent, 11.04447F));
            tableLayoutPanelUserInfo.RowStyles.Add(new RowStyle(SizeType.Percent, 11.04447F));
            tableLayoutPanelUserInfo.RowStyles.Add(new RowStyle(SizeType.Percent, 11.04447F));
            tableLayoutPanelUserInfo.RowStyles.Add(new RowStyle(SizeType.Percent, 11.04447F));
            tableLayoutPanelUserInfo.RowStyles.Add(new RowStyle(SizeType.Percent, 11.04447F));
            tableLayoutPanelUserInfo.RowStyles.Add(new RowStyle(SizeType.Percent, 11.04447F));
            tableLayoutPanelUserInfo.RowStyles.Add(new RowStyle(SizeType.Percent, 11.04447F));
            tableLayoutPanelUserInfo.RowStyles.Add(new RowStyle(SizeType.Percent, 10.27397F));
            tableLayoutPanelUserInfo.RowStyles.Add(new RowStyle(SizeType.Percent, 8.305163F));
            tableLayoutPanelUserInfo.Size = new Size(428, 475);
            tableLayoutPanelUserInfo.TabIndex = 1;
            // 
            // labelUser
            // 
            labelUser.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            labelUser.AutoSize = true;
            labelUser.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelUser.Location = new Point(119, 52);
            labelUser.Name = "labelUser";
            labelUser.Size = new Size(45, 19);
            labelUser.TabIndex = 0;
            labelUser.Text = "User";
            labelUser.TextAlign = ContentAlignment.MiddleRight;
            // 
            // labelFirstName
            // 
            labelFirstName.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            labelFirstName.AutoSize = true;
            labelFirstName.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelFirstName.Location = new Point(65, 156);
            labelFirstName.Name = "labelFirstName";
            labelFirstName.Size = new Size(99, 19);
            labelFirstName.TabIndex = 1;
            labelFirstName.Text = "First name";
            labelFirstName.TextAlign = ContentAlignment.MiddleRight;
            // 
            // groupBoxUserInfo
            // 
            groupBoxUserInfo.BackColor = SystemColors.GradientActiveCaption;
            groupBoxUserInfo.Controls.Add(tableLayoutPanelUserInfo);
            groupBoxUserInfo.Dock = DockStyle.Fill;
            groupBoxUserInfo.Location = new Point(539, 3);
            groupBoxUserInfo.Name = "groupBoxUserInfo";
            groupBoxUserInfo.Size = new Size(434, 494);
            groupBoxUserInfo.TabIndex = 1;
            groupBoxUserInfo.TabStop = false;
            groupBoxUserInfo.Text = "User info";
            // 
            // labelSecondName
            // 
            labelSecondName.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            labelSecondName.AutoSize = true;
            labelSecondName.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelSecondName.Location = new Point(56, 208);
            labelSecondName.Name = "labelSecondName";
            labelSecondName.Size = new Size(108, 19);
            labelSecondName.TabIndex = 2;
            labelSecondName.Text = "Second name";
            labelSecondName.TextAlign = ContentAlignment.MiddleRight;
            // 
            // labelRole
            // 
            labelRole.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            labelRole.AutoSize = true;
            labelRole.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelRole.Location = new Point(119, 260);
            labelRole.Name = "labelRole";
            labelRole.Size = new Size(45, 19);
            labelRole.TabIndex = 3;
            labelRole.Text = "Role";
            labelRole.TextAlign = ContentAlignment.MiddleRight;
            // 
            // labelSeniority
            // 
            labelSeniority.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            labelSeniority.AutoSize = true;
            labelSeniority.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelSeniority.Location = new Point(74, 312);
            labelSeniority.Name = "labelSeniority";
            labelSeniority.Size = new Size(90, 19);
            labelSeniority.TabIndex = 4;
            labelSeniority.Text = "Seniority";
            labelSeniority.TextAlign = ContentAlignment.MiddleRight;
            // 
            // labelTeam
            // 
            labelTeam.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            labelTeam.AutoSize = true;
            labelTeam.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelTeam.Location = new Point(119, 364);
            labelTeam.Name = "labelTeam";
            labelTeam.Size = new Size(45, 19);
            labelTeam.TabIndex = 5;
            labelTeam.Text = "Team";
            labelTeam.TextAlign = ContentAlignment.MiddleRight;
            // 
            // labelPassword
            // 
            labelPassword.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            labelPassword.AutoSize = true;
            labelPassword.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelPassword.Location = new Point(83, 104);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(81, 19);
            labelPassword.TabIndex = 6;
            labelPassword.Text = "Password";
            labelPassword.TextAlign = ContentAlignment.MiddleRight;
            // 
            // buttonSave
            // 
            buttonSave.Anchor = AnchorStyles.Left;
            buttonSave.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            buttonSave.Location = new Point(345, 438);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(70, 30);
            buttonSave.TabIndex = 8;
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Anchor = AnchorStyles.Right;
            buttonCancel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            buttonCancel.Location = new Point(345, 438);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(70, 30);
            buttonCancel.TabIndex = 8;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // textBoxUser
            // 
            textBoxUser.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            textBoxUser.Location = new Point(167, 51);
            textBoxUser.Margin = new Padding(0);
            textBoxUser.MaxLength = 100;
            textBoxUser.Name = "textBoxUser";
            textBoxUser.Size = new Size(142, 20);
            textBoxUser.TabIndex = 9;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            textBoxPassword.Location = new Point(167, 103);
            textBoxPassword.Margin = new Padding(0);
            textBoxPassword.MaxLength = 100;
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(142, 20);
            textBoxPassword.TabIndex = 10;
            // 
            // textBoxFirstName
            // 
            textBoxFirstName.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            textBoxFirstName.Location = new Point(167, 155);
            textBoxFirstName.Margin = new Padding(0);
            textBoxFirstName.MaxLength = 100;
            textBoxFirstName.Name = "textBoxFirstName";
            textBoxFirstName.Size = new Size(197, 20);
            textBoxFirstName.TabIndex = 11;
            // 
            // textBoxSecondName
            // 
            textBoxSecondName.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            textBoxSecondName.Location = new Point(167, 207);
            textBoxSecondName.Margin = new Padding(0);
            textBoxSecondName.MaxLength = 100;
            textBoxSecondName.Name = "textBoxSecondName";
            textBoxSecondName.Size = new Size(197, 20);
            textBoxSecondName.TabIndex = 12;
            // 
            // comboBoxRole
            // 
            comboBoxRole.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            comboBoxRole.FormattingEnabled = true;
            comboBoxRole.Location = new Point(167, 257);
            comboBoxRole.Margin = new Padding(0);
            comboBoxRole.Name = "comboBoxRole";
            comboBoxRole.Size = new Size(139, 21);
            comboBoxRole.TabIndex = 13;
            comboBoxRole.DataSource = Enum.GetValues(typeof(Roles))
                .Cast<Enum>()
                .Select(value => new
                {
                    (Attribute.GetCustomAttribute(value.GetType().GetField(value.ToString()),
                        typeof(DescriptionAttribute)) as DescriptionAttribute).Description,
                    value
                })
                .OrderBy(item => item.value)
                .ToList();
            comboBoxRole.DisplayMember = "Description";
            comboBoxRole.ValueMember = "value";
            // 
            // comboBoxSeniority
            // 
            comboBoxSeniority.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            comboBoxSeniority.FormattingEnabled = true;
            comboBoxSeniority.Location = new Point(167, 310);
            comboBoxSeniority.Margin = new Padding(0);
            comboBoxSeniority.Name = "comboBoxSeniority";
            comboBoxSeniority.Size = new Size(139, 21);
            comboBoxSeniority.TabIndex = 14;
            comboBoxSeniority.DataSource = Enum.GetValues(typeof(Seniorities))
                    .Cast<Enum>()
                    .Select(value => new
                    {
                        (Attribute.GetCustomAttribute(value.GetType().GetField(value.ToString()),
                        typeof(DescriptionAttribute)) as DescriptionAttribute).Description,
                        value
                    })
                    .OrderBy(item => item.value)
                    .ToList();
            comboBoxSeniority.DisplayMember = "Description";
            comboBoxSeniority.ValueMember = "value";            
            // 
            // comboBoxTeam
            // 
            comboBoxTeam.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            comboBoxTeam.Location = new Point(167, 363);
            comboBoxTeam.Margin = new Padding(0);
            comboBoxTeam.MaxLength = 100;
            comboBoxTeam.Name = "comboBoxTeam";
            comboBoxTeam.Size = new Size(142, 20);
            comboBoxTeam.TabIndex = 15;
            // 
            // groupBoxTeams
            // 
            groupBoxTeams.BackColor = SystemColors.GradientInactiveCaption;
            groupBoxTeams.Controls.Add(treeViewUsers);
            groupBoxTeams.Dock = DockStyle.Fill;
            groupBoxTeams.Location = new Point(3, 3);
            groupBoxTeams.Name = "groupBoxTeams";
            groupBoxTeams.Size = new Size(530, 494);
            groupBoxTeams.TabIndex = 2;
            groupBoxTeams.TabStop = false;
            groupBoxTeams.Text = "Teams";
            // 
            // treeViewUsers
            // 
            treeViewUsers.BackColor = SystemColors.GradientInactiveCaption;
            treeViewUsers.BorderStyle = BorderStyle.None;
            treeViewUsers.Dock = DockStyle.Fill;
            treeViewUsers.Font = new Font("Microsoft Sans Serif", 8.25F);
            treeViewUsers.FullRowSelect = true;
            treeViewUsers.Location = new Point(3, 16);
            treeViewUsers.Name = "treeViewUsers";
            treeNodeNewTeam.Name = "NodeNewTeam";
            treeNodeNewTeam.Text = " ... ";
            treeViewUsers.Nodes.AddRange(new[] {
            treeNodeNewTeam});
            treeViewUsers.Size = new Size(524, 475);
            treeViewUsers.TabIndex = 0;
            treeViewUsers.LabelEdit = true;
            treeViewUsers.ShowPlusMinus = true;
            treeViewUsers.NodeMouseDoubleClick += treeViewUsers_NodeMouseDoubleClick;
            treeViewUsers.AfterLabelEdit += treeViewUsers_AfterLabelEdit;
            #endregion

            LoadTeamsEntities();
            EnableControls(groupBoxTeams, false);
            EnableControls(groupBoxUserInfo, false);
            SetActiveGroupBox(groupBoxTeams);
        }

        private void EnableControls(Control control, bool state)
        {
            foreach (Control c in control.Controls)
            {
                c.Enabled = state;
            }
        }

        private void SetActiveGroupBox(GroupBox groupBox)
        {
            if (activeGroupBox != null) { EnableControls(activeGroupBox, false); }
            activeGroupBox = groupBox;
            EnableControls(activeGroupBox, true);
        }

        #region Teams

        private void treeViewUsers_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node.Equals(treeNodeNewTeam))
            {
                TreeNode treeNode = new TreeNode();
                treeNode.Nodes.Add(new TreeNode() { Name = NewUserNodeName, Text = " ... " });
                treeViewUsers.Nodes.Insert(treeViewUsers.Nodes.Count - 1, treeNode);
                treeNode.BeginEdit();

            }
            else if (e.Node.Name.Equals(NewUserNodeName))
            {
                SetActiveGroupBox(groupBoxUserInfo);
            }
            else
            {
                if (!e.Node.IsEditing)
                {
                    e.Node.BeginEdit();
                }
            }
        }

        private void treeViewUsers_AfterLabelEdit(object sender, NodeLabelEditEventArgs e)
        {
            if (!e.Node.Equals(treeNodeNewTeam) && !e.Node.Name.Equals(NewUserNodeName))
            {
                if (!string.IsNullOrEmpty(e.Label))
                {
                    e.Node.EndEdit(false);
                    e.Node.Text = e.Label;
                    //      SaveTeamEntity(new TeamsEntity { Name = e.Node.Text });
                }
                else
                {
                    e.CancelEdit = true;
                    MessageBox.Show("Team name cannot be blank", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    e.Node.BeginEdit();
                }
            }
        }

        #endregion

        #region User

        private void buttonCancel_Click(object sender, System.EventArgs e)
        {
            SetActiveGroupBox(groupBoxTeams);
        }

        private void buttonSave_Click(object sender, System.EventArgs e)
        {
            UsersEntity userEntity = new UsersEntity
            {
                Name = textBoxUser.Text,
                Password = textBoxPassword.Text,
                FirstName = textBoxFirstName.Text,
                SecondName = textBoxSecondName.Text,
                Role = (short)comboBoxRole.SelectedIndex,
                Seniority = (short)comboBoxSeniority.SelectedIndex,
            };

            SaveUserEntity(userEntity);
            SetActiveGroupBox(groupBoxTeams);
        }

        #endregion

        #region Entity

        private async void SaveUserEntity(UsersEntity userEntity)
        {
            using (var dbContainer = new DataModelContainer1())
            {
                await dbContainer.Database.Connection.OpenAsync();
                dbContainer.UsersEntitySet.Add(userEntity);
                await dbContainer.SaveChangesAsync();
                dbContainer.Database.Connection.Close();
            }

        }

        private async void SaveTeamEntity(TeamsEntity teamEntity)
        {
            using (var dbContainer = new DataModelContainer1())
            {
                await dbContainer.Database.Connection.OpenAsync();
                dbContainer.TeamsEntitySet.Add(teamEntity);
                await dbContainer.SaveChangesAsync();
                dbContainer.Database.Connection.Close();
            }
        }

        private async void LoadTeamsEntities()
        {
            using (var dbContainer = new DataModelContainer1())
            {
                await dbContainer.Database.Connection.OpenAsync();
                IQueryable<TeamsEntity> teamsEntities = from team in dbContainer.TeamsEntitySet
                                                        select team;
                foreach (var teamsEntity in teamsEntities)
                {
                    treeViewUsers.Nodes.Insert(treeViewUsers.Nodes.Count - 1, new TreeNode() { Text = teamsEntity.Name });
                }
                dbContainer.Database.Connection.Close();
            }
        }

        #endregion
    }
}
