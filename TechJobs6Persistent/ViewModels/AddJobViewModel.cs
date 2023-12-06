using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;
using TechJobs6Persistent.Models;

namespace TechJobs6Persistent.ViewModels
{
    public class AddJobViewModel
    {
        //props = name + required / id / list <selectitemslist>

        [Required(ErrorMessage = "A name is required. ")]
        public string? Name { get; set; }
        public int? EmployerId { get; set; }
        public List<SelectListItem>? Employers { get; set; } = new List<SelectListItem>();

        //method for adding list of employers i stole from skill view model(which was TRASH)

        //public AddJobViewModel(Job theJob, List<Employer> possibleEmployers)
        //{
        //    Employers = new List<SelectListItem>();
        //    foreach (var employer in possibleEmployers)
        //    {
        //        Employers.Add(new SelectListItem
        //        {
        //            Value = employer.Id.ToString(),
        //            Text = employer.Name,
        //        });


        public AddJobViewModel(List<Employer> possibleEmployers)
        {
            foreach (var employer in possibleEmployers)
            {
                Employers = possibleEmployers.Select(employer => new SelectListItem
                {
                    Text = employer.Name,
                    Value = employer.Id.ToString()
                }).ToList();
            }
        }
        public AddJobViewModel() { }

    }
}

