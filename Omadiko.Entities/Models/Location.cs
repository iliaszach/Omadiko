﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omadiko.Entities.Models
{
    public class Location
    {
        public int LocationId { get; set; }

        public string Country { get; set; }

        public string City { get; set; }


        public string Address { get; set; }


        //Navigation Properties


        public Marble Marble { get; set; }//<========DES EDO
    }
}