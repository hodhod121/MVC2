using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Utility
{
    public class TempResult
    {
      
        public string GetResult(ref DoctorModel _myModel)
        {

            try
            {
                string message = "";
                if (_myModel.temperature > 38)
                {

                    message = $"You have feber, because your body temprature is {_myModel.temperature} °C";
                }
                else if (_myModel.temperature < 35)
                {

                    message = $"You have hypotermi, because your body temprature is {_myModel.temperature} °C";
                }
                else
                {

                    message = $"It is ok, because your body temprature is {_myModel.temperature} °C";
                }
                
                return message;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}
