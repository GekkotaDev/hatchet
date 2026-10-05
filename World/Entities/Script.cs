namespace Hatchet.World.Entities;

public interface IScript<T> {
    public Enums.ProcessMode ProcessMode { get; set; }

    public T Process(float deltaTime);
}