using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface IRepository<T> where T : class 
    {
        void Create(T item);                //создание
        T Read(int id);                     //получение объекта по id
        void Update(T item);                //обновление
        void Delete(int id);                //удаление обьекта

        void Save();                        //сохранение изменений

        IEnumerable<T> GetAll();            //Получение всех объектов
    }
}
