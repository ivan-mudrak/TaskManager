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
        struct Error
        {
            private Control errorControl;
            private string errorMsg;
        }

        private Collection<Error> errorCollection;

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

        }

        private bool Validate(Collection<Control> controlsCollection)
        {
            return true;
        }
    }
}
