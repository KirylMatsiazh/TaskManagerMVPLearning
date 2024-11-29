using TaskManager.Presenter;
using TaskManager;

namespace TaskManager
{
    public partial class Form1 : Form
    {
        private UTaskPresenter uTaskPresenter;

        public Form1(UTaskPresenter uTaskPresenter)
        {
            InitializeComponent();
            this.uTaskPresenter = uTaskPresenter;
            DisplayUTasks();
        }

        private void TaskControlUpdateButtonClicked(object sender, EventArgs e)
        {
            AddTaskButton.Text = "Update";

            TaskControl taskControl = sender as TaskControl;
            Guid id = taskControl.TaskId;
            var currentTaskData = uTaskPresenter.GetTaskById(id);

            NameTextBox.Text = currentTaskData.Item1;
            DescriptionTextBox.Text = currentTaskData.Item2;
            DeadlineDateTimePicker.Value = currentTaskData.Item3;

            AddTaskButton.Click -= AddTaskButton_Click;
            AddTaskButton.Click -= TaskControlUpdateButtonClicked;

            

            EventHandler updateHandler = (s, args) =>
            {
                uTaskPresenter.UpdateUTask(id, NameTextBox.Text, DescriptionTextBox.Text, DeadlineDateTimePicker.Value);

                AddTaskButton.Text = "Add Task";
                AddTaskButton.Click -= TaskControlUpdateButtonClicked;
                AddTaskButton.Click += AddTaskButton_Click;
                

                NameTextBox.Clear();
                DescriptionTextBox.Clear();
                DeadlineDateTimePicker.Value = DateTime.Now;

                DisplayUTasks();

                StatusMessageLabel.Text = ($"Task has been updated");

            };

            AddTaskButton.Click += updateHandler;
        }
        private void TaskControlDeleteButtonClicked(object sender, EventArgs e)
        {
            TaskControl control = (TaskControl)sender;

            uTaskPresenter.DeleteUTask(control.TaskId);

            DisplayUTasks();

            StatusMessageLabel.Text = $"Task has been deleted";
        }

        private void AddTaskButton_Click(object sender, EventArgs e)
        {
            string createdTaskName = NameTextBox.Text;
            string createdTaskDescription = DescriptionTextBox.Text;
            DateTime createdTaskDeadline = DeadlineDateTimePicker.Value;

            NameTextBox.Text = "";
            DescriptionTextBox.Text = "";

            uTaskPresenter.AddUTask(createdTaskName, createdTaskDescription, createdTaskDeadline);

            DisplayUTasks();

            StatusMessageLabel.Text = ($"Task has been added");
        }
        private void DisplayUTasks()
        {
            var tasks = uTaskPresenter.GetAllUTasks();

            TaskListPanel.Controls.Clear();
            if (tasks != null)
            {
                foreach (var task in tasks)
                {
                    TaskControl taskControl = new TaskControl(task.Name, task.Id);
                    taskControl.UpdateClicked += TaskControlUpdateButtonClicked;
                    taskControl.DeleteClicked += TaskControlDeleteButtonClicked;

                    TaskListPanel.Controls.Add(taskControl);
                }
            }
                
            
        }
    }
}
