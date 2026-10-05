namespace Hatchet.Components;

public record struct Health {
    public int Maximum;
    public int Value {
        get;
        set {
            field = Math.Clamp(value, 0, Maximum);
        }
    }
}
