using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace evobags.Models.LearnViewModels
{
    public class EnvironmentalImpactViewModel
    {
        [Required]
        public int NumCases { get; set; }

    }
}
