﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PixiStash.Application.DTO.CreateCompanyDTO
{
    public class CreateCompanyDTO
    {
        public Guid Id { get; set; }
        public string Name { get; set; }       
        public string? Email { get; set; }
        public bool? isActive { get; set; }
        public Guid? UserId { get; set; }   
        
    }
}
