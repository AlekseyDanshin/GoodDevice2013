<<<<<<< HEAD
<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GD.Models.Interface;
using GD.Service.Interface;

namespace GD.Service.Abstract
{
    public abstract class ChangePositionEntityService<T>: BaseEntityService<T> where T:class,IChangePosition,new()
    {
        // В списке объекты должны располагаться в порядке уменьшения Порядкового номера
        public override IQueryable<T> Get()
        {
            return base.Get().OrderByDescending(item => item.Порядковый_номер);
        }

        // Получение ближайшего объекта с меньшим Порядковый_номер
        public virtual T GetPrevious(T dataObject)
        {
            return (from obj in EntitySet where obj.Порядковый_номер < dataObject.Порядковый_номер orderby obj.Порядковый_номер descending select obj).FirstOrDefault();
        }

        // Получение ближайшего объекта с большим Порядковый_номер
        public virtual T GetNext(T dataObject)
        {
            return (from obj in EntitySet where obj.Порядковый_номер > dataObject.Порядковый_номер orderby obj.Порядковый_номер ascending select obj).FirstOrDefault();
        }
    }
=======
=======
>>>>>>> c7e45a48a6cf0f4860bd4cf8d431898ccfac393c
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GD.Models.Interface;
using GD.Service.Interface;

namespace GD.Service.Abstract
{
    public abstract class ChangePositionEntityService<T>: BaseEntityService<T> where T:class,IChangePosition,new()
    {
        // В списке объекты должны располагаться в порядке уменьшения Порядкового номера
        public override IQueryable<T> Get()
        {
            return base.Get().OrderByDescending(item => item.Порядковый_номер);
        }

        // Получение ближайшего объекта с меньшим Порядковый_номер
        public virtual T GetPrevious(T dataObject)
        {
            return (from obj in EntitySet where obj.Порядковый_номер < dataObject.Порядковый_номер orderby obj.Порядковый_номер descending select obj).FirstOrDefault();
        }

        // Получение ближайшего объекта с большим Порядковый_номер
        public virtual T GetNext(T dataObject)
        {
            return (from obj in EntitySet where obj.Порядковый_номер > dataObject.Порядковый_номер orderby obj.Порядковый_номер ascending select obj).FirstOrDefault();
        }
    }
<<<<<<< HEAD
>>>>>>> c7e45a48a6cf0f4860bd4cf8d431898ccfac393c
=======
>>>>>>> c7e45a48a6cf0f4860bd4cf8d431898ccfac393c
}