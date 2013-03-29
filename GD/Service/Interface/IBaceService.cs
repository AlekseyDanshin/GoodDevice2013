using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GD.Models.Interface;

namespace GD.Service.Interface
{
    public interface IBaceService<T> where T: class,IBase,new()
    {
        //Получение всех записей из таблицы БД
        IQueryable<T> Get();

        //Получение одной записи с заданным ID
        T Get(int id);

        //Получение нескольких записей
        //Параметр skip - сколько первых записей пропустить, take - сколько записей получить
        IQueryable<T> Get(int skip, int take);

        //Добавление записи в таблицу
        void Add(T dataObject);

        //Удаление записи из таблицы
        void Delete(T dataObject);

        //Сохранение внесенных изменений
        void Save();
    }
}
