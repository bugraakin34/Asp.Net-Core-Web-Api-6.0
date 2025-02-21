namespace Entities.Exceptions
{
    public class PriceOutofBadRequestException : BadRequestException
    {
        public PriceOutofBadRequestException() 
            : base("Maximum price should be less than 1000 and greater than 10.")
        {

        }
    }
}
