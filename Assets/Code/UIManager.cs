using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TheLongOrbit.UI
{
    public class UIManager : MonoBehaviour
    {
        protected UIManager() { }
        public static UIManager Instance = null;

        [SerializeField]
        UIStyle currentUIStlye;


        void Awake()
        {
            if (Instance == null)
                Instance = this;
            else if (Instance != this)
                Destroy(gameObject);

            DontDestroyOnLoad(gameObject);
        }

    }
}