namespace Hatchet.BT;

abstract public class Node {
    public Node[] Nodes = [];

    public abstract Enums.BT.State Tick(float deltaTime);
}
