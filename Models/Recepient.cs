using NotificationService.Services;

namespace NotificationService.Models
{
    /// <summary>
    /// Recepient is a customer or a user that can accept message.
    /// Each recepient can have multiple ways to interact with. Such as Email/Telegram/Phone number
    /// </summary>
    public class Recepient
    {
        /// <summary>
        /// Unique Id for the recepient
        /// </summary>
        public string Id { get; set; } = TokenService.GenerateUuid(true);
        /// <summary>
        /// Name of the recepient
        /// </summary>
        public string Name { get; set; } = string.Empty;
        /// <summary>
        /// Date and time when recepient was created
        /// </summary>
        public DateTime CreatedAt { get; set; }
        /// <summary>
        /// Date and time when was the latest update for this recepient
        /// </summary>
        public DateTime UpdatedAt { get; set; }
        /// <summary>
        /// All notifications, where recepient was in.
        /// </summary>
        public List<Notification> Notifications { get; set; } = new();
    }
}
