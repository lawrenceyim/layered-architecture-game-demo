public record Ok(
    string Message = ""
) : IResponse {
    public StatusCode Status { get; init; } = StatusCode.Ok;
};