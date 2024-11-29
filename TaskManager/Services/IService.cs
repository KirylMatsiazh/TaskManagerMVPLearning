using System;
using System.Collections.Generic;
using System.Linq;
using TaskManager.Models;

namespace TaskManager.Services
{
    public interface IService<T>
    {
        public List<T> GetAllItems();
        public T GetItemById(Guid id);
        public void AddItem(T item);
        public void DeleteItem(Guid id);
        public void UpdateItem(Guid id, Action<UTask> updateAction);
    }
}