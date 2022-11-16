using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace veterinaria.yara.application.models.dtos
{
    public class MsDtoResponseError
    {
        public int code { get; set; }
        public string? message { get; set; }

        public bool error { get; set; }
    }
}
