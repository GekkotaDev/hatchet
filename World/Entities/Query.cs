namespace Hatchet.World.Entities;

public interface IQuery<T> {
    public T RunQuery(float deltaTime);
}
