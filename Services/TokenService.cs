namespace NotificationService.Services
{
    /// <summary>
    /// Service for generating, hashing and checking tokens and passwords
    /// </summary>
    public class TokenService
    {
        /// <summary>
        /// Generates unique ID for item
        /// </summary>
        /// <param name="appendTimestamp">Indicates whether a timestamp should be added to the string</param>
        /// <returns>A string, unique id for the item. If appendTimestamp is true - epoch timestamp will be added at the end of the string. format "{uuid}-{timestamp}" or "{uuid}" if appendTimestamp is false</returns>
        public static string GenerateUuid(bool appendTimestamp = true)
        {
            string uuid = Guid.NewGuid().ToString();
            long timestamp = DateTimeOffset.UtcNow.ToUnixTimeSeconds();
            if (appendTimestamp) return $"{uuid}-{timestamp}";
            return uuid;
        }
    }
}
