using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace TaskManager
{
    class HeaderPanelLogIn : HeaderPanel
    {
        private readonly Button _buttonLogIn;
        private readonly Label _labelPassword;
        private readonly TextBox _textBoxPassword;
        private readonly Label _labelUser;
        private readonly TextBox _textBoxUser;
        private Action<UsersEntity> _userChangedAction;

        public HeaderPanelLogIn(Action<UsersEntity> userChangedAction, UsersEntity userEntity = null)
            : base(userChangedAction, userEntity)
        {
            _userChangedAction = userChangedAction;
            _buttonLogIn = new Button();
            _labelPassword = new Label();
            _textBoxPassword = new TextBox();
            _labelUser = new Label();
            _textBoxUser = new TextBox();

            // 
            // tableLayoutHeader
            // 
            BackColor = Color.PowderBlue;
            ColumnCount = 6;
            ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            Controls.Add(_buttonLogIn, 5, 0);
            Controls.Add(_labelPassword, 3, 0);
            Controls.Add(_textBoxPassword, 4, 0);
            Controls.Add(_labelUser, 1, 0);
            Controls.Add(_textBoxUser, 2, 0);
            Dock = DockStyle.Fill;
            Location = new Point(4, 4);
            Name = "tableLayoutHeader";
            RowCount = 1;
            RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            Size = new Size(976, 64);
            TabIndex = 1;
            // 
            // buttonLogIn
            // 
            _buttonLogIn.Anchor = AnchorStyles.None;
            _buttonLogIn.Font = new Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            _buttonLogIn.Location = new Point(891, 17);
            _buttonLogIn.Name = "buttonLogIn";
            _buttonLogIn.Size = new Size(70, 30);
            _buttonLogIn.TabIndex = 2;
            _buttonLogIn.Text = "LogIn";
            _buttonLogIn.UseVisualStyleBackColor = true;
            _buttonLogIn.Click += buttonLogIn_Click;
            // 
            // labelPassword
            // 
            _labelPassword.Anchor = AnchorStyles.Right;
            _labelPassword.AutoSize = true;
            _labelPassword.FlatStyle = FlatStyle.Flat;
            _labelPassword.Font = new Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            _labelPassword.Location = new Point(647, 23);
            _labelPassword.Name = "labelPassword";
            _labelPassword.Size = new Size(80, 18);
            _labelPassword.TabIndex = 3;
            _labelPassword.Text = "Password:";
            // 
            // textBoxPassword
            // 
            _textBoxPassword.Anchor = AnchorStyles.Left;
            _textBoxPassword.Location = new Point(733, 22);
            _textBoxPassword.Name = "textBoxPassword";
            _textBoxPassword.PasswordChar = '*';
            _textBoxPassword.Size = new Size(140, 20);
            _textBoxPassword.TabIndex = 1;
            _textBoxPassword.KeyPress += _textBox_KeyPress;

            // 
            // labelUser
            // 
            _labelUser.Anchor = AnchorStyles.Right;
            _labelUser.AutoSize = true;
            _labelUser.FlatStyle = FlatStyle.Flat;
            _labelUser.Font = new Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            _labelUser.Location = new Point(436, 23);
            _labelUser.Name = "labelUser";
            _labelUser.Size = new Size(48, 18);
            _labelUser.TabIndex = 5;
            _labelUser.Text = "User:";
            // 
            // textBoxUser
            // 
            _textBoxUser.Anchor = AnchorStyles.Left;
            _textBoxUser.Location = new Point(490, 22);
            _textBoxUser.Name = "textBoxUser";
            _textBoxUser.Size = new Size(140, 20);
            _textBoxUser.TabIndex = 0;
            _textBoxUser.KeyPress += _textBox_KeyPress;

        }

        private void _textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                FindUserDB();
            }
        }

        private void buttonLogIn_Click(object sender, EventArgs e)
        {
            FindUserDB();
        }

        private async void FindUserDB()
        {

            using (var dbContainer = new DataModelContainer1())
            {
                await dbContainer.Database.Connection.OpenAsync();

                IQueryable<UsersEntity> users = from user in dbContainer.UsersEntitySet
                                          where user.Name.Equals(_textBoxUser.Text) && user.Password.Equals(_textBoxPassword.Text)
                                          select user;
                dbContainer.Database.Connection.Close();


                if (users.Count() == 1)
                {
                    _userChangedAction(users.First());
                }
                    //TODO: improve error message                   
                else
                {
                    string message = "User \"" + _textBoxUser.Text + "\" was not found!";
                    MessageBox.Show(message, "Unknown user", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
