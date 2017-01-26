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
    public partial class TaskManager : Form
    {
        private Button buttonTask;

        public TaskManager()
        {
            InitializeComponent();

            this.buttonTask = new Button();
            this.buttonTask.AutoSize = true;
            this.buttonTask.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            this.buttonTask.BackColor = Color.White;
            this.buttonTask.Dock = DockStyle.Top;
            this.buttonTask.Location = new Point(3, 3);
            this.buttonTask.Name = "buttonTask";
            this.buttonTask.Size = new Size(192, 23);
            this.buttonTask.TabIndex = 0;
            this.buttonTask.Text = "Task";
            this.buttonTask.UseVisualStyleBackColor = false;
            this.buttonTask.MouseDown += new MouseEventHandler(this.buttonTask_MouseDown);

            this.tableLayoutBacklog.Controls.Add(this.buttonTask, 0, 0);

        }

        private void buttonTask_MouseDown(object sender, MouseEventArgs e)
        {          
            ((Control)sender).DoDragDrop(sender, DragDropEffects.All);
        }

        private void tableLayoutBody_DragDrop(object sender, DragEventArgs e)
        {            
            TableLayoutPanel layoutPanel = sender as TableLayoutPanel;
            layoutPanel.RowCount++;
            layoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));

            tableLayoutBacklog.Controls.Add(buttonTask, 0, layoutPanel.RowCount);
          //  ((Button)e.Data.GetData(typeof(Button))).BringToFront();
        }

        private void tableLayoutBody_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(Button)))
                e.Effect = DragDropEffects.All;
        }

    }
}
