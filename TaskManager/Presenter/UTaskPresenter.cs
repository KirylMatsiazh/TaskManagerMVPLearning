using TaskManager.Models;
using TaskManager.Services;

namespace TaskManager.Presenter
{
    public class UTaskPresenter
    {
        private readonly IService<UTask> uTaskService;

        public UTaskPresenter(IService<UTask> service)
        {
            uTaskService = service;
        }

        public void AddUTask(string name, string description, DateTime deadline)
        {
            UTask newUTask = new UTask(name, description, deadline);
            uTaskService.AddItem(newUTask);
        }
        public void DeleteUTask(Guid id)
        {
            uTaskService.DeleteItem(id);
        }
        public void UpdateUTask(Guid id, string newName, string newDescription, DateTime newDeadline)
        {
            uTaskService.UpdateItem(id, task =>
            {
                task.Name = newName;
                task.Description = newDescription;
                task.Deadline = newDeadline;
            });
        }
        public List<UTask> GetAllUTasks()
        {
            return uTaskService.GetAllItems();
        }
        public (string, string, DateTime, Guid) GetTaskById(Guid id)
        {
            UTask task = uTaskService.GetItemById(id);
            return(task.Name, task.Description, task.Deadline, id);
        }
    }
}
