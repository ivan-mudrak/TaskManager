namespace TaskManager
{
    partial class TaskDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.labelTitle = new System.Windows.Forms.Label();
            this.richTextBoxTitle = new System.Windows.Forms.RichTextBox();
            this.labelDescription = new System.Windows.Forms.Label();
            this.richTextBoxDescription = new System.Windows.Forms.RichTextBox();
            this.labelDevelopers = new System.Windows.Forms.Label();
            this.comboBoxDevelopers = new System.Windows.Forms.ComboBox();
            this.labelTesters = new System.Windows.Forms.Label();
            this.comboBoxTesters = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // buttonSave
            //            
            this.buttonSave.Location = new System.Drawing.Point(228, 279);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(80, 30);
            this.buttonSave.TabIndex = 0;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_OnClick);
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(331, 279);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(80, 30);
            this.buttonCancel.TabIndex = 1;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_OnClick);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTitle.Location = new System.Drawing.Point(67, 26);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(42, 15);
            this.labelTitle.TabIndex = 2;
            this.labelTitle.Text = "Title";
            // 
            // richTextBoxTitle
            // 
            this.richTextBoxTitle.AcceptsTab = true;
            this.richTextBoxTitle.Location = new System.Drawing.Point(115, 24);
            this.richTextBoxTitle.MaxLength = 1000;
            this.richTextBoxTitle.Name = "richTextBoxTitle";
            this.richTextBoxTitle.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.richTextBoxTitle.Size = new System.Drawing.Size(296, 40);
            this.richTextBoxTitle.TabIndex = 3;
            this.richTextBoxTitle.Text = "";
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDescription.Location = new System.Drawing.Point(25, 82);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(84, 15);
            this.labelDescription.TabIndex = 4;
            this.labelDescription.Text = "Description";
            // 
            // richTextBoxDescription
            // 
            this.richTextBoxDescription.AcceptsTab = true;
            this.richTextBoxDescription.Location = new System.Drawing.Point(115, 80);
            this.richTextBoxDescription.MaxLength = 2000;
            this.richTextBoxDescription.Name = "richTextBoxDescription";
            this.richTextBoxDescription.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.richTextBoxDescription.Size = new System.Drawing.Size(296, 86);
            this.richTextBoxDescription.TabIndex = 5;
            this.richTextBoxDescription.Text = "";
            // 
            // labelDevelopers
            // 
            this.labelDevelopers.AutoSize = true;
            this.labelDevelopers.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDevelopers.Location = new System.Drawing.Point(11, 182);
            this.labelDevelopers.Name = "labelDevelopers";
            this.labelDevelopers.Size = new System.Drawing.Size(98, 15);
            this.labelDevelopers.TabIndex = 6;
            this.labelDevelopers.Text = "Developers(s)";
            // 
            // comboBoxDevelopers
            // 
            this.comboBoxDevelopers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDevelopers.FormattingEnabled = true;
            this.comboBoxDevelopers.Location = new System.Drawing.Point(115, 180);
            this.comboBoxDevelopers.Name = "comboBoxDevelopers";
            this.comboBoxDevelopers.Size = new System.Drawing.Size(154, 21);
            this.comboBoxDevelopers.TabIndex = 7;
            // 
            // labelTesters
            // 
            this.labelTesters.AutoSize = true;
            this.labelTesters.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTesters.Location = new System.Drawing.Point(39, 219);
            this.labelTesters.Name = "labelTesters";
            this.labelTesters.Size = new System.Drawing.Size(70, 15);
            this.labelTesters.TabIndex = 8;
            this.labelTesters.Text = "Tester(s)";
            // 
            // comboBoxTesters
            // 
            this.comboBoxTesters.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTesters.FormattingEnabled = true;
            this.comboBoxTesters.Location = new System.Drawing.Point(115, 217);
            this.comboBoxTesters.Name = "comboBoxTesters";
            this.comboBoxTesters.Size = new System.Drawing.Size(154, 21);
            this.comboBoxTesters.TabIndex = 9;
            // 
            // TaskDialog
            // 
            this.AcceptButton = this.buttonSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(434, 321);
            this.ControlBox = false;
            this.Controls.Add(this.comboBoxTesters);
            this.Controls.Add(this.labelTesters);
            this.Controls.Add(this.comboBoxDevelopers);
            this.Controls.Add(this.labelDevelopers);
            this.Controls.Add(this.richTextBoxDescription);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.richTextBoxTitle);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TaskDialog";
            this.Text = "NewTask";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.RichTextBox richTextBoxTitle;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.RichTextBox richTextBoxDescription;
        private System.Windows.Forms.Label labelDevelopers;
        private System.Windows.Forms.ComboBox comboBoxDevelopers;
        private System.Windows.Forms.Label labelTesters;
        private System.Windows.Forms.ComboBox comboBoxTesters;
    }
}