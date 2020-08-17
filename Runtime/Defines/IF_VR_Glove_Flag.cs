﻿using System;

namespace InterVR.IF.VR.Glove.Defines
{
    // The flags used to determine how an object is attached to the hand.
    [Flags]
    public enum IF_VR_Glove_HandAttachmentFlags
    {
        SnapOnAttach = 1 << 0, // The object should snap to the position of the specified attachment point on the hand.
        DetachOthers = 1 << 1, // Other objects attached to this hand will be detached.
        DetachFromOtherHand = 1 << 2, // This object will be detached from the other hand.
        ParentToHand = 1 << 3, // The object will be parented to the hand.
        VelocityMovement = 1 << 4, // The object will attempt to move to match the position and rotation of the hand.
        TurnOnKinematic = 1 << 5, // The object will not respond to external physics.
        TurnOffGravity = 1 << 6, // The object will not respond to external physics.
        AllowSidegrade = 1 << 7, // The object is able to switch from a pinch grab to a grip grab. Decreases likelyhood of a good throw but also decreases likelyhood of accidental drop
        Default = ParentToHand | DetachOthers | DetachFromOtherHand | TurnOnKinematic | SnapOnAttach
    };
}