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

        private Button taskButton;
        private Point taskDragPoint;


        public TaskManager()
        {
            InitializeComponent();

            this.taskButton = new Button();

            this.taskButton.BackColor = Color.Aquamarine;
            this.taskButton.Dock = DockStyle.Top;
            this.taskButton.AllowDrop = true;
            this.taskButton.Location = new Point(0, 0);
            this.taskButton.Name = "taskButton";
            this.taskButton.Size = new Size(200, 40);
            this.taskButton.TabIndex = 0;
            this.taskButton.Text = "Task";
            this.taskButton.UseVisualStyleBackColor = false;
            this.taskButton.MouseDown += this.taskButton_MouseDown;
            this.taskButton.MouseDown += this.button1_OnClick;



            this.tableLayoutPanel1.Controls.Add(this.taskButton, 0, 0);

        }

        private void TaskManager_Load(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel_DragDrop(object sender, DragEventArgs e)
        {
            ((Button)e.Data.GetData(typeof(Button))).BringToFront();
        }

        private void tableLayoutPanel_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(Button)))
                e.Effect = DragDropEffects.All;
        }

        private void taskButton_OnClick(object sender, MouseEventArgs e)
        {
            int i = 0;
        }

        private void taskButton_MouseDown(object sender, MouseEventArgs e)
        {
            taskDragPoint = new Point(e.X, e.Y);        
            ((Control)sender).DoDragDrop(sender, DragDropEffects.All);
        }  

        private void tableLayoutPanel_DragOver(object sender, DragEventArgs e)
        {
            ((Control)e.Data.GetData(typeof(Button))).Location =
                this.PointToClient(new Point(e.X - taskDragPoint.X, e.Y - taskDragPoint.Y));
            ((Control)e.Data.GetData(typeof(Button))).BringToFront();
        }

        private void button1_OnClick(object sender, EventArgs e)
        {
            int i = 0;
        }

   

    }
}
