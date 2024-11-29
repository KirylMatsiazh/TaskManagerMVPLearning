namespace TaskManager
{
    partial class TaskControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            UpdateTaskButton = new Button();
            DeleteTaskButton = new Button();
            TaskNameLabel = new Label();
            SuspendLayout();
            // 
            // UpdateTaskButton
            // 
            UpdateTaskButton.Location = new Point(215, 2);
            UpdateTaskButton.Name = "UpdateTaskButton";
            UpdateTaskButton.Size = new Size(94, 29);
            UpdateTaskButton.TabIndex = 0;
            UpdateTaskButton.Text = "Update";
            UpdateTaskButton.UseVisualStyleBackColor = true;
            // 
            // DeleteTaskButton
            // 
            DeleteTaskButton.Location = new Point(315, 2);
            DeleteTaskButton.Name = "DeleteTaskButton";
            DeleteTaskButton.Size = new Size(94, 29);
            DeleteTaskButton.TabIndex = 1;
            DeleteTaskButton.Text = "Delete";
            DeleteTaskButton.UseVisualStyleBackColor = true;
            // 
            // TaskNameLabel
            // 
            TaskNameLabel.AutoSize = true;
            TaskNameLabel.Location = new Point(3, 6);
            TaskNameLabel.Name = "TaskNameLabel";
            TaskNameLabel.Size = new Size(49, 20);
            TaskNameLabel.TabIndex = 2;
            TaskNameLabel.Text = "Name";
            // 
            // TaskControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(TaskNameLabel);
            Controls.Add(DeleteTaskButton);
            Controls.Add(UpdateTaskButton);
            Name = "TaskControl";
            Size = new Size(412, 34);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button UpdateTaskButton;
        private Button DeleteTaskButton;
        private Label TaskNameLabel;
    }
}
