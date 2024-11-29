using TaskManager.Models;
using TaskManager.Repository;

namespace TaskManager.Services

{
    public class UTaskService : IService<UTask>
    {
        private IRepository<UTask> uTaskRepository { get; }
        public UTaskService(IRepository<UTask> repository)
        {
            uTaskRepository = repository;
        }
        public void AddItem(UTask item)
        {
            uTaskRepository.Add(item);
        }

        public void DeleteItem(Guid id)
        {
            uTaskRepository.Delete(id);
        }

        public List<UTask> GetAllItems()
        {
            return uTaskRepository.LoadAllItems();
        }

        public UTask GetItemById(Guid id)
        {
            return uTaskRepository.LoadItemById(id);
        }

        public void UpdateItem(Guid id, Action<UTask> updateAction)
        {
            uTaskRepository.Update(id, updateAction);
        }
    }
}
