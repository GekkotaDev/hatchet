namespace Hatchet.BT.Composite;

using System.Collections.Immutable;

public class Sequence(params Node[] nodes) : Node {
    Enums.BT.NodeState State = Enums.BT.NodeState.READY;
    ImmutableQueue<Node> Queue = [];

    public new Node[] Nodes = nodes;

    public override Enums.BT.State Tick(float deltaTime) {
        if (State == Enums.BT.NodeState.READY) {
            State = Enums.BT.NodeState.ONGOING;
            Queue = [.. Nodes];
        }

        if (State == Enums.BT.NodeState.ONGOING && Queue.IsEmpty) {
            State = Enums.BT.NodeState.READY;
            return Enums.BT.State.SUCCESS;
        }

        var queue = Queue.Dequeue();
        var node = Queue.First();
        var status = node.Tick(deltaTime);

        if (status == Enums.BT.State.ONGOING) return Enums.BT.State.ONGOING;
        if (status == Enums.BT.State.FAIL) return Enums.BT.State.FAIL;

        Queue = queue;
        return Enums.BT.State.ONGOING;
    }
}
