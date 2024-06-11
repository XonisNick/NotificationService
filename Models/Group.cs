using NotificationService.Services;

namespace NotificationService.Models
{
    public class RecepientGroup
    {
        public string Id { get; set; } = TokenService.GenerateUuid(false);
        public string Name { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public bool IsEnabled { get; set; }
        public string Description { get; set; } = string.Empty;
    }
}
