using UnityEngine;

public class scr_Waypoints : MonoBehaviour
{
    public static Transform[] points;
    void Awake()
    {
        points = new Transform[transform.childCount];
        for (int i = 0; 1 < points.Length; i++)
        {
            points[i] = transform.GetChild(i);
        }
    }
}