namespace Hatchet;

public class Game<TLoop> : IDisposable where TLoop : IMainLoop {
    public IMainLoop Loop;

    public bool Running { get => Loop.IsActive; }

    public Game() {
        if (Activator.CreateInstance(typeof(TLoop), []) is TLoop loop) {
            Loop = loop;
            return;
        }

        throw new NullReferenceException { };
    }

    public void Dispose() {
        GC.SuppressFinalize(this);
        Loop.Dispose();
    }

    public Game<TLoop> RunBlocking() {
        using (Loop) while (Loop.IsActive) Loop.Loop();
        return this;
    }

    public void Tick() {
        Loop.Loop();
    }
}
