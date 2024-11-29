using TaskManager.Models;

namespace TaskManager.Repository
{
    public interface IRepository<T> where T : Model
    {
        public void Add(T item);
        public void Delete(Guid id);
        public void Save(List<T> list);
        public void Update(Guid id, Action<T> updateAction);
        public List<T> LoadAllItems();
        public T LoadItemById(Guid id);
    }
}