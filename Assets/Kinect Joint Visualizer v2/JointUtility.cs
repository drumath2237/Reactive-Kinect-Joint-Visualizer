using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Kinect = Windows.Kinect;

namespace KinectJointVisualizerV2
{
    public class JointUtility
    {

        public const float JOINT_SCALE = 1.0f;
        public static Vector3 GetJointPos(Kinect.Body body, Kinect.JointType type)
        {
            return new Vector3(
                body.Joints[type].Position.X,
                body.Joints[type].Position.Y,
                body.Joints[type].Position.Z
            ) * JOINT_SCALE;
        }

        public static Quaternion GetJointRot(Kinect.Body body, Kinect.JointType type)
        {
            return new Quaternion(
                body.JointOrientations[type].Orientation.X,
                body.JointOrientations[type].Orientation.Y,
                body.JointOrientations[type].Orientation.Z,
                body.JointOrientations[type].Orientation.W
            );
        }
    }
}