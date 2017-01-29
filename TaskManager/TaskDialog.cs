using System;
using System.Collections.Generic;
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

        private void buttonOk_OnClick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonCancel_OnClick(object sender, EventArgs e)
        {
           
            this.Close();
        }
    }
}
