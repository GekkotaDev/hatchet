namespace Hatchet.World;

public abstract class WorldSingleton<T> {
    private static WorldSingleton<T>? Instance;

    public T World;

    private WorldSingleton() {
        if (Activator.CreateInstance(typeof(T), []) is T world) {
            World = world;
            return;
        }

        throw new NullReferenceException { };
    }

    public static WorldSingleton<T> CacheOr(WorldSingleton<T> world) {
        Instance ??= world;
        return Instance;
    }
}
