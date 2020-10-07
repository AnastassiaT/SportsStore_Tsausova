using System;

namespace SportsStore.Domain.Entities
{
    internal class RequiredAttribute : Attribute
    {
        public string ErrorMessage;
    }
}