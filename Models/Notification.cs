using NotificationService.Services;

namespace NotificationService.Models
{
    /// <summary>
    /// Notification can be send to a group of recepient or to a single person.
    /// </summary>
    public class Notification
    {
        /// <summary>
        /// Unique Id for the message
        /// </summary>
        public string Id { get; set; } = TokenService.GenerateUuid(false);
        /// <summary>
        /// Date and time when the message was created
        /// </summary>
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        /// <summary>
        /// A title for the message. Displays to the recepients.
        /// </summary>
        public string Title { get; set; } = string.Empty;
        /// <summary>
        /// Body of the notification. Displays to the recepients
        /// </summary>
        public string Message { get; set; } = string.Empty;
        /// <summary>
        /// Id for the category of the notification. Uses for filtering the messages between different categories. Such as warning, error, info, debug and custom notifications.
        /// </summary>
        public string CategoryId { get; set; } = string.Empty;
        /// <summary>
        /// Category of the notification. Uses for filtering the messages between different categories. Such as warning, error, info, debug and custom notifications.
        /// </summary>
        public Category? Category { get; set; }
        /// <summary>
        /// Methods that uses to interact with recepient. Methods are separated via semi-coma.
        /// Example: "email;sms;telegram"
        /// </summary>
        public string Methods { get; set; } = string.Empty;
        /// <summary>
        /// Indicates whether multiple methods to interact with recepient beign used. 
        /// If recepient has multiple ways to interact with - the notification will be sent only to recepient's prefered method.
        /// </summary>
        public bool UseOnlyPreferedMethod { get; set; }
        /// <summary>
        /// Default prefered method. Uses only if UseOnlyPreferedMethod is true.
        /// Specifies the default prefered method for contact with recepient
        /// Required if UseOnlyPreferedMethod is true. Else - cannot be edited
        /// </summary>
        public string? DefaultPreferedMethod { get; set; }
    }
}
