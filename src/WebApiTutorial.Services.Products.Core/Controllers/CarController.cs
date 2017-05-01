using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;
using WebApiTutorial.Services.Products.Core.Models;

namespace WebApiTutorial.Services.Products.Core.Controllers
{
    [Route("api/[controller]")]
    public class CarController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<Car> Get()
        {
            var cars = new Car[]
            {
                new Car()
                {
                    Make = "BMW",
                    Model = "M3"
                },
                new Car()
                {
                    Make = "Nissan",
                    Model = "GTR"
                }
            };
            return cars;
        }
    }
}
