using System;

namespace SportsStore.Domain.Entities
{
    internal class DisplayAttribute : Attribute
    {
        public string Name { get; set; }
    }
}