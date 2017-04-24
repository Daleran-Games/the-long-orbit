using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TheLongOrbit
{
    public class GameManager : MonoBehaviour
    {
        /* TODO:
         * Add battle state machine
         * Initialization and quit instructions
         */
        protected GameManager() { }
        public static GameManager Instance = null;

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
