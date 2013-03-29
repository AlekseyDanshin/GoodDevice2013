using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Objects;
using GD.Service.Interface;
using GD.Models.Interface;


namespace GD.Service.Abstract
{
    public abstract class BaseEntityService<T>: IBaceService<T> where T: class,IBase, new()
    {
        // Объект Entity Framework
        protected abstract ObjectSet<T> EntitySet { get; }

        // Получение полного списка объектов
        public virtual IQueryable<T> Get()
        {
            return from obj in EntitySet select obj;
        }

        // Получение объекта по его ID
        public virtual T Get(int id)
        {
            return (from obj in EntitySet where obj.id_товара == id select obj).FirstOrDefault();
        }

        // Получение неполного списка объекта
        // skip - сколько первых записей пропустить, take - сколько записей получить
        public virtual IQueryable<T> Get(int skip, int take)
        {
            return Get().Skip(skip).Take(take);
        }

        // Добавление объекта
        public virtual void Add(T dataObject)
        {
            EntitySet.AddObject(dataObject);
        }

        // Удаление объекта
        public virtual void Delete(T dataObject)
        {
            EntitySet.DeleteObject(dataObject);
        }

        // Сохранение изменений
        public void Save()
        {
            EntitySet.Context.SaveChanges();
        }
    }
}