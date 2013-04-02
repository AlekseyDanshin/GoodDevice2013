<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GD.Models.Interface;
using GD.Service.Interface;
using System.Web.Mvc;


namespace GD.Controllers.Abstract
{
    public abstract class BaseController<T> : Controller where T: class,IBase, new()
    {
         // Объект для для работы с данными
        protected IBaceService<T> service;

        // Параметризованный конструктор
        public BaseController(IBaceService<T> _service)
        {
            service = _service;
        }

        #region Actions

        // Получение списка объектов
        public virtual ActionResult Index()
        {
            IEnumerable<T> objs = service.Get();
            return View(objs);
        }

        // Получение объекта по его ID
        public virtual ActionResult Details(int id)
        {
            T obj = service.Get(id);
            if (obj == null) return View("NotFound");
            return View(obj);
        }

        // Открытие формы создания объекта
        public virtual ActionResult Create()
        {
            return View();
        }

        // Обработка формы создания объекта
        [HttpPost]
        public virtual ActionResult Create(FormCollection collection)
        {
            if (ModelState.IsValid)
            {
                T obj = new T();
                ChangeFormCollectionValues(obj, collection);
                UpdateModel(obj, collection);
                AddValuesOnCreate(obj);

                service.Add(obj);
                service.Save();

                return OnCreated(obj);
            }
            else return View();
        }

        // Открытие формы редактирование объекта
        public virtual ActionResult Edit(int id)
        {
            T obj = service.Get(id);
            if (obj == null) return View("NotFound");
            return View(obj);
        }

        // Обработка формы редактирования объекта
        [HttpPost]
        public virtual ActionResult Edit(int id, FormCollection collection)
        {
            T obj = service.Get(id);

            if (ModelState.IsValid)
            {
                ChangeFormCollectionValues(obj, collection);
                UpdateModel(obj, collection);
                service.Save();

                return OnEdited(obj);
            }
            else return View(obj);
        }

        // Открытие страницы с подтверждением удаления объекта
        public virtual ActionResult Delete(int id)
        {
            T obj = service.Get(id);
            if (obj == null) return View("NotFound");
            return View(obj);
        }

        // Удаление объекта после подтверждения
        [HttpPost]
        public virtual ActionResult Delete(int id, FormCollection collection)
        {
            T obj = service.Get(id);
            if (obj == null) return View("NotFound");

            if (!obj.CanBeDeleted()) return View("DeleteFail", obj);

            ActionResult onDeleted = OnDeleted(obj);

            OnDelete(obj);
            service.Delete(obj);
            service.Save();
            return onDeleted;
        }

        #endregion

        #region Virtual methods

        // Перенаправление к странице списка объектов
        protected virtual ActionResult ReturnToList(T obj)
        {
            return RedirectToAction("Index");
        }

        // Перенаправление к странице объекта
        protected virtual ActionResult ReturnToObject(T obj)
        {
            return RedirectToAction("Details", new { id = obj.id_товара });
        }

        // Перенаправление после создания объекта
        protected virtual ActionResult OnCreated(T obj)
        {
            return ReturnToObject(obj);
        }

        // Перенаправление после редактирования объекта
        protected virtual ActionResult OnEdited(T obj)
        {
            return ReturnToObject(obj);
        }

        // Перенаправление после удаления объекта
        protected virtual ActionResult OnDeleted(T obj)
        {
            return ReturnToList(obj);
        }

        // Изменение значений, полученных с формы создания/редактирования
        protected virtual void ChangeFormCollectionValues(T obj, FormCollection collection) { }

        // Автоматическое добавление свойств объекта, не получаемых с формы создания объекта
        protected virtual void AddValuesOnCreate(T obj) { }

        // Действия при удалении объекта
        protected virtual void OnDelete(T obj) { }

        #endregion
    
    }
=======
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GD.Models.Interface;
using GD.Service.Interface;
using System.Web.Mvc;


namespace GD.Controllers.Abstract
{
    public abstract class BaseController<T> : Controller where T: class,IBase, new()
    {
         // Объект для для работы с данными
        protected IBaceService<T> service;

        // Параметризованный конструктор
        public BaseController(IBaceService<T> _service)
        {
            service = _service;
        }

        #region Actions

        // Получение списка объектов
        public virtual ActionResult Index()
        {
            IEnumerable<T> objs = service.Get();
            return View(objs);
        }

        // Получение объекта по его ID
        public virtual ActionResult Details(int id)
        {
            T obj = service.Get(id);
            if (obj == null) return View("NotFound");
            return View(obj);
        }

        // Открытие формы создания объекта
        public virtual ActionResult Create()
        {
            return View();
        }

        // Обработка формы создания объекта
        [HttpPost]
        public virtual ActionResult Create(FormCollection collection)
        {
            if (ModelState.IsValid)
            {
                T obj = new T();
                ChangeFormCollectionValues(obj, collection);
                UpdateModel(obj, collection);
                AddValuesOnCreate(obj);

                service.Add(obj);
                service.Save();

                return OnCreated(obj);
            }
            else return View();
        }

        // Открытие формы редактирование объекта
        public virtual ActionResult Edit(int id)
        {
            T obj = service.Get(id);
            if (obj == null) return View("NotFound");
            return View(obj);
        }

        // Обработка формы редактирования объекта
        [HttpPost]
        public virtual ActionResult Edit(int id, FormCollection collection)
        {
            T obj = service.Get(id);

            if (ModelState.IsValid)
            {
                ChangeFormCollectionValues(obj, collection);
                UpdateModel(obj, collection);
                service.Save();

                return OnEdited(obj);
            }
            else return View(obj);
        }

        // Открытие страницы с подтверждением удаления объекта
        public virtual ActionResult Delete(int id)
        {
            T obj = service.Get(id);
            if (obj == null) return View("NotFound");
            return View(obj);
        }

        // Удаление объекта после подтверждения
        [HttpPost]
        public virtual ActionResult Delete(int id, FormCollection collection)
        {
            T obj = service.Get(id);
            if (obj == null) return View("NotFound");

            if (!obj.CanBeDeleted()) return View("DeleteFail", obj);

            ActionResult onDeleted = OnDeleted(obj);

            OnDelete(obj);
            service.Delete(obj);
            service.Save();
            return onDeleted;
        }

        #endregion

        #region Virtual methods

        // Перенаправление к странице списка объектов
        protected virtual ActionResult ReturnToList(T obj)
        {
            return RedirectToAction("Index");
        }

        // Перенаправление к странице объекта
        protected virtual ActionResult ReturnToObject(T obj)
        {
            return RedirectToAction("Details", new { id = obj.id_товара });
        }

        // Перенаправление после создания объекта
        protected virtual ActionResult OnCreated(T obj)
        {
            return ReturnToObject(obj);
        }

        // Перенаправление после редактирования объекта
        protected virtual ActionResult OnEdited(T obj)
        {
            return ReturnToObject(obj);
        }

        // Перенаправление после удаления объекта
        protected virtual ActionResult OnDeleted(T obj)
        {
            return ReturnToList(obj);
        }

        // Изменение значений, полученных с формы создания/редактирования
        protected virtual void ChangeFormCollectionValues(T obj, FormCollection collection) { }

        // Автоматическое добавление свойств объекта, не получаемых с формы создания объекта
        protected virtual void AddValuesOnCreate(T obj) { }

        // Действия при удалении объекта
        protected virtual void OnDelete(T obj) { }

        #endregion
    
    }
>>>>>>> c7e45a48a6cf0f4860bd4cf8d431898ccfac393c
}