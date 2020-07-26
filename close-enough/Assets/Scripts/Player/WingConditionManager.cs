using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WingConditionManager : MonoBehaviour
{
    public float damageMultiplier = 1f;
    [SerializeField]
    private IcarusState state;
    [SerializeField]
    private SkinnedMeshRenderer wings;
    [SerializeField]
    private ParticleSystem smokeFX;
    [SerializeField]
    private AudioSource scream;

    private bool wingLossTriggered;

    void Start()
    {
        state.hasWings = true;
        state.ResetDurability();
        wingLossTriggered = false;
    }
    
    private void OnTriggerStay(Collider other) {
        if(other.CompareTag("sun"))
        {
            var distance = Vector3.Distance(other.transform.position, this.transform.position);
            state.DamageWings(damageMultiplier/distance);
            if(!state.hasWings && !wingLossTriggered)
            {
                wingLossTriggered = true;
                scream.Play();
                wings.enabled = false;
                smokeFX.Play();
            }
        }
    }
}
