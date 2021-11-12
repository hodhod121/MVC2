using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class DoctorModel
    {
        public int temperature { get; set; }

        public DoctorModel(int temperature)
        {
            this.temperature = temperature;
        }

        public DoctorModel()
        {
        }
    }
}
