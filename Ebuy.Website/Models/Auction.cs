﻿using System;
using System.ComponentModel.DataAnnotations;

namespace Ebuy.Website.Models
{
    public class Auction
    {
        public long Id { get; set; }

        [Required, StringLength(50, ErrorMessage = "Title no longer of 50 chars")]
        public string Title { get; set; }

        [Required]
        public string Description { get; set; }

        [Range(1, 10000, ErrorMessage="Starting price must be at least 1")]
        public decimal StartPrice { get; set; }

        public decimal CurrentPrice { get; set; }

        public DateTime StartTime { get; set; }

        [Range(typeof(DateTime), "1/1/2012", "12/31/9999")]
        public DateTime EndTime { get; set; }
    }
}