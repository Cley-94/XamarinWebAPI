﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace XamarinWebAPI.Models
{
    public class User_GenreModel
    {
        public virtual Guid ID { get; set; }
        public virtual UserModel User { get; set; }
        public virtual GenreModel Genre { get; set; }
    }
}