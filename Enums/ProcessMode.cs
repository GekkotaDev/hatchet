namespace Hatchet.Enums;

public enum ProcessMode {
    PAUSABLE,
    WHEN_PAUSED,
    ALWAYS,
    DISABLED,
}

public static class ProcessModeQuery {
    public static bool ShouldProcess(bool paused, ProcessMode mode) {
        if (mode == ProcessMode.DISABLED) return false;
        if (mode == ProcessMode.ALWAYS) return true;

        if (mode == ProcessMode.PAUSABLE && paused) return false;
        if (mode == ProcessMode.WHEN_PAUSED && !paused) return false;
        return true;
    }
}
