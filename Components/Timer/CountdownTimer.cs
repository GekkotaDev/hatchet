namespace Hatchet.Components.Timer;

public class CountdownTimer(int time) : IClock<float> {
    const int RESET_VALUE = 1;

    public bool Paused = false;

    public float Time {
        get => (int)field;
        set {
            field = (int)value;
        }
    } = time;
    public float Clock { get; set; } = RESET_VALUE;

    public IClock<float> PauseTimer() {
        Paused = true;
        return this;
    }
    public IClock<float> ContinueTimer() {
        Paused = false;
        return this;
    }
    public IClock<float> ToggleTimer() {
        Paused = !Paused;
        return this;
    }
    public IClock<float> ResetTimer() {
        Paused = true;
        Time = time;
        Clock = RESET_VALUE;
        Paused = false;
        return this;
    }

    public void Process(float deltaTime) {
        if (Paused) return;
        if (Time <= 0) return;
        if (Clock <= 0) {
            Clock = RESET_VALUE;
            Time -= 1;
            return;
        }

        Clock -= deltaTime;
    }
}
