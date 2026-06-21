public record BadRequest(
    string Message = ""
) : IResponse {
    public StatusCode Status { get; init; } = StatusCode.BadRequest;
}