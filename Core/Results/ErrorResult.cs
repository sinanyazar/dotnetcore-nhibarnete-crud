namespace Core.Results
{
    public class ErrorResult : Result
    {
        public ErrorResult(bool success, string message) : base(success, message)
        {
        }

        public ErrorResult() : base(false)
        {
        }
    }
}