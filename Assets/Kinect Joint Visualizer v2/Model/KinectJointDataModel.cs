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
        public ReactiveDictionary<Kinect.JointType, Quaternion> _joints = new ReactiveDictionary<Kinect.JointType, Quaternion>()
        {
            { Kinect.JointType.Head, Quaternion.identity },
            { Kinect.JointType.Neck, Quaternion.identity },
            { Kinect.JointType.SpineShoulder, Quaternion.identity },
            { Kinect.JointType.ShoulderLeft, Quaternion.identity },
            { Kinect.JointType.ShoulderRight, Quaternion.identity },
            { Kinect.JointType.ElbowLeft, Quaternion.identity },
            { Kinect.JointType.ElbowRight, Quaternion.identity },
            { Kinect.JointType.WristLeft, Quaternion.identity },
            { Kinect.JointType.WristRight, Quaternion.identity },
            { Kinect.JointType.SpineMid, Quaternion.identity },
            { Kinect.JointType.SpineBase, Quaternion.identity },
            { Kinect.JointType.HipLeft, Quaternion.identity },
            { Kinect.JointType.HipRight, Quaternion.identity },
            { Kinect.JointType.KneeLeft, Quaternion.identity },
            { Kinect.JointType.KneeRight, Quaternion.identity },
            { Kinect.JointType.AnkleLeft, Quaternion.identity },
            { Kinect.JointType.AnkleRight, Quaternion.identity },
            { Kinect.JointType.FootLeft, Quaternion.identity },
            { Kinect.JointType.FootRight, Quaternion.identity },
        };
    }
}