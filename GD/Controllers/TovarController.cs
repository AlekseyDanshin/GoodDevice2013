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
<<<<<<< HEAD
<<<<<<< HEAD
    public class TovarController : BaseController<Товар>
    {
        public TovarController(IBaceService<Товар> _service) : base(_service) { }
=======
    public class TovarController : ChangePositionController<Товар>
    {
        public TovarController(IChangePositionService<Товар> _service) : base(_service) { }
>>>>>>> c7e45a48a6cf0f4860bd4cf8d431898ccfac393c
=======
    public class TovarController : ChangePositionController<Товар>
    {
        public TovarController(IChangePositionService<Товар> _service) : base(_service) { }
>>>>>>> c7e45a48a6cf0f4860bd4cf8d431898ccfac393c

        public TovarController() : this(ТоварServiceFactory.Create()) { }
    }
}