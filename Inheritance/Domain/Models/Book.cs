using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Models
{
    public class Book
    {
        public int Id { get; set; }
        private protected string Name { get; set; }
        protected internal string  Author { get; set; }
    }
}
