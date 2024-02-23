namespace DiaryBot.Database.Repositories.Base
{
    public interface IRepository<T>
        where T : class
    {
        List<T> GetList(); // получение всех объектов
        T Get(int id); // получение одного объекта по id
        T Create(T item); // создание объекта
        T Update(T item); // обновление объекта
        bool Delete(int id); // удаление объекта по id
    }
}
