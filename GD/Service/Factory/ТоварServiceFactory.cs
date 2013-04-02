<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GD.Models;
using GD.Service.Interface;

namespace GD.Service.Factory
{
    public static class ТоварServiceFactory
    {
        public static IBaceService<Товар> Create()
        {
           return new ТоварEntityService();
           
           
        }
    }
=======
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GD.Models;
using GD.Service.Interface;

namespace GD.Service.Factory
{
    public static class ТоварServiceFactory
    {
        public static IChangePositionService<Товар> Create()
        {
           return (IChangePositionService<Товар>)new ТоварEntityService();
           
           
        }
    }
>>>>>>> c7e45a48a6cf0f4860bd4cf8d431898ccfac393c
}