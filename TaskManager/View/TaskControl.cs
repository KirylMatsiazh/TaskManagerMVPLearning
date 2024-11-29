namespace TaskManager
{
    public partial class TaskControl : UserControl
    {
        public readonly string TaskName;
        public readonly Guid TaskId;
        public TaskControl(string taskName, Guid taskId)
        {
            InitializeComponent();
            Name = taskName;
            TaskId = taskId;
            TaskNameLabel.Text = taskName;

            DeleteTaskButton.Click += DeleteButton_Click;
            UpdateTaskButton.Click += UpdateButton_Click;
        }

        public event EventHandler UpdateClicked;
        public event EventHandler DeleteClicked;

        public void UpdateButton_Click(object sender, EventArgs e)
        {
            UpdateClicked?.Invoke(this, e);
        }
        public void DeleteButton_Click(object sender, EventArgs e)
        {
            DeleteClicked?.Invoke(this, e);
        }
    }
}
