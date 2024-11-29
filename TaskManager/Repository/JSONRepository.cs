using Newtonsoft.Json;
using TaskManager.Models;

namespace TaskManager.Repository
{
    public class JSONRepository<T> : IRepository<T> where T : Model
    {
        private readonly string filePath = "UTaskList.json";

        public void Add(T item)
        {
            List<T> list = LoadAllItems();
            list.Add(item);
            Save(list);
        }
        public void Delete(Guid id)
        {
            List<T> list = LoadAllItems();
            list.RemoveAll(e => e.Id == id);
            Save(list);
        }
        public void Save(List<T> list)
        {
            string jsonData = JsonConvert.SerializeObject(list, Formatting.Indented);
            File.WriteAllText(filePath, jsonData);
        }
        public List<T> LoadAllItems()
        {
            if (File.Exists(filePath))
            {
                string JSONData = File.ReadAllText(filePath);
                List<T> list = JsonConvert.DeserializeObject<List<T>>(JSONData);
                return list;
            }
            else
            {
                return new List<T>();
            }
        }
        public void Update(Guid id, Action<T> updateAction)
        {
            List<T> list = LoadAllItems();
            var item = list.Find(e => e.Id == id);
            if (item != null)
            {
                updateAction(item);
                Save(list);
            }
            else
            {
                throw new KeyNotFoundException("Item not found");
            }
        }
        public T LoadItemById(Guid id)
        {
            List<T> list = LoadAllItems();
            T targetItem = list.Find(x => x.Id == id);
            return targetItem;
        }
    }
}
