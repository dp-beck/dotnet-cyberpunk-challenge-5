using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet_cyberpunk_challenge_5.Models
{
    public class MemoryMapping
    {
        public int id { get; set; }
        public string memoryType { get; set; }
        public int memorySizeGb { get; set; }
        public int memorySpeedMhz { get; set; }
        public string memoryTechnology { get; set; }
        public int memoryLatency { get; set; }
        public int memoryVoltage { get; set; }
        public string memoryFormFacter { get; set; }
        public bool memoryEccSupport { get; set; }
        public bool memoryHeatSpreader { get; set; } 
        public int memoryWarrantyYears { get; set; }
        public int deviceId { get; set; }
        public AraskaDevice device { get; set; }
        
    }
}