﻿using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace eTickets.Models
{
    public class Producer
    {
        [Key]

        public int ProducerId { get; set; }

        public string ProfilePictureURL { get; set; }

        public string FullName { get; set; }

        public string Bio { get; set; }

        //Relationships
        public List<Movie> Movies { get; set; }
    }

}
