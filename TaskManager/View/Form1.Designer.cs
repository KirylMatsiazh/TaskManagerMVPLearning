namespace TaskManager
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            NameTextBox = new TextBox();
            DescriptionTextBox = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            DeadlineDateTimePicker = new DateTimePicker();
            groupBox1 = new GroupBox();
            AddTaskButton = new Button();
            label5 = new Label();
            StatusMessageLabel = new Label();
            TaskListPanel = new FlowLayoutPanel();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(160, 9);
            label1.Name = "label1";
            label1.Padding = new Padding(10);
            label1.Size = new Size(119, 40);
            label1.TabIndex = 0;
            label1.Text = "Task Manager";
            // 
            // NameTextBox
            // 
            NameTextBox.Location = new Point(61, 37);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(353, 27);
            NameTextBox.TabIndex = 1;
            // 
            // DescriptionTextBox
            // 
            DescriptionTextBox.Location = new Point(97, 89);
            DescriptionTextBox.Multiline = true;
            DescriptionTextBox.Name = "DescriptionTextBox";
            DescriptionTextBox.Size = new Size(317, 104);
            DescriptionTextBox.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 40);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 4;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 89);
            label3.Name = "label3";
            label3.Size = new Size(85, 20);
            label3.TabIndex = 5;
            label3.Text = "Description";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 215);
            label4.Name = "label4";
            label4.Size = new Size(69, 20);
            label4.TabIndex = 6;
            label4.Text = "Deadline";
            // 
            // DeadlineDateTimePicker
            // 
            DeadlineDateTimePicker.Location = new Point(97, 215);
            DeadlineDateTimePicker.Name = "DeadlineDateTimePicker";
            DeadlineDateTimePicker.Size = new Size(317, 27);
            DeadlineDateTimePicker.TabIndex = 7;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(AddTaskButton);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(DeadlineDateTimePicker);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(DescriptionTextBox);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(NameTextBox);
            groupBox1.Location = new Point(12, 54);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(420, 308);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Task";
            // 
            // AddTaskButton
            // 
            AddTaskButton.Location = new Point(148, 260);
            AddTaskButton.Name = "AddTaskButton";
            AddTaskButton.Size = new Size(121, 29);
            AddTaskButton.TabIndex = 8;
            AddTaskButton.Text = "Add to the list";
            AddTaskButton.UseVisualStyleBackColor = true;
            AddTaskButton.Click += AddTaskButton_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(18, 609);
            label5.Name = "label5";
            label5.Size = new Size(56, 20);
            label5.TabIndex = 10;
            label5.Text = "Status :";
            // 
            // StatusMessageLabel
            // 
            StatusMessageLabel.AutoSize = true;
            StatusMessageLabel.Location = new Point(80, 609);
            StatusMessageLabel.Name = "StatusMessageLabel";
            StatusMessageLabel.Size = new Size(283, 20);
            StatusMessageLabel.TabIndex = 11;
            StatusMessageLabel.Text = "You'll see here a status of your operations";
            // 
            // TaskListPanel
            // 
            TaskListPanel.AutoScroll = true;
            TaskListPanel.FlowDirection = FlowDirection.TopDown;
            TaskListPanel.Location = new Point(12, 368);
            TaskListPanel.Name = "TaskListPanel";
            TaskListPanel.Size = new Size(420, 223);
            TaskListPanel.TabIndex = 12;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(444, 652);
            Controls.Add(TaskListPanel);
            Controls.Add(StatusMessageLabel);
            Controls.Add(label5);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox NameTextBox;
        private TextBox DescriptionTextBox;
        private Label label2;
        private Label label3;
        private Label label4;
        private DateTimePicker DeadlineDateTimePicker;
        private GroupBox groupBox1;
        private Button AddTaskButton;
        private Label label5;
        private Label StatusMessageLabel;
        private FlowLayoutPanel TaskListPanel;
    }
}
