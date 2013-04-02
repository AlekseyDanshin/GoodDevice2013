<<<<<<< HEAD
<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GD.Service.Interface;
using GD.Models;
using GD.Service.Abstract;

namespace GD.Service
{
    public class ТоварEntityService: BaseEntityService<Товар>
    {
        Entities entities = new Entities();

        protected override System.Data.Objects.ObjectSet<Товар> EntitySet { get { return entities.Товар; } }
    }
=======
=======
>>>>>>> c7e45a48a6cf0f4860bd4cf8d431898ccfac393c
﻿using System;
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
<<<<<<< HEAD
>>>>>>> c7e45a48a6cf0f4860bd4cf8d431898ccfac393c
=======
>>>>>>> c7e45a48a6cf0f4860bd4cf8d431898ccfac393c
}