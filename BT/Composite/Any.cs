namespace Hatchet.BT.Composite;

public class Any(params Node[] nodes) : Node {
    public new Node[] Nodes = nodes;

    public override Enums.BT.State Tick(float deltaTime) {
        var all = Nodes.Any(node => node.Tick(deltaTime) == Enums.BT.State.FAIL);
        var any = Nodes.Any(node => node.Tick(deltaTime) == Enums.BT.State.SUCCESS);
        if (any) return Enums.BT.State.SUCCESS;
        if (all) return Enums.BT.State.FAIL;
        return Enums.BT.State.ONGOING;
    }
}
