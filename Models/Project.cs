namespace demo_project.Models
{
    public class Project
    {
        public int ProjectId { get; set; }

        public string ProjectNumber { get; set; }

        public string Title { get; set; }

        public string LOB { get; set; }

        public string SystemName { get; set; }

        public int? AssignedToUserId { get; set; }

        public string AssignmentType { get; set; }

        public string Priority { get; set; }

        public DateTime? DueDate { get; set; }

        public string FinalIndicator { get; set; }

        public string InterestApplicable { get; set; }

        public string EscalationIndicator { get; set; }

        public string WorkflowStatus { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime? UpdatedDate { get; set; }


        // Navigation property

        public User AssignedToUser { get; set; }
    }
}