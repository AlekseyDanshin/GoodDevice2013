using System;
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
}