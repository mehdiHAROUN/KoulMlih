namespace KoulMlihBack.Models.Result.CommonResult
{
    /// <summary>
    /// Represents whether an application/business operation resulted 
    /// in success (without result value) or failure (with an error message).
    /// </summary>
    public class Result
    {
        protected Result()
        { }

        public bool Success { get; set; }

        public string ErrorMessage { get; set; }

        public static Result Succeed() => new Result { Success = true };

        public static Result Fail(string errorMessage) => new Result { Success = false, ErrorMessage = errorMessage };
    }

    /// <summary>
    /// Represents whether an application/business operation resulted 
    /// in success (with a result value) or failure (with an error message).
    /// </summary>
    /// <typeparam name="TValue">The type of the result value.</typeparam>
    public class Result<TValue> : Result
    {
        public TValue Value { get; set; }

        private Result()
        { }

        public Result(Result result)
        {
            Success = result.Success;
            ErrorMessage = result.ErrorMessage;
        }

        public static Result<TValue> Succeed(TValue value) => new Result<TValue> { Success = true, Value = value };

        public static Result<TValue> SucceedOrFail(bool success, TValue successValue, string errorMessage)
        {
            var result = new Result<TValue> { Success = success };
            if (success)
            {
                result.Value = successValue;
            }
            else
            {
                result.ErrorMessage = errorMessage;
            }
            return result;
        }

        public static new Result<TValue> Fail(string errorMessage) => new Result<TValue> { Success = false, ErrorMessage = errorMessage };
    }
}
