using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UniRx;
using UniRx.Triggers;

using Kinect = Windows.Kinect;

namespace KinectJointVisualizerV2
{
    public class KinectJointDataModel
    {
        public ReactiveDictionary<Kinect.JointType, JointData> _joints = new ReactiveDictionary<Kinect.JointType, JointData>()
        {
            { Kinect.JointType.Head, new JointData(Vector3.zero, Quaternion.identity) },
            { Kinect.JointType.Neck, new JointData(Vector3.zero, Quaternion.identity) },
            { Kinect.JointType.SpineShoulder, new JointData(Vector3.zero, Quaternion.identity) },
            { Kinect.JointType.ShoulderLeft, new JointData(Vector3.zero, Quaternion.identity) },
            { Kinect.JointType.ShoulderRight, new JointData(Vector3.zero, Quaternion.identity) },
            { Kinect.JointType.ElbowLeft, new JointData(Vector3.zero, Quaternion.identity) },
            { Kinect.JointType.ElbowRight, new JointData(Vector3.zero, Quaternion.identity) },
            { Kinect.JointType.WristLeft, new JointData(Vector3.zero, Quaternion.identity) },
            { Kinect.JointType.WristRight, new JointData(Vector3.zero, Quaternion.identity) },
            { Kinect.JointType.SpineMid, new JointData(Vector3.zero, Quaternion.identity) },
            { Kinect.JointType.SpineBase, new JointData(Vector3.zero, Quaternion.identity) },
            { Kinect.JointType.HipLeft, new JointData(Vector3.zero, Quaternion.identity) },
            { Kinect.JointType.HipRight, new JointData(Vector3.zero, Quaternion.identity) },
            { Kinect.JointType.KneeLeft, new JointData(Vector3.zero, Quaternion.identity) },
            { Kinect.JointType.KneeRight, new JointData(Vector3.zero, Quaternion.identity) },
            { Kinect.JointType.AnkleLeft, new JointData(Vector3.zero, Quaternion.identity) },
            { Kinect.JointType.AnkleRight, new JointData(Vector3.zero, Quaternion.identity) },
            { Kinect.JointType.FootLeft, new JointData(Vector3.zero, Quaternion.identity) },
            { Kinect.JointType.FootRight, new JointData(Vector3.zero, Quaternion.identity) },
        };
    }
}