using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

using UniRx;
using UniRx.Triggers;

using Kinect = Windows.Kinect;

namespace KinectJointVisualizerV2
{
    public class KinectBodyDataManager: MonoBehaviour
    {
        [SerializeField] GameObject BodySource;

        BodySourceManager _bodySource;
        
        Kinect.Body _body;

        ReactiveDictionary<Kinect.JointType, JointData> _joints = new ReactiveDictionary<Kinect.JointType, JointData>();

        private void Start()
        {
            _joints = new ReactiveDictionary<Kinect.JointType, JointData>()
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

            _bodySource = BodySource.GetComponent<BodySourceManager>();

            _joints.ObserveReplace()
                .Where(x=>x.NewValue.pos!=x.OldValue.pos)
                .Where(x=>x.NewValue.rot!=x.OldValue.rot)
                .Subscribe(x =>
                {
                    VisualizerController.Instance.JointDataModel._joints[x.Key] = x.NewValue;
                });

            this.UpdateAsObservable().Subscribe(_ =>
            {
                _body = _bodySource.GetData().FirstOrDefault(b => b.IsTracked);

                if (_body.IsTracked)
                {
                    var keys = _joints.Keys.ToArray();
                    foreach (var k in keys)
                    {
                        _joints[k] = new JointData(
                            JointUtility.GetJointPos(_body, k),
                            JointUtility.GetJointRot(_body, k)
                        );
                    }
                }
            });
        }
    }
}