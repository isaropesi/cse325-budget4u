using System.ComponentModel.DataAnnotations;

namespace budget4u.Data.Models;

/// <summary>
/// Represents a financial category (e.g., Groceries, Salary, Utilities).
/// </summary>
public class Category
{
    public int Id { get; set; }

    [Required(ErrorMessage = "Category Name is required.")]
    [StringLength(50, ErrorMessage = "Name cannot exceed 50 characters.")]
    public string Name { get; set; } = string.Empty;

    [Required]
    public string Type { get; set; } = "Expense"; // "Income" or "Expense"

    [Range(0, double.MaxValue, ErrorMessage = "Budget limit must be a positive number.")]
    public decimal BudgetLimit { get; set; }

    /// <summary>
    /// The user who owns this category. Set server-side from the authenticated user claim.
    /// </summary>
    public string UserId { get; set; } = string.Empty;

    public ApplicationUser? User { get; set; }

    // Navigation property for related transactions
    public ICollection<Transaction> Transactions { get; set; } = new List<Transaction>();
}
