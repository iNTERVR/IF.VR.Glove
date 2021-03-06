﻿using InterVR.IF.VR.Defines;
using InterVR.IF.VR.Glove.Defines;
using UniRx;
using UnityEngine;

namespace InterVR.IF.VR.Glove.Modules
{
    public interface IF_VR_Glove_IInterface
    {
        int PlayerNumber { get; }

        Transform GetRootTransform();
        void SetRootTransform(Transform root);
        bool GetGrabStateDown(IF_VR_HandType handType);
        bool GetGrabState(IF_VR_HandType handType);
        bool GetGrabStateUp(IF_VR_HandType handType);
    }
}