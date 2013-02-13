using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GD.Models;
using System.IO;

namespace GD.Controllers
{
    public class TovarController : Controller
    {
       
        Entities entities = new Entities();

        // Отображает список всех объектов
        public ActionResult Index()
        {
            var objs = entities.Товар;
            return View(objs);
        }

        // Отображает карточку объекта, имеющего ID, задаваемый в параметре id
        public ActionResult Details(Int64 id)
        { 
            Товар obj = (from item in entities.Товар where item.id_товара == id select item).FirstOrDefault();
            if (obj == null) return View("NotFound");
            return View(obj);
        }

        // Открывает форму создания объекта
        [Authorize(Roles = Constants.ROLE_ADMIN_CONTENT_MANAGER)]
        public ActionResult Create()
        {
            return View();
        }

        // Обрабатывает данные, полученные из формы создания объекта
        // Это действие может может запускаться только для обработки данных, полученных по протоколу Http Post (на что указывает фильтр)
        [HttpPost]
        [Authorize(Roles = Constants.ROLE_ADMIN_CONTENT_MANAGER)]
        public ActionResult Create(FormCollection collection)
        {
            if (ModelState.IsValid)
            {
                Товар obj = new Товар();
                UpdateModel(obj, collection);
                entities.Товар.AddObject(obj);
                entities.SaveChanges();
                return RedirectToAction("Details", new { id = obj.id_товара });
            }
            else return View();
        }

        // Открывает форму редактирования объекта, имеющего ID, задаваемый в параметре id

        [Authorize(Roles = Constants.ROLE_ADMIN_CONTENT_MANAGER)]
        public ActionResult Edit(Int64 id)
        {
            Товар obj = (from item in entities.Товар where item.id_товара == id select item).FirstOrDefault();
            if (obj == null) return View("NotFound");
            return View(obj);
        }

        // Обрабатывает данные, полученные из формы редактирования объекта
        // Запускается только при получении данных по Http Post
        [HttpPost]
        [Authorize(Roles = Constants.ROLE_ADMIN_CONTENT_MANAGER)]

        public ActionResult Edit(Int64 id, FormCollection collection)
        {
            Товар obj = (from item in entities.Товар where item.id_товара == id select item).FirstOrDefault();
            if (obj == null) return View("NotFound");

            if (ModelState.IsValid)
            {
                UpdateModel(obj, collection);
                entities.SaveChanges();
                return RedirectToAction("Details", new { id = obj.id_товара });
            }
                
        
            else return View(obj);
        }
        [HttpPost]
        [Authorize(Roles = Constants.ROLE_ADMIN_CONTENT_MANAGER)]
        public ActionResult Edit(IEnumerable<HttpPostedFileBase> fileUpload)
        {
                foreach (var file in fileUpload)
                {
                    if (file == null) continue;
                    string path = AppDomain.CurrentDomain.BaseDirectory + "UploadedFiles/";
                    string filename = Path.GetFileName(file.FileName);
                    if (filename != null) file.SaveAs(Path.Combine(path, filename));
                }
            return RedirectToAction("Details");
        }
        // Открывает форму для удаления объекта, имеющего ID, задаваемый в параметре id
        [Authorize(Roles = Constants.ROLE_ADMIN_CONTENT_MANAGER)]
        public ActionResult Delete(Int64 id)
        {
            Товар obj = (from item in entities.Товар where item.id_товара == id select item).FirstOrDefault();
            if (obj == null) return View("NotFound");
            return View(obj);
        }

        // Обрабатывает данные, полученные из формы удаления объекта
        // Запускается только при получении данных по http Post
        [HttpPost]
        [Authorize(Roles = Constants.ROLE_ADMIN_CONTENT_MANAGER)]
        public ActionResult Delete(Int64 id, FormCollection collection)
        {
            Товар obj = (from item in entities.Товар where item.id_товара == id select item).FirstOrDefault();
            if (obj == null) return View("NotFound");
            entities.Товар.DeleteObject(obj);
            entities.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
