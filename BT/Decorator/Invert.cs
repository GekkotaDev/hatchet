namespace Hatchet.BT.Decorator;

public class Invert(Node node) : Node {
    public override Enums.BT.State Tick(float deltaTime) {
        var status = node.Tick(deltaTime);

        if (status == Enums.BT.State.SUCCESS) return Enums.BT.State.FAIL;
        if (status == Enums.BT.State.FAIL) return Enums.BT.State.SUCCESS;
        return Enums.BT.State.ONGOING;
    }
}
