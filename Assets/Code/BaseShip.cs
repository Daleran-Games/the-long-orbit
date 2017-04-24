using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace TheLongOrbit
{
    public class BaseShip : MonoBehaviour
    {
        /* TODO:
         * Finish Damage Stats
         * Add Actions for other scripts to hook into
         * Develop derived stat calculations
         */


        [Header("Base Attributes")]
        [SerializeField]
        int accuracy = 3;
        public int Accuracy
        {
            get { return accuracy; }
            set
            {
                if (value < 0)
                    accuracy = 0;
                else
                    accuracy = value;
            }
        }

        [SerializeField]
        int speed = 4;
        public int Speed
        {
            get { return speed; }
            set
            {
                if (value < 0)
                    speed = 0;
                else
                    speed = value;
            }
        }

        [SerializeField]
        int maneuverability = 3;
        public int Maneuverability
        {
            get { return maneuverability; }
            set
            {
                if (value < 0)
                    maneuverability = 0;
                else
                    maneuverability = value;
            }
        }

        [SerializeField]
        int hitPoints = 8;
        public int HitPoints
        {
            get { return hitPoints; }
            set
            {
                if (value < 0)
                    hitPoints = 0;
                else if (value > MaxHitPoints)
                    hitPoints = MaxHitPoints;
                else
                    hitPoints = 0;
            }
        }

        [SerializeField]
        int maxHitPoints = 8;
        public int MaxHitPoints
        {
            get { return maxHitPoints; }
            set
            {
                if (value < 0)
                    maxHitPoints = 0;
                else
                    maxHitPoints = value;
            }
        }

        [SerializeField]
        int minDamage;
        public int MinDamage
        {
            get { return minDamage; }
            set
            {
                if (value < 0)
                    maxHitPoints = 0;
                else
                    maxHitPoints = value;
            }
        }

        [SerializeField]
        int maxDamage;
        public int MaxDamage
        {
            get { return maxDamage; }
            set
            {
                if (value < 0)
                    maxHitPoints = 0;
                else
                    maxHitPoints = value;
            }
        }


        [Header("Derived Stats")]
        [SerializeField]
        float evadeChance;
        public float EvadeChance
        {
            get { return evadeChance; }
        }

        [SerializeField]
        float hitChance;
        public float HitChance
        {
            get { return hitChance; }
        }

        [SerializeField]
        float advanceChance;
        public float AdvanceChance
        {
            get { return advanceChance; }
        }

        [SerializeField]
        float fallbackChance;
        public float FallbackChance
        {
            get { return fallbackChance; }
        }


        void CalculateDerivedStats()
        {

        }
    }
}
