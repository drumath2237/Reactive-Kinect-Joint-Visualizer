using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace KinectJointVisualizerV2
{
    public readonly struct JointData
    {
        public readonly Vector3 pos;
        public readonly Quaternion rot;

        public JointData(Vector3 v, Quaternion q)
        {
            pos = v;
            rot = q;
        }
    }
}