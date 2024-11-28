using System;
using UnityEngine;

public static class StaticData
{
    static int points = 0;

    public static event Action OnPointScored;

    public static void PointScored()
    {
        points++;
        OnPointScored?.Invoke();
    }
    
    public static int GetPoints()
    {
        return points;
    }
}
