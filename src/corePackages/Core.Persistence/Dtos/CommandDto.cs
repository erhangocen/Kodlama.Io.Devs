using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Persistence.Dtos
{
    public class CommandDto
    {
        public string Message { get; set; }

        public CommandDto()
        {

        }

        public CommandDto(string message):this()
        {
            Message = message;
        }
    }
}
