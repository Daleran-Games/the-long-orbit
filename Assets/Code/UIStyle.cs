using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TheLongOrbit.UI
{
    [CreateAssetMenu(fileName = "NewUIStyle", menuName = "Long Orbit/UI/UI Style", order = 0)]
    public class UIStyle : ScriptableObject
    {
        /* TODO:
         * Create the UI objects and relavent scripts
         */

        [Header("Default UI Objects")]
        public GameObject TextHeading;
        public GameObject TextEntry;
        public GameObject StatBar;
        public GameObject ButtonIcon;
        public GameObject ButtonText;
    }
}
