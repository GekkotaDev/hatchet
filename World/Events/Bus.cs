using System.Collections.Immutable;

namespace Hatchet.World.Events;

public class Bus<T> {
    private readonly Stack<T> Events = [];

    public ImmutableStack<T> Read() {
        return [.. Events];
    }

    public Bus<T> Push(T busEvent) {
        Events.Push(busEvent);
        return this;
    }

    public Bus<T> Flush() {
        Events.Clear();
        return this;
    }
}
