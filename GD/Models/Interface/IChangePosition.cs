using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GD.Models.Interface
{
    public interface IChangePosition:IBase
    {
        int? Порядковый_номер { get; set; }
    }
}
