using OnionArchitectureProject.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnionArchitectureProject.Domain.Entities
{
    public class Product :BaseEntity
    {
        public string Name { get; set; }
        public decimal Value { get; set; }
        public int Quantity { get; set; }
    }
}
