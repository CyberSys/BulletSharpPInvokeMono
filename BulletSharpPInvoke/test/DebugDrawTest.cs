using BulletSharp;
using BulletSharp.Math;

namespace BulletSharpTest
{
    class DebugDrawTest : IDebugDraw
    {
        DebugDrawModes _debugMode = DebugDrawModes.DrawWireframe | DebugDrawModes.DrawAabb;

        public DebugDrawModes DebugMode
        {
            get
            {
                return _debugMode;
            }
            set
            {
                throw new System.NotImplementedException();
            }
        }

        public void Draw3dText(ref Vector3 location, string textString)
        {
            throw new System.NotImplementedException();
        }

        public void DrawAabb(ref Vector3 from, ref Vector3 to, ref Vector3 color)
        {
            //throw new System.NotImplementedException();
        }

        public void DrawArc(ref Vector3 center, ref Vector3 normal, ref Vector3 axis, float radiusA, float radiusB, float minAngle, float maxAngle, ref Vector3 color, bool drawSect, float stepDegrees)
        {
            throw new System.NotImplementedException();
        }

        public void DrawArc(ref Vector3 center, ref Vector3 normal, ref Vector3 axis, float radiusA, float radiusB, float minAngle, float maxAngle, ref Vector3 color, bool drawSect)
        {
            throw new System.NotImplementedException();
        }

        public void DrawBox(ref Vector3 bbMin, ref Vector3 bbMax, ref Vector3 color)
        {
            throw new System.NotImplementedException();
        }

        public void DrawBox(ref Vector3 bbMin, ref Vector3 bbMax, ref Matrix trans, ref Vector3 color)
        {
            //throw new System.NotImplementedException();
        }

        public void DrawCapsule(float radius, float halfHeight, int upAxis, ref Matrix transform, ref Vector3 color)
        {
            throw new System.NotImplementedException();
        }

        public void DrawCone(float radius, float height, int upAxis, ref Matrix transform, ref Vector3 color)
        {
            throw new System.NotImplementedException();
        }

        public void DrawContactPoint(ref Vector3 PointOnB, ref Vector3 normalOnB, float distance, int lifeTime, ref Vector3 color)
        {
            throw new System.NotImplementedException();
        }

        public void DrawCylinder(float radius, float halfHeight, int upAxis, ref Matrix transform, ref Vector3 color)
        {
            throw new System.NotImplementedException();
        }

        public void DrawLine(ref Vector3 from, ref Vector3 to, ref Vector3 fromColor, ref Vector3 toColor)
        {
            throw new System.NotImplementedException();
        }

        public void DrawLine(ref Vector3 from, ref Vector3 to, ref Vector3 color)
        {
            throw new System.NotImplementedException();
        }

        public void DrawPlane(ref Vector3 planeNormal, float planeConst, ref Matrix transform, ref Vector3 color)
        {
            throw new System.NotImplementedException();
        }

        public void DrawSphere(ref Vector3 p, float radius, ref Vector3 color)
        {
            throw new System.NotImplementedException();
        }

        public void DrawSphere(float radius, ref Matrix transform, ref Vector3 color)
        {
            //throw new System.NotImplementedException();
        }

        public void DrawSpherePatch(ref Vector3 center, ref Vector3 up, ref Vector3 axis, float radius, float minTh, float maxTh, float minPs, float maxPs, ref Vector3 color, float stepDegrees, bool drawCenter)
        {
            throw new System.NotImplementedException();
        }

        public void DrawSpherePatch(ref Vector3 center, ref Vector3 up, ref Vector3 axis, float radius, float minTh, float maxTh, float minPs, float maxPs, ref Vector3 color, float stepDegrees)
        {
            throw new System.NotImplementedException();
        }

        public void DrawSpherePatch(ref Vector3 center, ref Vector3 up, ref Vector3 axis, float radius, float minTh, float maxTh, float minPs, float maxPs, ref Vector3 color)
        {
            throw new System.NotImplementedException();
        }

        public void DrawTransform(ref Matrix transform, float orthoLen)
        {
            throw new System.NotImplementedException();
        }

        public void DrawTriangle(ref Vector3 v0, ref Vector3 v1, ref Vector3 v2, ref Vector3 __unnamed3, ref Vector3 __unnamed4, ref Vector3 __unnamed5, ref Vector3 color, float alpha)
        {
            throw new System.NotImplementedException();
        }

        public void DrawTriangle(ref Vector3 v0, ref Vector3 v1, ref Vector3 v2, ref Vector3 color, float alpha)
        {
            throw new System.NotImplementedException();
        }

        public void FlushLines()
        {
            //throw new System.NotImplementedException();
        }

        public void ReportErrorWarning(string warningString)
        {
            throw new System.NotImplementedException();
        }
    }
}
