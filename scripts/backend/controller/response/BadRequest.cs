public record BadRequest(
    StatusCode Status = StatusCode.BadRequest,
    string Message = "Bad Request"
) : IResponse { }