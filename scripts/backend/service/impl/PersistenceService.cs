using System.Collections.Generic;

public class PersistenceService : IService {
    private readonly List<IRepository> _repositories;

    public PersistenceService(List<IRepository> repositories) {
        _repositories = repositories;
    }

    public void Save(string fileName) {
        foreach (IRepository repository in _repositories) {
            repository.Save(fileName);
        }
    }

    public void Load(string fileName) {
        foreach (IRepository repository in _repositories) {
            repository.Load(fileName);
        }
    }
}