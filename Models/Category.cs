using NotificationService.Services;

namespace NotificationService.Models
{
    /// <summary>
    /// Category for the notification. Can be used for filtering the messages such as warning, error, info, debug, etc.
    /// Also, supports custom categories if needed.
    /// </summary>
    public class Category
    {
        /// <summary>
        /// Unique ID for the category
        /// </summary>
        public string Id { get; set; } = TokenService.GenerateUuid();
        /// <summary>
        /// Name of the category
        /// </summary>
        public string Name { get; set; } = string.Empty;
        /// <summary>
        /// Description for the category
        /// </summary>
        public string Description { get; set; } = string.Empty;
        /// <summary>
        /// Is category enabled. If set false - no notification can be sent with this category specified.
        /// </summary>
        public bool IsEnabled { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        /// <summary>
        /// Uses for sorting categories in the list. Higher value will set category to the top of the list
        /// </summary>
        public int Priority { get; set; }
    }
}
