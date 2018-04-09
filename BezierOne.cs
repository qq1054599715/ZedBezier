using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 二次的
/// </summary>
public class BezierOne  {
    public Vector3 point1;
    public Vector3 point2;
    public Vector3 point3;

    public BezierOne(Vector3 p1,Vector3 p2, Vector3 p3) {
        this.point1 = p1;
        this.point2 = p2;
        this.point3 = p3;
    }

    public Vector3 GetPointRange0_1(float range) {
        if (range < 0f) range = 0;
        if (range > 1f) range = 1f;
        Vector3 linePoint1 = point1 + range * (point2 - point1);
        Vector3 linePoint2 = point2 + range * (point3- point2);
        Vector3 finalPoint = linePoint1 + range * (linePoint2-linePoint1);
        return finalPoint;
    }

}
