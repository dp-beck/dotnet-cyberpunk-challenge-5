using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet_cyberpunk_challenge_5.Models
{
    public class Processes
    {
        public int id { get; set; }
        public string memory { get; set; }
        public string family { get; set; }  
        public string openFiles { get; set; }
        public int deviceId { get; set; }
        public AraskaDevice device { get; set; }
    }
}