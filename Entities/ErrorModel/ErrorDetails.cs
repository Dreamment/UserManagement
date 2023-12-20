using System.Text.Json;

namespace Entities.ErrorModel
{
    public record ErrorDetails
    {
        public int StatusCode { get; init; }
        public string? Message { get; init; }

        public ErrorDetails(int statusCode, string message)
        {
            StatusCode = statusCode;
            Message = message;
            ToString();
        }
        public override string ToString() 
            => JsonSerializer.Serialize(this);
    }
}
