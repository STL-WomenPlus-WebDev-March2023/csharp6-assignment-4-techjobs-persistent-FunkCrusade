using System;
using System.ComponentModel.DataAnnotations;

namespace TechJobs6Persistent.ViewModels
{
	public class AddEmployerViewModel
	{
		[Required (ErrorMessage = "A name is required. ")]
		public string? Name { get; set; }
      
        [Required(ErrorMessage = "A location is required ")]
        public string? Location { get; set; }

    }
}

