using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace DaleranGames.TheLongOrbit
{
    public class BaseShip : MonoBehaviour
    {
        /* TODO:
         * Finish Damage Stats
         * Add Actions for other scripts to hook into
         * Develop derived stat calculations
         */

        [Header("Descriptors")]
        [SerializeField]
        string shipName = "DefaultShip";
        public Action<string> ShipNameChanged;
        public string ShipName
        {
            get { return shipName; }
            set
            {
                shipName = value;

                if (ShipNameChanged != null)
                    ShipNameChanged(shipName);
            }
        }

        [Header("Base Attributes")]
        [SerializeField]
        int accuracy = 3;
        public Action<int> AccuracyChanged;
        public int Accuracy
        {
            get { return accuracy; }
            set
            {
                if (value < 0)
                    accuracy = 0;
                else
                    accuracy = value;

                if (AccuracyChanged != null)
                    AccuracyChanged(accuracy);

                CalculateDerivedStats();
            }
        }

        [SerializeField]
        int speed = 4;
        public Action<int> SpeedChanged;
        public int Speed
        {
            get { return speed; }
            set
            {
                if (value < 0)
                    speed = 0;
                else
                    speed = value;

                if (SpeedChanged !=null)
                    SpeedChanged(speed);

                CalculateDerivedStats();
            }
        }

        [SerializeField]
        int maneuverability = 3;
        public Action<int> ManeuverabilityChanged;
        public int Maneuverability
        {
            get { return maneuverability; }
            set
            {
                if (value < 0)
                    maneuverability = 0;
                else
                    maneuverability = value;

                if (ManeuverabilityChanged !=null)
                    ManeuverabilityChanged(maneuverability);

                CalculateDerivedStats();
            }
        }

        [SerializeField]
        int hitPoints = 8;
        public Action<int> HitPointsChanged;
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

                if (HitPointsChanged !=null)
                    HitPointsChanged(hitPoints);

            }
        }

        [SerializeField]
        int maxHitPoints = 8;
        public Action<int> MaxHitPointsChanged;
        public int MaxHitPoints
        {
            get { return maxHitPoints; }
            set
            {
                if (value < 0)
                    maxHitPoints = 0;
                else
                    maxHitPoints = value;

                if (MaxHitPointsChanged != null)
                    MaxHitPointsChanged(maxHitPoints);
            }
        }

        [SerializeField]
        int minDamage=1;
        public Action<int> MinDamageChanged;
        public int MinDamage
        {
            get { return minDamage; }
            set
            {
                if (value < 0)
                    minDamage = 0;
                else
                    minDamage = value;

                if (minDamage > MaxDamage)
                    MaxDamage = minDamage;

                if (MinDamageChanged != null)
                    MinDamageChanged(minDamage);
            }
        }

        [SerializeField]
        int maxDamage=3;
        public Action<int> MaxDamageChanged;
        public int MaxDamage
        {
            get { return maxDamage; }
            set
            {
                if (value < 0)
                {
                    MinDamage = 0;
                    maxDamage = 0;
                }
                else
                   maxDamage = value;

                if (maxDamage < MinDamage)
                    MinDamage = maxDamage;

                if (MaxDamageChanged != null)
                    MaxDamageChanged(maxDamage);
            }
        }


        [Header("Derived Stats")]
        [SerializeField]
        float evadeChance;
        public Action<float> EvadeChanceChanged;
        public float EvadeChance
        {
            get { return evadeChance; }
            protected set
            {
                evadeChance = value;

                if (EvadeChanceChanged != null)
                    EvadeChanceChanged(evadeChance);
            }
        }

        [SerializeField]
        float hitChance;
        public Action<float> HitChanceChanged;
        public float HitChance
        {
            get { return hitChance; }
            protected set
            {
                hitChance = value;

                if (HitChanceChanged != null)
                    HitChanceChanged(hitChance);
            }
        }

        [SerializeField]
        float moveChance;
        public Action<float> MoveChanceChanged;
        public float MoveChance
        {
            get { return moveChance; }
            protected set
            {
                moveChance = value;

                if (MoveChanceChanged != null)
                    MoveChanceChanged(moveChance);
            }
        }

        private void Awake()
        {
            CalculateDerivedStats();
        }

        [ContextMenu("Calculate Derived Stats")]
        void CalculateDerivedStats()
        {
            EvadeChance = Mathf.Exp(-4f * Mathf.Exp(0.1f * (-Maneuverability - (Speed * 0.25f))));
            HitChance = 1f / (1 + Mathf.Exp(- Accuracy * 0.1f));
            MoveChance = 1f / (1 + Mathf.Exp(-Speed * 0.1f));

        }


    }
}
