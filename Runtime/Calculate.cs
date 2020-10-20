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
        public static float Distance(Vector3 p0, Vector3 p1)
        {
            return Mathf.Sqrt(Mathf.Pow(p1.x - p0.x, 2) + Mathf.Pow(p1.y - p0.y, 2) + Mathf.Pow(p1.z - p0.z, 2));
        }
    }
}

