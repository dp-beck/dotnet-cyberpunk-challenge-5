using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet_cyberpunk_challenge_5.Models
{
    public class AraskaDevice
    {
        public int id { get; set; }
        public string name { get; set; }
        public string publicKey { get; set; }
        public string architecture { get; set; }
        public string processorType { get; set; }
        public string region { get; set; }
        public string athenaAccessKey { get; set; }
        public int clusterId { get; set; }
        public Cluster cluster { get; set; }
        public ICollection<Processes> processes { get; set; } = new List<Processes>();
        public ICollection<MemoryMapping> memoryMappings{ get; set; } = new List<MemoryMapping>();
        public ICollection<DataEvent> dataEvents{ get; set; } = new List<DataEvent>();
    }
}