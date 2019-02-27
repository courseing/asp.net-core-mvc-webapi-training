using System;
using System.ComponentModel.DataAnnotations;

namespace ef3.Models
{
    public class Form
    {
        public Guid Id{get;set;}
        public string Name{get;set;}
        public bool Active{get;set;}
    }
}