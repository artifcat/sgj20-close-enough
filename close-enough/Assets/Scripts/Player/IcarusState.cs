using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "IcarusState", menuName = "close-enough/IcarusState", order = 1)]
public class IcarusState : ScriptableObject
{
    public bool hasWings;
    public float wingDurability;
    [SerializeField]
    private float maxWingDurability;

    public float GetDurabilityPercent()
    {
        return wingDurability/maxWingDurability;
    }

    public void ResetDurability()
    {
        wingDurability = maxWingDurability;
    }

    public void DamageWings(float amount)
    {
        wingDurability -= amount;
        if(wingDurability <= 0)
        {
            wingDurability = 0f;
            hasWings = false;
        }
    }
}
