using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace App1.Model
{
    public class AnimalModel
    {
        [Key]

        public int Id { get; set; }
        public string Animal { get; set; }
        public string Characteristics { get; set; }
        public string Species { get; set; }
        public string Habitat { get; set; }
        public string Threat { get; set; }

    }
}
