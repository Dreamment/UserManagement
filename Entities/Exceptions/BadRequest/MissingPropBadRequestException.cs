namespace Entities.Exceptions.BadRequest
{
    public class MissingPropBadRequestException : BadRequestException
    {
        public MissingPropBadRequestException(string Type1, string Type2) : base($"You must provide either {Type1} or {Type2}")
        {

        }
    }
}
