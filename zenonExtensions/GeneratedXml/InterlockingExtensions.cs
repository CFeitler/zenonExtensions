//AUTOGENERATED FILE. Do not make any manual changes. Any changes to this file will be overwritten.

using Scada.AddIn.Contracts.Interlocking;

namespace zenonExtensions
{
  public static class Interlocking
  {
    public static void SetValueVariable(this IInterlocking interlocking, object valueVariable)
    {
      interlocking.SetDynamicProperty("ValueVariable",valueVariable);
    }

    public static object GetValueVariable(this IInterlocking interlocking)
    {
    return (object) interlocking.GetDynamicProperty("ValueVariable");
    }

    public static void SetReturnInformation(this IInterlocking interlocking, object returnInformation)
    {
      interlocking.SetDynamicProperty("ReturnInformation",returnInformation);
    }

    public static object GetReturnInformation(this IInterlocking interlocking)
    {
    return (object) interlocking.GetDynamicProperty("ReturnInformation");
    }

    public static void SetWatchDogTimer(this IInterlocking interlocking, byte watchDogTimer)
    {
      interlocking.SetDynamicProperty("WatchDogTimer",watchDogTimer);
    }

    public static byte GetWatchDogTimer(this IInterlocking interlocking)
    {
    return (byte) interlocking.GetDynamicProperty("WatchDogTimer");
    }

    public static void SetDesiredDirection(this IInterlocking interlocking, bool desiredDirection)
    {
      interlocking.SetDynamicProperty("DesiredDirection",desiredDirection);
    }

    public static bool GetDesiredDirection(this IInterlocking interlocking)
    {
    return (bool) interlocking.GetDynamicProperty("DesiredDirection");
    }

    public static void SetPicGUID(this IInterlocking interlocking, string picGUID)
    {
      interlocking.SetDynamicProperty("PicGUID",picGUID);
    }

    public static string GetPicGUID(this IInterlocking interlocking)
    {
    return (string) interlocking.GetDynamicProperty("PicGUID");
    }

    public static void SetPicture(this IInterlocking interlocking, string picture)
    {
      interlocking.SetDynamicProperty("Picture",picture);
    }

    public static string GetPicture(this IInterlocking interlocking)
    {
    return (string) interlocking.GetDynamicProperty("Picture");
    }

    public static void SetSubstiGroup(this IInterlocking interlocking, bool substiGroup)
    {
      interlocking.SetDynamicProperty("SubstiGroup",substiGroup);
    }

    public static bool GetSubstiGroup(this IInterlocking interlocking)
    {
    return (bool) interlocking.GetDynamicProperty("SubstiGroup");
    }

    public static void SetModal(this IInterlocking interlocking, bool modal)
    {
      interlocking.SetDynamicProperty("Modal",modal);
    }

    public static bool GetModal(this IInterlocking interlocking)
    {
    return (bool) interlocking.GetDynamicProperty("Modal");
    }

    public static void SetRM_Titel(this IInterlocking interlocking, bool rM_Titel)
    {
      interlocking.SetDynamicProperty("RM_Titel",rM_Titel);
    }

    public static bool GetRM_Titel(this IInterlocking interlocking)
    {
    return (bool) interlocking.GetDynamicProperty("RM_Titel");
    }

    public static void SetListConfig(this IInterlocking interlocking, string listConfig)
    {
      interlocking.SetDynamicProperty("ListConfig",listConfig);
    }

    public static string GetListConfig(this IInterlocking interlocking)
    {
    return (string) interlocking.GetDynamicProperty("ListConfig");
    }

    public static void SetListConfigEXP(this IInterlocking interlocking, object listConfigEXP)
    {
      interlocking.SetDynamicProperty("ListConfigEXP",listConfigEXP);
    }

    public static object GetListConfigEXP(this IInterlocking interlocking)
    {
    return (object) interlocking.GetDynamicProperty("ListConfigEXP");
    }

    public static void SetCBTR_Act(this IInterlocking interlocking, bool cBTR_Act)
    {
      interlocking.SetDynamicProperty("CBTR_Act",cBTR_Act);
    }

    public static bool GetCBTR_Act(this IInterlocking interlocking)
    {
    return (bool) interlocking.GetDynamicProperty("CBTR_Act");
    }

    public static void SetCBTR_Formula(this IInterlocking interlocking, string cBTR_Formula)
    {
      interlocking.SetDynamicProperty("CBTR_Formula",cBTR_Formula);
    }

    public static string GetCBTR_Formula(this IInterlocking interlocking)
    {
    return (string) interlocking.GetDynamicProperty("CBTR_Formula");
    }

    public static void SetWriteStatusBitActive(this IInterlocking interlocking, bool writeStatusBitActive)
    {
      interlocking.SetDynamicProperty("WriteStatusBitActive",writeStatusBitActive);
    }

    public static bool GetWriteStatusBitActive(this IInterlocking interlocking)
    {
    return (bool) interlocking.GetDynamicProperty("WriteStatusBitActive");
    }

  }
}
