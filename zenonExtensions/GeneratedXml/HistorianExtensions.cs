//AUTOGENERATED FILE. Do not make any manual changes. Any changes to this file will be overwritten.

using Scada.AddIn.Contracts.Historian;

namespace zenonExtensions
{
  public static class EditorArchiveTemplate
  {
    public static string GetName(this IEditorArchiveTemplate editorArchiveTemplate)
    {
    return (string) editorArchiveTemplate.GetDynamicProperty("Name");
    }

    public static string GetGUID(this IEditorArchiveTemplate editorArchiveTemplate)
    {
    return (string) editorArchiveTemplate.GetDynamicProperty("GUID");
    }

    public static string GetLanguage(this IEditorArchiveTemplate editorArchiveTemplate)
    {
    return (string) editorArchiveTemplate.GetDynamicProperty("Language");
    }

    public static string GetImportPath(this IEditorArchiveTemplate editorArchiveTemplate)
    {
    return (string) editorArchiveTemplate.GetDynamicProperty("ImportPath");
    }

    public static string GetFolder(this IEditorArchiveTemplate editorArchiveTemplate)
    {
    return (string) editorArchiveTemplate.GetDynamicProperty("Folder");
    }

    public static string GetDescription(this IEditorArchiveTemplate editorArchiveTemplate)
    {
    return (string) editorArchiveTemplate.GetDynamicProperty("Description");
    }

    public static bool GetCopaDataTemplate(this IEditorArchiveTemplate editorArchiveTemplate)
    {
    return (bool) editorArchiveTemplate.GetDynamicProperty("CopaDataTemplate");
    }

  }
}
