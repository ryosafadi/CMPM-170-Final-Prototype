using System;
using UnityEngine;

public static class StaticData
{
    static int points = 0;

    public static event Action OnPointsChanged;

    public static void ChangePoints(int point)
    {
        points += point;
        OnPointsChanged?.Invoke();
    }
    
    public static int GetPoints()
    {
        return points;
    }
}
