using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFreela.Application.ViewModels
{
    public class ProjectDetailViewModel
    {
        public ProjectDetailViewModel(int id, string title, string description, decimal? totalCost, DateTime? createdAt, DateTime? finishAt)
        {
            Id = id;
            Title = title;
            Description = description;
            TotalCost = totalCost;
            CreatedAt = createdAt;
            FinishAt = finishAt;
        }

        public int Id { get; private set; }
        public string Title { get; private set; }
        public string Description { get; private set; }
        public decimal? TotalCost { get; private set; }
        public DateTime? CreatedAt { get; private set; }
        public DateTime? FinishAt { get; private set; }
    }
}
