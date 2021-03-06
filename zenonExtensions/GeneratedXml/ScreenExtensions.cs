//AUTOGENERATED FILE. Do not make any manual changes. Any changes to this file will be overwritten.

using Scada.AddIn.Contracts.Screen;

namespace zenonExtensions
{
  public static class ScreenTemplate
  {
    public static string GetName(this IScreenTemplate screenTemplate)
    {
    return (string) screenTemplate.GetDynamicProperty("Name");
    }

    public static string GetGUID(this IScreenTemplate screenTemplate)
    {
    return (string) screenTemplate.GetDynamicProperty("GUID");
    }

    public static string GetImportPath(this IScreenTemplate screenTemplate)
    {
    return (string) screenTemplate.GetDynamicProperty("ImportPath");
    }

    public static string GetFolder(this IScreenTemplate screenTemplate)
    {
    return (string) screenTemplate.GetDynamicProperty("Folder");
    }

    public static uint GetMDIType(this IScreenTemplate screenTemplate)
    {
    return (uint) screenTemplate.GetDynamicProperty("MDIType");
    }

    public static string GetLanguage(this IScreenTemplate screenTemplate)
    {
    return (string) screenTemplate.GetDynamicProperty("Language");
    }

    public static string GetDescription(this IScreenTemplate screenTemplate)
    {
    return (string) screenTemplate.GetDynamicProperty("Description");
    }

    public static bool GetCopaDataTemplate(this IScreenTemplate screenTemplate)
    {
    return (bool) screenTemplate.GetDynamicProperty("CopaDataTemplate");
    }

    public static bool GetDefaultTemplate(this IScreenTemplate screenTemplate)
    {
    return (bool) screenTemplate.GetDynamicProperty("DefaultTemplate");
    }

    public static uint GetScreenX(this IScreenTemplate screenTemplate)
    {
    return (uint) screenTemplate.GetDynamicProperty("ScreenX");
    }

    public static uint GetScreenY(this IScreenTemplate screenTemplate)
    {
    return (uint) screenTemplate.GetDynamicProperty("ScreenY");
    }

    public static uint GetWidth(this IScreenTemplate screenTemplate)
    {
    return (uint) screenTemplate.GetDynamicProperty("Width");
    }

    public static uint GetHeight(this IScreenTemplate screenTemplate)
    {
    return (uint) screenTemplate.GetDynamicProperty("Height");
    }

  }
}
