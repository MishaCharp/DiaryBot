﻿using DiaryBot.Database;
using DiaryBot.Database.Models;
using DiaryBot.Database.Repositories.Base;

namespace DiaryBot.Database.Repositories
{
    public class UserRepository : IRepository<User>
    {
        private ApplicationContext _context;

        public UserRepository(ApplicationContext context)
        {
            _context = context;
        }

        public User Create(User item)
        {
            _context.User.Add(item);
            _context.SaveChanges();

            return item;
        }

        public bool Delete(int id)
        {
            var obj = _context.User.Find(id);
            if (obj != null)
            {
                _context.User.Remove(obj);
                _context.SaveChanges();
                return true;
            }
            else return false;
        }

        public User Get(int id)
        {
            var obj = _context.User.Find(id);
            if (obj == null) return null;
            else return obj;
        }

        public List<User> GetList() => _context.User.ToList();

        public User Update(User item)
        {
            var obj = _context.User.Find(item.Id);

            obj.Surname = item.Surname;
            obj.Name = item.Name;
            obj.Patronymic = item.Patronymic;
            obj.Login = item.Login;
            obj.Password = item.Password;

            _context.User.Update(obj);
            _context.SaveChanges();

            return obj;
        }
    }
}
