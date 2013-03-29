﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace GD.Models.MetaData
{
    public class ТоварMetaData
    {
        [Required(ErrorMessage = "Наименование обязательно")]
        [StringLength(150)]
        public string Название { get; set; }

        [Required(ErrorMessage = "Обязательно для ввода")]
        [StringLength(50)]
        public string Подкатегория { get; set; }
    }
}