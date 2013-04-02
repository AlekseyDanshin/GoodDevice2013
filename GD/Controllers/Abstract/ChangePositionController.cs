<<<<<<< HEAD
<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GD.Models.Interface;
using GD.Service.Interface;

namespace GD.Controllers.Abstract
{
    public abstract class ChangePositionController<T> : BaseController<T> where T : class,IChangePosition, new()
    {
        public ChangePositionController(IChangePositionService<T> _service) : base(_service) { }

        #region Actions

        // Перемещение объекта вверх
        public ActionResult Up(int id)
        {
            T obj = service.Get(id);

            if (obj == null) return View("NotFound");
            else
            {
                if (obj.Порядковый_номер.HasValue)
                {
                    T next = (service as IChangePositionService<T>).GetNext(obj);

                    if (next != null)
                    {
                        int? curSeq = obj.Порядковый_номер;
                        int? nextSeq = next.Порядковый_номер;

                        obj.Порядковый_номер = nextSeq;
                        next.Порядковый_номер = curSeq;
                        service.Save();
                    }
                }

                return OnDown(obj);
            }
        }

        // Перемещение объекта вниз
        public ActionResult Down(int id)
        {
            T obj = service.Get(id);

            if (obj == null) return View("NotFound");
            else
            {
                if (obj.Порядковый_номер.HasValue)
                {
                    T previous = (service as IChangePositionService<T>).GetPrevious(obj);

                    if (previous != null)
                    {
                        int? curSeq = obj.Порядковый_номер;
                        int? prevSeq = previous.Порядковый_номер;

                        obj.Порядковый_номер = prevSeq;
                        previous.Порядковый_номер = curSeq;
                        service.Save();
                    }
                }

                return OnUp(obj);
            }
        }

        #endregion

        #region Virtual methods

        // Перенаправление после перемещения объекта вверх
        protected virtual ActionResult OnUp(T obj)
        {
            return ReturnToList(obj);
        }

        // Перенаправление после перемещения объекта вниз
        protected virtual ActionResult OnDown(T obj)
        {
            return ReturnToList(obj);
        }

        #endregion

        #region Overridden virtual methods

        // При создании объекта автоматически задаём ему значение Sequence, равное следующему после наибольшего
        protected override void AddValuesOnCreate(T obj)
        {
            base.AddValuesOnCreate(obj);
            obj.Порядковый_номер = GetNextSequence(service.Get().Select(item => item.Порядковый_номер));
        }

        #endregion

        #region Methods

        // Получаем значение Sequence, следующее после наибольшего
        protected virtual int GetNextSequence(IQueryable<int?> seqs)
        {
            if (seqs.Count() == 0) return 1;
            else
            {
                int? iMax = seqs.Max();
                if (iMax.HasValue) return iMax.Value + 1;
                else return 1;
            }
        }

        #endregion
    }
=======
=======
>>>>>>> c7e45a48a6cf0f4860bd4cf8d431898ccfac393c
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GD.Models.Interface;
using GD.Service.Interface;

namespace GD.Controllers.Abstract
{
    public abstract class ChangePositionController<T> : BaseController<T> where T : class,IChangePosition, new()
    {
        public ChangePositionController(IChangePositionService<T> _service) : base(_service) { }

        #region Actions

        // Перемещение объекта вверх
        public ActionResult Up(int id)
        {
            T obj = service.Get(id);

            if (obj == null) return View("NotFound");
            else
            {
                if (obj.Порядковый_номер.HasValue)
                {
                    T next = (service as IChangePositionService<T>).GetNext(obj);

                    if (next != null)
                    {
                        int? curSeq = obj.Порядковый_номер;
                        int? nextSeq = next.Порядковый_номер;

                        obj.Порядковый_номер = nextSeq;
                        next.Порядковый_номер = curSeq;
                        service.Save();
                    }
                }

                return OnDown(obj);
            }
        }

        // Перемещение объекта вниз
        public ActionResult Down(int id)
        {
            T obj = service.Get(id);

            if (obj == null) return View("NotFound");
            else
            {
                if (obj.Порядковый_номер.HasValue)
                {
                    T previous = (service as IChangePositionService<T>).GetPrevious(obj);

                    if (previous != null)
                    {
                        int? curSeq = obj.Порядковый_номер;
                        int? prevSeq = previous.Порядковый_номер;

                        obj.Порядковый_номер = prevSeq;
                        previous.Порядковый_номер = curSeq;
                        service.Save();
                    }
                }

                return OnUp(obj);
            }
        }

        #endregion

        #region Virtual methods

        // Перенаправление после перемещения объекта вверх
        protected virtual ActionResult OnUp(T obj)
        {
            return ReturnToList(obj);
        }

        // Перенаправление после перемещения объекта вниз
        protected virtual ActionResult OnDown(T obj)
        {
            return ReturnToList(obj);
        }

        #endregion

        #region Overridden virtual methods

        // При создании объекта автоматически задаём ему значение Sequence, равное следующему после наибольшего
        protected override void AddValuesOnCreate(T obj)
        {
            base.AddValuesOnCreate(obj);
            obj.Порядковый_номер = GetNextSequence(service.Get().Select(item => item.Порядковый_номер));
        }

        #endregion

        #region Methods

        // Получаем значение Sequence, следующее после наибольшего
        protected virtual int GetNextSequence(IQueryable<int?> seqs)
        {
            if (seqs.Count() == 0) return 1;
            else
            {
                int? iMax = seqs.Max();
                if (iMax.HasValue) return iMax.Value + 1;
                else return 1;
            }
        }

        #endregion
    }
<<<<<<< HEAD
>>>>>>> c7e45a48a6cf0f4860bd4cf8d431898ccfac393c
=======
>>>>>>> c7e45a48a6cf0f4860bd4cf8d431898ccfac393c
}