﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace otf.Controllers
{
    //[Route("about")]
    [Route("[controller]/[action]")]
    public class AboutController
    {
        //[Route("")]
        public string Phone()
        {
            return "1+555-555-5555";
        }

       // [Route("address")]
        public string Address()
        {
            return "USA";
        }
    }
}
