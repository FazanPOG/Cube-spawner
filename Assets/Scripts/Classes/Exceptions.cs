using UnityEngine;
using System;


public static class Exceptions
{
    public static float TryConvertSingle(string checking)
    {
        if (checking != "")
        {
            try
            {
                return Convert.ToSingle(checking);
            }
            catch (Exception e)
            {
                Debug.Log(e);
                return 0;
            };
        }
        return 0;
    }
}
