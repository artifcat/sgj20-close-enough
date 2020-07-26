using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WingDisplay : MonoBehaviour
{
    [SerializeField]
    private IcarusState state;
    [SerializeField]
    private Image bar;

    private float barValue = 1f;
    private float newValue;

    void Update()
    {
        newValue = state.GetDurabilityPercent();
        if(!NearlyEqual(barValue, newValue))
        {
            barValue = newValue;
            bar.fillAmount = barValue;
        }
    }

    private bool NearlyEqual(float f1, float f2)
    {
        return Mathf.Abs(f1-f2) < 0.00001f;
    }
}
