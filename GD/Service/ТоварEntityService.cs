using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GD.Service.Interface;
using GD.Models;
using GD.Service.Abstract;

namespace GD.Service
{
    public class ТоварEntityService: ChangePositionEntityService<Товар>
    {
        Entities entities = new Entities();

        protected override System.Data.Objects.ObjectSet<Товар> EntitySet { get { return entities.Товар; } }
    }
}