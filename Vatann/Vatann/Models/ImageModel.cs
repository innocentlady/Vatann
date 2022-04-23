﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Vatann.Models
{
    public class ImageModel
    {
        public int Id { get; set; }
        public string Url { get; set; }
        public string Name { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}
