using NotificationService.Services;

namespace NotificationService.Models
{
    /// <summary>
    /// Group of recepient. Used for bulk notification to group of people.
    /// </summary>
    public class Group
    {
        /// <summary>
        /// ID of the group
        /// </summary>
        public string Id { get; set; } = TokenService.GenerateUuid(false);
        /// <summary>
        /// Name of the group
        /// </summary>
        public string Name { get; set; } = string.Empty;
        /// <summary>
        /// Date and time when group was created
        /// </summary>
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        /// <summary>
        /// Indicates whether group is enabled. If false - group will be hidden in the list of available group during new notification creation.
        /// </summary>
        public bool IsEnabled { get; set; }
        /// <summary>
        /// Description for the group. Normally this field has to contain useful informaton about the group. Why this group is created and for what reasons.
        /// But we all know that nobody will use it as I planned. :(
        /// </summary>
        public string Description { get; set; } = string.Empty;
    }
}
