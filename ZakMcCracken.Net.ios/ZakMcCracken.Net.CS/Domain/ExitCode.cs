using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZakMcCracken.Net.CS.Domain
{
    public class ExitCode
    {

        public int PkExitCode { get; set; }
        [Range(1,7)]
        public byte Section { get; set; }
        [Range(1, 30)]
        public short Zeile { get; set; }
        [Range(1, 7)]
        public short Spalte { get; set; }
        public String Code { get; set; }

    }
}
