using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 三次的
/// </summary>
public class BezierTwo  {
    public Vector3 point1;
    public Vector3 point2;
    public Vector3 point3;
    public Vector3 point4;

    public BezierTwo(Vector3 p1, Vector3 p2, Vector3 p3,Vector3 p4)
    {
        this.point1 = p1;
        this.point2 = p2;
        this.point3 = p3;
        this.point4 = p4;
    }

    public Vector3 GetPointRange0_1(float range)
    {
        if (range < 0f) range = 0;
        if (range > 1f) range = 1f;
        Vector3 line1Point1 = point1 + range * (point2 - point1);
        Vector3 line1Point2 = point2 + range * (point3 - point2);
        Vector3 line2Point1 = line1Point2;
        Vector3 line2Point2 = point3 + range * (point4-point3);

        Vector3 line3Point1 = line1Point1 + range * (line1Point2-line1Point1);
        Vector3 line3Point2 = line2Point1 + range * (line2Point2-line2Point1);

        Vector3 finalPoint = line3Point1 + range * (line3Point2-line3Point1);
        return finalPoint;
    }

}
