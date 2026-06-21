using System.Collections.Generic;

public class PersistenceController : IController {
    private PersistenceService _persistenceService;

    public PersistenceController(PersistenceService persistenceService) {
        _persistenceService = persistenceService;
    }

    public IResponse Post(IRequest data) {
        if (data is not PersistenceRequest persistenceRequest) {
            return new BadRequest(Message: "Not a PersistenceRequest");
        }

        if (persistenceRequest.Type == PersistenceType.Save) {
            _persistenceService.Save(persistenceRequest.FileName);
        } else {
            _persistenceService.Load(persistenceRequest.FileName);
        }

        return new Ok();
    }
}