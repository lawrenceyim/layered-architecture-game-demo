public interface IController {
    public IResponse Get(IRequest data) => new BadRequest(Message: "Not implemented");
    public IResponse Post(IRequest data) => new BadRequest(Message: "Not implemented");
    public IResponse Put(IRequest data) => new BadRequest(Message: "Not implemented");
    public IResponse Delete(IRequest data) => new BadRequest(Message: "Not implemented");
}