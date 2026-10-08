using Microsoft.AspNetCore.Mvc;
using demo_project.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace demo_project.Controllers
{
    public class ClaimsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ClaimsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // C#
        public IActionResult ProjectReview(int id)
        {
        // Load project directly from the DbContext (no service class)
        var project = _context.Projects
            .Include(p => p.AssignedToUser)
            .FirstOrDefault(p => p.ProjectId == id);

        if (project == null)
        {
            return NotFound();
        }

        var model = new ProjectReviewViewModel
        {
            ProjectNumber = project.ProjectNumber,
            Title = project.Title,
            LOB = project.LOB,
            SystemName = project.SystemName,
            AssignedToUser = project.AssignedToUser?.FullName ?? project.AssignedToUser?.Username ?? "Unassigned",
            AssignmentType = project.AssignmentType,
            Priority = project.Priority,
            DueDate = project.DueDate ?? DateTime.MinValue,
            TotalClaims = 0,
            EligibleClaims = 0,
            ExcludedClaims = 0,
            TotalClaimReprocessedTest = 0,
            TotalClaimReprocessedProd = 0,
            WorkflowStatus = project.WorkflowStatus,
            WorkflowSteps = new System.Collections.Generic.List<string>()
        };

        return View(model);
        }
    }
}

