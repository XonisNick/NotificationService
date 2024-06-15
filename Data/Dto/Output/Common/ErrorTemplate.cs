namespace NotificationService.Data.Dto.Output.Common
{
    /// <summary>
    /// Template for the errors that will display on the REST Response after request to the service
    /// </summary>
    public class ErrorTemplate
    {
        /// <summary>
        /// Digit code of the error
        /// </summary>
        public int Code { get; set; }
        /// <summary>
        /// Message of the error
        /// </summary>
        public string Message { get; set; } = string.Empty;
        /// <summary>
        /// Additional information. Such a validation errors for each field
        /// </summary>
        public object? Errors { get; set; }
    }
}
