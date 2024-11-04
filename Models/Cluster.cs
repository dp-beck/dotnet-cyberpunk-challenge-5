using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet_cyberpunk_challenge_5.Models
{
    public class Cluster
    {
        public int id { get; set; }
        public string clusterName { get; set; }
        public int nodeCount { get; set; }
        public int cpuCores { get; set; }
        public int memoryGb { get; set; }
        public int storageTb { get; set; }
        public string creationDate { get; set; }
        public string environment { get; set; }
        public string kubernetesVersion { get; set; }
        public string region { get; set; }
        public ICollection<AraskaDevice> devices { get; set; } = new List<AraskaDevice>();

    }
}