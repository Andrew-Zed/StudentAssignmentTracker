using System.ComponentModel.DataAnnotations;
using StudentAssignmentTracker.Enums;

namespace StudentAssignmentTracker.Models;

public class Assignment
{
    public int Id { get; set; }

    [Required]
    [StringLength(100)]
    public string Title { get; set; } = string.Empty;

    [StringLength(1000)]
    public string Description { get; set; } = string.Empty;

    public DateTime DueDate { get; set; }

    public AssignmentStatus Status { get; set; }

    public PriorityLevel Priority { get; set; }

    public decimal PointsPossible { get; set; }

    public decimal PointsEarned { get; set; }

    public bool IsCompleted { get; set; }

    public int CourseId { get; set; }

    public Course Course { get; set; } = null!;

}