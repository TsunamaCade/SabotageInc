using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Animancer;

public class Move : MonoBehaviour
{
    [SerializeField] private CharacterController cc;
    [SerializeField] private AnimancerComponent animancerComponent;
    [SerializeField] private AnimationClip walk, idle;
    private Vector3 move;
    [SerializeField] private float moveSpeed;
    [SerializeField] private float turnSpeed;
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        move = (transform.forward * z);

        cc.Move(move * moveSpeed * Time.deltaTime);

        transform.Rotate(0, x * turnSpeed * Time.deltaTime, 0);

        if(cc.velocity.magnitude >= 0.1)
        {
            animancerComponent.Play(walk);
        }
        else if(cc.velocity.magnitude < 0.1)
        {
            animancerComponent.Play(idle, 0.25f);
        }
    }
}
