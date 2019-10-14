using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UniRx;

using Kinect = Windows.Kinect;

namespace KinectJointVisualizerV2
{
    public class KinectJointPresenter: MonoBehaviour
    {
        [SerializeField] GameObject VisualizerView;
        JointVisualizerView _view;

        private void Start()
        {
            _view = gameObject.GetComponent<JointVisualizerView>();

            VisualizerController.Instance.JointDataModel._joints.ObserveReplace()
                .Subscribe(x =>
                {
                    _view.SetBoneTransform(x.Key, Vector3.one, x.NewValue);
                });
        }
    }
}