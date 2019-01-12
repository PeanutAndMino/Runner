using UnityEngine;
using System.Collections;

[CreateAssetMenu(fileName = "PowerUp", menuName = "Power Ups/Power Up", order = 1)]
public class PowerUpSO : ScriptableObject
{
    public string powerUpName = "A Power Up";
    public PowerUp powerUpType = PowerUp.JUMP;
}