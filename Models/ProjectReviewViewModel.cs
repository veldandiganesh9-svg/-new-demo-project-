using System;
using System.Collections.Generic;

namespace demo_project.Models
{
    public class ProjectReviewViewModel
    {
        public string ProjectNumber { get; set; }

        public string Title { get; set; }

        public string LOB { get; set; }

        public string SystemName { get; set; }

        public string AssignedToUser { get; set; }

        public string AssignmentType { get; set; }

        public string Priority { get; set; }

        public DateTime DueDate { get; set; }

        public int TotalClaims { get; set; }

        public int EligibleClaims { get; set; }

        public int ExcludedClaims { get; set; }

        public int TotalClaimReprocessedTest { get; set; }

        public int TotalClaimReprocessedProd { get; set; }

        public string WorkflowStatus { get; set; }

        public List<string> WorkflowSteps { get; set; }
    }
}