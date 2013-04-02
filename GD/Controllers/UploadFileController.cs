using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GD.Models;
using System.IO;


namespace GD.Controllers
{
    public class UploadFileController : Controller
    {
        static string combPath;
        //
        // GET: /UploadFile/

        [HttpPost]
        [Authorize(Roles = Constants.ROLE_ADMIN_CONTENT_MANAGER)]

        public ActionResult UploadFile(IEnumerable<HttpPostedFileBase> fileUpload)
        {
            
            foreach (var file in fileUpload)
            {
                if (file == null) continue;
                string addToPath = "add1";
                string path = AppDomain.CurrentDomain.BaseDirectory + "UploadedFiles/";
                string filename = addToPath + Path.GetFileName(file.FileName);
                combPath = Path.Combine(path, filename);
                if (filename != null) file.SaveAs(combPath);
                Session[""] = "";
               
            }
            return View(combPath);

        }
    }
}
