namespace SunamoGenerators.Generators;

/// <summary>
/// Represents the special folders type.
/// </summary>
public static class SpecialFolders
{
    /// <summary>
    /// My documents.
    /// </summary>
    /// <param name="path">The path.</param>
    /// <returns>The my documents result.</returns>
    public static string MyDocuments(string path)
    {
        return @"D:\Documents\" + path.TrimStart('\\');
    }

    /// <summary>
    /// E my documents.
    /// </summary>
    /// <param name="path">The path.</param>
    /// <returns>The e my documents result.</returns>
    public static string eMyDocuments(string path)
    {
        return @"E:\Documents\" + path.TrimStart('\\');
    }
}
