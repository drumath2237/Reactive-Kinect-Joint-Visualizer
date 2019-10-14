using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace KinectJointVisualizerV2
{
    public class VisualizerController
    {
        static VisualizerController Instance = new VisualizerController();

        public KinectJointDataModel JointDataModel;

        public VisualizerController()
        {
            JointDataModel = new KinectJointDataModel();
        }
    }
}