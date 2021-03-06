﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TestProject.Core.Entities
{
    public interface IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsActive{ get; set; }
        public string AddedBy { get; set; }
        public DateTime AddedDate { get; set; }
    }
}
