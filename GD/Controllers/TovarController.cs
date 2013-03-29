using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GD.Models;
using System.IO;
using GD.Service.Interface;
using GD.Service.Factory;
using GD.Controllers.Abstract;

namespace GD.Controllers
{
    public class TovarController : ChangePositionController<Товар>
    {
        public TovarController(IChangePositionService<Товар> _service) : base(_service) { }

        public TovarController() : this(ТоварServiceFactory.Create()) { }
    }
}