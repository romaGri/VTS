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
    public class EmployeeModel
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public List<VacationModel> Vacations { get; }

        public EmployeeModel()
        {
            Vacations = new List<VacationModel>();
        }
    }
}