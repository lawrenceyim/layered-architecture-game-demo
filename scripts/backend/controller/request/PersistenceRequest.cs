public enum PersistenceType {
    Save,
    Load
}

public record PersistenceRequest(string FileName, PersistenceType Type) : IRequest;