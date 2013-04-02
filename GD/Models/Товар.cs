using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using GD.Models.MetaData;
using GD.Models.Interface;

namespace GD.Models
{
    [MetadataType(typeof(ТоварMetaData))]
<<<<<<< HEAD
<<<<<<< HEAD
    public partial class Товар: IBase
=======
    public partial class Товар: IChangePosition
>>>>>>> c7e45a48a6cf0f4860bd4cf8d431898ccfac393c
=======
    public partial class Товар: IChangePosition
>>>>>>> c7e45a48a6cf0f4860bd4cf8d431898ccfac393c
    {
        public bool CanBeDeleted()
        {
            return true;
        }
    }
}