namespace Application.Core;

public class Result<T>
{
    public bool IsSuccess { get; private set; }
    
    public bool IsCreated { get; private set; }
    public string ErrorMessage { get; private set; }
    public T? Data { get; private set; }

    private Result(bool isSuccess, T data, string errorMessage = "", bool isCreated = false)
    {
        IsSuccess = isSuccess;
        ErrorMessage = errorMessage;
        Data = data;
        IsCreated = isCreated;
    }

    public static Result<T> Success(T data)
    {
        return new Result<T>(true, data);
    }

    public static Result<T> Failure(string errorMessage)
    {
        return new Result<T>(false, default(T), errorMessage);
    }
    
    public static Result<T> Created()
    {
        return new Result<T>(false, default(T), isCreated:true);
    }
}