namespace Hatchet.BT.Decorator;

public class Retry(int maximumTries, Node node) : Node {
    int Tries = 0;

    public override Enums.BT.State Tick(float deltaTime) {
        if (Tries >= maximumTries) {
            Tries = 0;
            return Enums.BT.State.FAIL;
        }

        var status = node.Tick(deltaTime);
        if (status == Enums.BT.State.ONGOING) return Enums.BT.State.ONGOING;
        if (status == Enums.BT.State.SUCCESS) return Enums.BT.State.SUCCESS;
        Tries += 1;
        return Enums.BT.State.ONGOING;
    }
}
