using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskManager
{
    public partial class TaskDialog : Form
    {
        public TaskDialog()
        {
            InitializeComponent();
        }

        private void buttonCancel_OnClick(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonSave_OnClick(object sender, EventArgs e)
        {
            string errorString = ValidateTask();
            if (errorString.Length > 0)
            {
                string errorMsgBoxCaption = "Error during save";
                MessageBoxButtons errorMsgBoxButtons = MessageBoxButtons.OK;
                MessageBox.Show(errorString, errorMsgBoxCaption, errorMsgBoxButtons, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private string ValidateTask()
        {
            StringBuilder errorStringBuilder = new StringBuilder();
            if (richTextBoxTitle.TextLength <= 0)
            {
                errorStringBuilder.AppendLine();
                errorStringBuilder.Append(labelTitle.Text);
            }
            if (richTextBoxDescription.TextLength <= 0)
            {
                errorStringBuilder.AppendLine();
                errorStringBuilder.Append(labelDescription.Text);
            }
            //if (comboBoxDevelopers.SelectedIndex == -1)
            //{
            //    errorStringBuilder.AppendLine();
            //    errorStringBuilder.Append(labelDevelopers.Text);
            //}
            //if (comboBoxTesters.SelectedIndex == -1)
            //{
            //    errorStringBuilder.AppendLine();
            //    errorStringBuilder.Append(labelTesters.Text);
            //}

            if (errorStringBuilder.Length > 0)
            {
                errorStringBuilder = (new StringBuilder("Please specify following info:")).Append(errorStringBuilder);
            }

            return errorStringBuilder.ToString();
        }




        public string Title
        {
            get { return richTextBoxTitle.Text; }
        }

        public string Description
        {
            get { return richTextBoxDescription.Text; }
        }

      

    }
}
