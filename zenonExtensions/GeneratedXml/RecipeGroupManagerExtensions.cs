﻿//AUTOGENERATED FILE. Do not make any manual changes. Any changes to this file will be overwritten.

using Scada.AddIn.Contracts.RecipeGroupManager;

namespace zenonExtensions
{
  public static class RecipeValue
  {
    public static void SetType(this IRecipeValue recipeValue, uint type)
    {
      recipeValue.SetDynamicProperty("Type",type);
    }

    public static uint GetType(this IRecipeValue recipeValue)
    {
    return (uint) recipeValue.GetDynamicProperty("Type");
    }

    public static void SetVariable(this IRecipeValue recipeValue, object variable)
    {
      recipeValue.SetDynamicProperty("Variable",variable);
    }

    public static object GetVariable(this IRecipeValue recipeValue)
    {
    return (object) recipeValue.GetDynamicProperty("Variable");
    }

    public static void SetOffset(this IRecipeValue recipeValue, int offset)
    {
      recipeValue.SetDynamicProperty("Offset",offset);
    }

    public static int GetOffset(this IRecipeValue recipeValue)
    {
    return (int) recipeValue.GetDynamicProperty("Offset");
    }

    public static void SetSourceVar(this IRecipeValue recipeValue, object sourceVar)
    {
      recipeValue.SetDynamicProperty("SourceVar",sourceVar);
    }

    public static object GetSourceVar(this IRecipeValue recipeValue)
    {
    return (object) recipeValue.GetDynamicProperty("SourceVar");
    }

    public static void SetSourceOffset(this IRecipeValue recipeValue, int sourceOffset)
    {
      recipeValue.SetDynamicProperty("SourceOffset",sourceOffset);
    }

    public static int GetSourceOffset(this IRecipeValue recipeValue)
    {
    return (int) recipeValue.GetDynamicProperty("SourceOffset");
    }

    public static void SetValue(this IRecipeValue recipeValue, double value)
    {
      recipeValue.SetDynamicProperty("Value",value);
    }

    public static double GetValue(this IRecipeValue recipeValue)
    {
    return (double) recipeValue.GetDynamicProperty("Value");
    }

    public static void SetStringValue(this IRecipeValue recipeValue, string stringValue)
    {
      recipeValue.SetDynamicProperty("StringValue",stringValue);
    }

    public static string GetStringValue(this IRecipeValue recipeValue)
    {
    return (string) recipeValue.GetDynamicProperty("StringValue");
    }

    public static void SetZValue(this IRecipeValue recipeValue, double zValue)
    {
      recipeValue.SetDynamicProperty("ZValue",zValue);
    }

    public static double GetZValue(this IRecipeValue recipeValue)
    {
    return (double) recipeValue.GetDynamicProperty("ZValue");
    }

  }
}