namespace Hatchet.BT.Composite;

public class Concurrent(Node primary, Node secondary) : Node {
    public override Enums.BT.State Tick(float deltaTime) {
        var status = primary.Tick(deltaTime);
        secondary.Tick(deltaTime);

        if (status == Enums.BT.State.ONGOING) return Enums.BT.State.ONGOING;
        return status;
    }
}
