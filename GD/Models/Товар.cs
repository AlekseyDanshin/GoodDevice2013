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
    public partial class Товар: IChangePosition
    {
        public bool CanBeDeleted()
        {
            return true;
        }
    }
}