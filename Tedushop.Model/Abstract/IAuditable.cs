﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tedushop.Model.Abstract
{
    public interface IAuditable
    {
        DateTime? Createdate { set; get; }
        string CreateBy { set; get; }
        DateTime? UpdateDate { set; get; }
        string UpdateBy { set; get; }
         string MetaKeyword { set; get; }
         string MetaDescription { set; get; }
        bool Status { set; get; }


    }
}
