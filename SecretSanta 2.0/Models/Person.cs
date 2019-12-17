using System;
using System.Collections.Generic;
using System.Text;

namespace SecretSanta_2._0.Models
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        Person PresentReceiver { get; set; }
    }
}
