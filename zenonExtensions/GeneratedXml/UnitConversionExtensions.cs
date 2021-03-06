//AUTOGENERATED FILE. Do not make any manual changes. Any changes to this file will be overwritten.

using Scada.AddIn.Contracts.UnitConversion;

namespace zenonExtensions
{
  public static class MeasuringUnitCollection
  {
    public static void SetUnits(this IMeasuringUnitCollection measuringUnitCollection, object units)
    {
      measuringUnitCollection.SetDynamicProperty("Units",units);
    }

    public static object GetUnits(this IMeasuringUnitCollection measuringUnitCollection)
    {
    return (object) measuringUnitCollection.GetDynamicProperty("Units");
    }

    public static void SetGRP_General(this IMeasuringUnitCollection measuringUnitCollection, object gRP_General)
    {
      measuringUnitCollection.SetDynamicProperty("GRP_General",gRP_General);
    }

    public static object GetGRP_General(this IMeasuringUnitCollection measuringUnitCollection)
    {
    return (object) measuringUnitCollection.GetDynamicProperty("GRP_General");
    }

    public static void SetName(this IMeasuringUnitCollection measuringUnitCollection, string name)
    {
      measuringUnitCollection.SetDynamicProperty("Name",name);
    }

    public static string GetName(this IMeasuringUnitCollection measuringUnitCollection)
    {
    return (string) measuringUnitCollection.GetDynamicProperty("Name");
    }

    public static void SetSystemModelGroup(this IMeasuringUnitCollection measuringUnitCollection, object systemModelGroup)
    {
      measuringUnitCollection.SetDynamicProperty("SystemModelGroup",systemModelGroup);
    }

    public static object GetSystemModelGroup(this IMeasuringUnitCollection measuringUnitCollection)
    {
    return (object) measuringUnitCollection.GetDynamicProperty("SystemModelGroup");
    }

    public static void SetFactor(this IMeasuringUnitCollection measuringUnitCollection, double factor)
    {
      measuringUnitCollection.SetDynamicProperty("Factor",factor);
    }

    public static double GetFactor(this IMeasuringUnitCollection measuringUnitCollection)
    {
    return (double) measuringUnitCollection.GetDynamicProperty("Factor");
    }

    public static void SetOffset(this IMeasuringUnitCollection measuringUnitCollection, double offset)
    {
      measuringUnitCollection.SetDynamicProperty("Offset",offset);
    }

    public static double GetOffset(this IMeasuringUnitCollection measuringUnitCollection)
    {
    return (double) measuringUnitCollection.GetDynamicProperty("Offset");
    }

    public static void SetDecShift(this IMeasuringUnitCollection measuringUnitCollection, short decShift)
    {
      measuringUnitCollection.SetDynamicProperty("DecShift",decShift);
    }

    public static short GetDecShift(this IMeasuringUnitCollection measuringUnitCollection)
    {
    return (short) measuringUnitCollection.GetDynamicProperty("DecShift");
    }

  }
}
