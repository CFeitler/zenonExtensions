//AUTOGENERATED FILE. Do not make any manual changes. Any changes to this file will be overwritten.

using Scada.AddIn.Contracts.AlarmMessageList;

namespace zenonExtensions
{
  public static class AlarmMessageList
  {
    public static void SetQueryFilter(this IAlarmMessageList alarmMessageList, object queryFilter)
    {
      alarmMessageList.SetDynamicProperty("QueryFilter",queryFilter);
    }

    public static object GetQueryFilter(this IAlarmMessageList alarmMessageList)
    {
    return (object) alarmMessageList.GetDynamicProperty("QueryFilter");
    }

  }
}
