﻿using System;
using UnityEngine;
using Zenject;

namespace InterVR.IF.VR.Glove.Installer
{
    [CreateAssetMenu(fileName = "IF_VR_Glove_Settings", menuName = "InterVR/IF/VR/Glove/Settings")]
    public class IF_VR_Glove_Installer : ScriptableObjectInstaller<IF_VR_Glove_Installer>
    {
#pragma warning disable 0649
        [SerializeField]
        Settings settings;
#pragma warning restore 0649

        public override void InstallBindings()
        {
            Container.BindInstance(settings).IfNotBound();
        }

        [Serializable]
        public class Settings
        {
            public string Name = "IF VR Glove Installer";
        }
    }
}