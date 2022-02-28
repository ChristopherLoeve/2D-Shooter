using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Weapons/WeaponData")]
public class WeaponDataSO : ScriptableObject
{
    [field: SerializeField] [field: Min(0)] public int AmmoCapacity { get; internal set; } = 100;
    [field: SerializeField] public bool AutomaticFire { get; internal set; } = false;
    [field: SerializeField] [field: Range(0.1f, 2f)] public float WeaponDelay { get; internal set; } = .1f;
    [field: SerializeField] [field: Range(0, 10)] public float SpreadAngle { get; set; } = 5;
    [SerializeField] private bool multiBulletShot = false;
    [SerializeField] [field: Range(1, 10)] private int bulletCount = 1;

    internal int GetBulletCountToSpawn()
    {
        if (multiBulletShot)
        {
            return bulletCount;
        }
        return 1;
    }
}
