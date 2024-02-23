using DiaryBot.Database.Models;
using iaryBot.Database.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace DiaryServer.Interfaces
{
    public interface ICRUDable<T> where T : class
    {
        public IEnumerable<T> GetAll();
        public T Get(int id);
        public T Create(T obj);
        public T Update(T obj);
        public IActionResult Delete(int id);
    }
}
