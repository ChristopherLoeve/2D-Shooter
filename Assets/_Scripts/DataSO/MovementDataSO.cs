using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Agent/MovementData")]
public class MovementDataSO : ScriptableObject
{
    [Range(1,10)] public float MaxSpeed = 5;
    [Range(0.1f, 100)] public float Acceleration = 50;
    [Range(0.1f, 100)] public float Deacceleration = 50;
}
