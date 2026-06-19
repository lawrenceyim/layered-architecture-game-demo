using System.Collections.Generic;

public class Boundary {
    private readonly Dictionary<ControllerId, object> _controllers = [];
    private readonly Dictionary<ServiceId, object> _services = [];

    public Boundary() {
        _InitServices();
        _InitControllers();
    }

    private void _InitServices() {
        _services[ServiceId.Player] = new PlayerService();
    }

    private void _InitControllers() {
        _controllers[ControllerId.Player] = new PlayerController(_services[ServiceId.Player] as PlayerService);
    }
}