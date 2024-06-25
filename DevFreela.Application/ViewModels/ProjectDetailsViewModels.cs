using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFreela.Application.ViewModels
{
    public class ProjectDetailsViewModels
    {
        public ProjectDetailsViewModels(int id, string ttile, string description, decimal totalCost, DateTime? startedAt, DateTime? finisheAt)
        {
            Id = id;
            Ttile = ttile;
            Description = description;
            TotalCost = totalCost;
            StartedAt = startedAt;
            FinisheAt = finisheAt;
        }

        public int Id { get; set; }
        public string Ttile { get; set; }
        public string Description { get; private set; }
        public decimal TotalCost { get; set; }
        public DateTime? StartedAt { get; private set; }
        public DateTime? FinisheAt { get; private set; }
    }
}
