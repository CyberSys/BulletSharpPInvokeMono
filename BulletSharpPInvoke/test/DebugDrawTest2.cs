using BulletSharp;
using BulletSharp.Math;

namespace BulletSharpTest
{
    class DebugDrawTest2 : DebugDraw
    {
        DebugDrawModes _debugMode;

        public override DebugDrawModes DebugMode
        {
            get
            {
                return _debugMode;
            }
            set
            {
                _debugMode = value;
            }
        }

        public override void Draw3dText(ref Vector3 location, string textString)
        {
            throw new System.NotImplementedException();
        }

        public override void DrawContactPoint(ref Vector3 pointOnB, ref Vector3 normalOnB, float distance, int lifeTime, ref Vector3 color)
        {
            throw new System.NotImplementedException();
        }

        public override void DrawLine(ref Vector3 from, ref Vector3 to, ref Vector3 color)
        {
            throw new System.NotImplementedException();
        }

        public override void ReportErrorWarning(string warningString)
        {
            throw new System.NotImplementedException();
        }
    }
}