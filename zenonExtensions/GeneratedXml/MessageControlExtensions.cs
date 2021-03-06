//AUTOGENERATED FILE. Do not make any manual changes. Any changes to this file will be overwritten.

using Scada.AddIn.Contracts.MessageControl;

namespace zenonExtensions
{
  public static class Message
  {
    public static void SetStatusPreview(this IMessage message, uint statusPreview)
    {
      message.SetDynamicProperty("StatusPreview",statusPreview);
    }

    public static uint GetStatusPreview(this IMessage message)
    {
    return (uint) message.GetDynamicProperty("StatusPreview");
    }

    public static void SetDispatchType(this IMessage message, short dispatchType)
    {
      message.SetDynamicProperty("DispatchType",dispatchType);
    }

    public static short GetDispatchType(this IMessage message)
    {
    return (short) message.GetDynamicProperty("DispatchType");
    }

    public static void SetAckReq(this IMessage message, bool ackReq)
    {
      message.SetDynamicProperty("AckReq",ackReq);
    }

    public static bool GetAckReq(this IMessage message)
    {
    return (bool) message.GetDynamicProperty("AckReq");
    }

    public static void SetAckTimeOut(this IMessage message, uint ackTimeOut)
    {
      message.SetDynamicProperty("AckTimeOut",ackTimeOut);
    }

    public static uint GetAckTimeOut(this IMessage message)
    {
    return (uint) message.GetDynamicProperty("AckTimeOut");
    }

    public static void SetDispatchTypeAsText(this IMessage message, string dispatchTypeAsText)
    {
      message.SetDynamicProperty("DispatchTypeAsText",dispatchTypeAsText);
    }

    public static string GetDispatchTypeAsText(this IMessage message)
    {
    return (string) message.GetDynamicProperty("DispatchTypeAsText");
    }

    public static void SetTypeStyleAsText(this IMessage message, string typeStyleAsText)
    {
      message.SetDynamicProperty("TypeStyleAsText",typeStyleAsText);
    }

    public static string GetTypeStyleAsText(this IMessage message)
    {
    return (string) message.GetDynamicProperty("TypeStyleAsText");
    }

    public static void SetDestiTypeAsText(this IMessage message, string destiTypeAsText)
    {
      message.SetDynamicProperty("DestiTypeAsText",destiTypeAsText);
    }

    public static string GetDestiTypeAsText(this IMessage message)
    {
    return (string) message.GetDynamicProperty("DestiTypeAsText");
    }

    public static void SetDestiType(this IMessage message, short destiType)
    {
      message.SetDynamicProperty("DestiType",destiType);
    }

    public static short GetDestiType(this IMessage message)
    {
    return (short) message.GetDynamicProperty("DestiType");
    }

    public static void SetGUID(this IMessage message, string gUID)
    {
      message.SetDynamicProperty("GUID",gUID);
    }

    public static string GetGUID(this IMessage message)
    {
    return (string) message.GetDynamicProperty("GUID");
    }

  }
}
