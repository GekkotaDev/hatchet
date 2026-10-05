namespace Hatchet;

public interface IMainLoop : IDisposable {
    public bool IsActive { get; }

    public IMainLoop Ready();

    public void Loop();

    public void Input();
    public void Process(float deltaTime);
    public void Draw();
}
