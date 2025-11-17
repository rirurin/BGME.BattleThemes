namespace BGME.BattleThemes.Interfaces;

public record ModSong(string ModOwner, string Name, int BgmId);

public interface IBattleThemesApi
{
    /// <summary>
    /// Add a path to load themes from. Can be a <c>file</c> or <c>folder</c>.
    /// </summary>
    /// <param name="path">Path to theme file or folder containing themes.</param>
    void AddPath(string modId, string path);

    /// <summary>
    /// Remove a previously added theme path.
    /// </summary>
    /// <param name="path">Theme path.</param>
    void RemovePath(string path);

    /// <summary>
    /// Add a listener that triggers if a battle theme is registered belonging to the target mod.
    /// </summary>
    /// <param name="modId">Mod ID that the song will belong to.</param>
    /// <param name="callback">Callback to execute.</param>
    void OnMusicRegistered(string modId, Action<ModSong> callback);
}
