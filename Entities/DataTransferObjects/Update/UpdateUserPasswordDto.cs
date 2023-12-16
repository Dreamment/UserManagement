namespace Entities.DataTransferObjects.Update
{
    public class UpdateUserPasswordDto
    {
        public string? OldPassword { get; set; }
        public string NewPassword { get; set; }
    }
}
