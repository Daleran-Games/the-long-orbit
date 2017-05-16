using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DaleranGames.TheLongOrbit
{
    public class GameManager : MonoBehaviour
    {
        /* TODO:
         * Add battle state machine
         * Initialization and quit instructions
         */
        protected GameManager() { }
        public static GameManager Instance = null;

        public enum BattleRange
        {
            DangerClose = 0,
            GunRamge = 1,
            CannonRange = 2,
            MissleRange = 3,
            OutOfRange = 4,
            EscapeRange = 5
        }

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
