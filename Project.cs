﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1
{
    public class Project
    {

        public Project()
        {

        }

        public string Title { get; set; }

        public string Description { get; set; }
        public int Id { get; set; }

        public bool Active{get; set;}
    }
}
