namespace Entities.DataTransferObjects.Auth
{
    public class AuthResponseDto
    {
        public string? Token { get; set; }
        public bool Success { get; set; }
        public IEnumerable<string>? Errors { get; set; }
    }
}
