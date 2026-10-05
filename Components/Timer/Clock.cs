using System.Numerics;

namespace Hatchet.Components.Timer;

public interface IClock<T> where T : INumber<T> {
    public T Time { get; set; }
    public T Clock { get; }

    public IClock<T> PauseTimer();
    public IClock<T> ContinueTimer();
    public IClock<T> ToggleTimer();

    public void Process(float deltaTime);
}
