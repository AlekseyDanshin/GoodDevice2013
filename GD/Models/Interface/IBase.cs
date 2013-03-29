using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GD.Models.Interface
{
    public interface IBase
    {
        Int64 id_товара { get; set; }
        bool CanBeDeleted();
    }
}
