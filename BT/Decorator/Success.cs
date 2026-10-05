namespace Hatchet.BT.Decorator;

public class Success(Node node) : Node {
    public override Enums.BT.State Tick(float deltaTime) {
        if (node.Tick(deltaTime) == Enums.BT.State.ONGOING) return Enums.BT.State.ONGOING;
        return Enums.BT.State.SUCCESS;
    }
}
