using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flying : MonoBehaviour
{
    public float velocity = 1;
    public Animator animator;
    [SerializeField]
    private IcarusState icarusState;
    [SerializeField]
    private GameState gameState;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if(gameState.IsPlaying)
        {
            rb.isKinematic = false;
            if (Input.GetButtonDown("Jump"))
            {
                if(icarusState.hasWings)
                {
                    rb.velocity = Vector3.up * velocity;
                }
                animator.SetTrigger("flap");
            }
        }
    }
}
