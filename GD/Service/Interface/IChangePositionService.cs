<<<<<<< HEAD
<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GD.Models.Interface;

namespace GD.Service.Interface
{
    public interface IChangePositionService<T>:IBaceService<T> where T: class,IChangePosition, new ()
    {
        // Получение ближайшего объекта с меньшим Sequence
        T GetPrevious(T dataObject);

        // Получение ближайшего объекта с большим Sequence
        T GetNext(T dataObject);
    }
}
=======
=======
>>>>>>> c7e45a48a6cf0f4860bd4cf8d431898ccfac393c
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GD.Models.Interface;

namespace GD.Service.Interface
{
    public interface IChangePositionService<T>:IBaceService<T> where T: class,IChangePosition, new ()
    {
        // Получение ближайшего объекта с меньшим Sequence
        T GetPrevious(T dataObject);

        // Получение ближайшего объекта с большим Sequence
        T GetNext(T dataObject);
    }
}
<<<<<<< HEAD
>>>>>>> c7e45a48a6cf0f4860bd4cf8d431898ccfac393c
=======
>>>>>>> c7e45a48a6cf0f4860bd4cf8d431898ccfac393c
