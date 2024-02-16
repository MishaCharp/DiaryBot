﻿namespace DiaryBot.Database.Repositories.Base
{
    public interface IRepository<T>
        where T : class
    {
        List<T> GetList(); // получение всех объектов
        T Get(int id); // получение одного объекта по id
        void Create(T item); // создание объекта
        void Update(T item); // обновление объекта
        void Delete(int id); // удаление объекта по id
    }
}
