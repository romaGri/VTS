using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace VTS_EPAM.Models
{
    public class VacationModel
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public string DateFrom { get; set; }
        public string DateTo { get; set; }
    }
}