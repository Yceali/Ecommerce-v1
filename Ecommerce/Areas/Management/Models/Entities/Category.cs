﻿using Ecommerce.Areas.Management.Models.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ecommerce.Areas.Management.Models.Entities
{
    public class Category:BaseEntity
    {
        public int ParentId { get; set; }
        public string Description { get; set; }
    }
}