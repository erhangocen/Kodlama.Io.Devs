﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Technologies.Dtos
{
    public class TechnologyListDto
    {
        public int Id { get; set; }
        public int ProgramingLanguageId { get; set; }
        public string Name { get; set; }
        public string ProgrammingLanguageName { get; set; }
    }
}
