﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class RentalDto
    {
        public int Id { get; set; }
        public string CarName { get; set; }
        public string CustomerName { get; set; }
        public DateTime RentDate { get; set; }
        public DateTime? ReturnDate { get; set; }

    }
}
