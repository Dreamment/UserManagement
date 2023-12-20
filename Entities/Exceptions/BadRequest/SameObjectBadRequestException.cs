namespace Entities.Exceptions.BadRequest
{
    public sealed class SameObjectBadRequestException : BadRequestException
    {
        public SameObjectBadRequestException(string objectType) : base($"You give same {objectType} with yours.")
        {

        }
    }
}
