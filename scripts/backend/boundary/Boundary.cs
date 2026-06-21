using System;
using System.Collections.Generic;
using System.Linq;

public class Boundary {
    private readonly Dictionary<ControllerId, IController> _controllers = [];
    private readonly Dictionary<RepositoryId, IRepository> _repositories = [];
    private readonly Dictionary<ServiceId, IService> _services = [];

    public Boundary() {
        _InitServices();
        _InitControllers();
    }

    public IResponse Fetch<T>(IRequest request, ControllerId controllerId, RequestMethod requestMethod) where T : class, IController {
        if (_controllers[controllerId] is T controller) {
            return requestMethod switch {
                RequestMethod.Get => controller.Get(request),
                RequestMethod.Delete => controller.Delete(request),
                RequestMethod.Post => controller.Post(request),
                RequestMethod.Put => controller.Put(request),
                _ => new BadRequest(Message: $"Method {requestMethod} not implemented for controller {controllerId}")
            };
        }

        return new BadRequest(Message: $"Controller {controllerId} not implemented");
    }

    private void _InitRepositories() {
        _repositories[RepositoryId.Player] = new PlayerRepository();
    }

    private void _InitServices() {
        _services[ServiceId.Player] = new PlayerService(_repositories[RepositoryId.Player] as PlayerRepository);
        _services[ServiceId.Persistence] = new PersistenceService(_repositories.Values.ToList());
    }

    private void _InitControllers() {
        _controllers[ControllerId.Player] = new PlayerController(_services[ServiceId.Player] as PlayerService);
        _controllers[ControllerId.Persistence] = new PersistenceController(_services[ServiceId.Persistence] as PersistenceService);
    }
}