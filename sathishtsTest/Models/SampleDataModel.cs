using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace sathishtsTest.Models
{
    public class SampleDataModel
    {
        [Display(Name = "ID")]
        public string _Id { get; set; }
        [Display(Name = "ApplicationID")]
        public long _ApplicationId { get; set; }
        [Display(Name = "Type")]
        public string _Type { get; set; }
        [Display(Name = "Summary")]
        public string _Summary { get; set; }
        [Display(Name = "Amount")]
        public double _Amount { get; set; }
        [Display(Name = "Posting Date")]
        public DateTime _PostingDate { get; set; }
        [Display(Name = "Is Cleared")]
        public bool _IsCleared { get; set; }
        [Display(Name ="Cleared Date")]
        public DateTime? _ClearedDate { get; set; }
    }
}