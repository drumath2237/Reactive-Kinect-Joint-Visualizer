using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UniRx;
using UniRx.Triggers;

using Kinect = Windows.Kinect;

namespace KinectJointVisualizerV2
{
    public class JointVisualizerView : MonoBehaviour
    {
        [SerializeField] GameObject Head;
        [SerializeField] GameObject Neck;
        [SerializeField] GameObject SpineShoulder;
        [SerializeField] GameObject ShoulderLeft, ShoulderRight;
        [SerializeField] GameObject ElbowLeft, ElbowRight;
        [SerializeField] GameObject WristLeft, WristRight;
        [SerializeField] GameObject SpineMid;
        [SerializeField] GameObject SpineBase;
        [SerializeField] GameObject HipLeft, HipRight;
        [SerializeField] GameObject KneeLeft, KneeRight;
        [SerializeField] GameObject AnkleLeft, AnkleRight;
        [SerializeField] GameObject FootLeft, FootRight;

        Dictionary<Kinect.JointType, GameObject> joint_table;

        private void Start()
        {
            joint_table = new Dictionary<Kinect.JointType, GameObject>()
            {
                { Kinect.JointType.Head, Head },
                { Kinect.JointType.Neck, Neck },
                { Kinect.JointType.SpineShoulder, SpineShoulder },
                { Kinect.JointType.ShoulderLeft, ShoulderLeft },
                { Kinect.JointType.ShoulderRight, ShoulderRight },
                { Kinect.JointType.ElbowLeft, ElbowLeft },
                { Kinect.JointType.ElbowRight, ElbowRight },
                { Kinect.JointType.WristLeft, WristLeft },
                { Kinect.JointType.WristRight, WristRight },
                { Kinect.JointType.SpineMid, SpineMid },
                { Kinect.JointType.SpineBase, SpineBase },
                { Kinect.JointType.HipLeft, HipLeft },
                { Kinect.JointType.HipRight, HipRight },
                { Kinect.JointType.KneeLeft, KneeLeft },
                { Kinect.JointType.KneeRight, KneeRight },
                { Kinect.JointType.AnkleLeft, AnkleLeft },
                { Kinect.JointType.AnkleRight, AnkleRight },
                { Kinect.JointType.FootLeft, FootLeft },
                { Kinect.JointType.FootRight, FootRight },
            };
        }

        public void SetBoneTransform(Kinect.JointType type, JointData joint)
        {
            Debug.Log("hi");
            joint_table[type].transform.position = joint.pos;
            joint_table[type].transform.rotation = joint.rot;
            joint_table[type].name = type.ToString();
        }
    }
}