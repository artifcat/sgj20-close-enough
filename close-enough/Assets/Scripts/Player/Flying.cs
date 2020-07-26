using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flying : MonoBehaviour
{
    public float velocity = 1;
    public Animator animator;
    [SerializeField]
    private IcarusState state;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if(state.hasWings)
            {
                rb.velocity = Vector3.up * velocity;
            }
            animator.SetTrigger("flap");
        }
    }
}
