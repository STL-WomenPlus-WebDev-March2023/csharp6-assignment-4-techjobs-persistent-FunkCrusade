using System;
using System.ComponentModel.DataAnnotations;

namespace TechJobs6Persistent.ViewModels
{
	public class AddEmployerViewModel
	{
		private string? name;

		[Required (ErrorMessage = "A name is required. ")]

		public string Name
		{
			get { return Name; }
			set { name = value; }
		}

        private string? location;

        [Required(ErrorMessage = "A location is required ")]

        public string Location
        {
            get { return Location; }
            set { location = value; }
        }

    }
}

