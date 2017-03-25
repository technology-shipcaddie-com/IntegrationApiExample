using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShipCaddieApp.Models
{
    public class ApiErrorModel
    {
        public string Message { get; set; }
        public bool IsSuccess { get; set; }
        public bool ProcessCompleted { get; set; }
        public string Comments { get; set; }
    }
}
