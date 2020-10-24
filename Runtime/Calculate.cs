using UnityEngine;

namespace MFU
{
    public static class Calculate
    {
        /// <summary>
        /// Calculate the distance between two points. <see href="https://en.wikipedia.org/wiki/Pythagorean_theorem"></see>
        /// </summary>
        public static float Distance(Vector2 p0, Vector2 p1)
        {
            return Mathf.Sqrt(Mathf.Pow(p1.x - p0.x, 2) + Mathf.Pow(p1.y - p0.y, 2));
        }
        
        /// <summary>
        /// Calculate the distance between two points. <see href="https://en.wikipedia.org/wiki/Pythagorean_theorem"></see>
        /// </summary>
        public static float Distance(Vector2Int p0, Vector2Int p1)
        {
            return Mathf.Sqrt(Mathf.Pow(p1.x - p0.x, 2) + Mathf.Pow(p1.y - p0.y, 2));
        }

        /// <summary>
        /// Calculate the distance between two points. <see href="https://en.wikipedia.org/wiki/Pythagorean_theorem"></see>
        /// </summary>
        public static float Distance(Vector3 p0, Vector3 p1)
        {
            return Mathf.Sqrt(Mathf.Pow(p1.x - p0.x, 2) + Mathf.Pow(p1.y - p0.y, 2) + Mathf.Pow(p1.z - p0.z, 2));
        }

        /// <summary>
        /// Calculate linear interpolation between two values. <see href="https://en.wikipedia.org/wiki/Linear_interpolation"></see>
        /// </summary>
        public static float Lerp(float from, float to, float value)
        {
            return (1.0f - value) * from + value * to;
        }

        /// <summary>
        /// Calculate inverse linear interpolation between two values. <see cref="https://www.ronja-tutorials.com/2020/01/08/invlerp_remap.html"/></see>
        /// </summary>
        public static float InverseLerp(float from, float to, float value)
        {
            return (value - from) / (to - from);
        }

        /// <summary>
        /// Remap a value to another range. <see cref="https://www.ronja-tutorials.com/2020/01/08/invlerp_remap.html"/></see>
        /// </summary>
        public static float Remap(float originalFrom, float originalTo, float targetFrom, float targetTo, float value)
        {
            return Lerp(targetFrom, targetTo, InverseLerp(originalFrom, originalTo, value));
        }
    }
}

