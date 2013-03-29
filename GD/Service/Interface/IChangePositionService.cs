using System;
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
