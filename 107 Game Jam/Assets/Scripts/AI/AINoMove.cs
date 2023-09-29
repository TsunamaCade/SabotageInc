using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Animancer;

public class AINoMove : MonoBehaviour
{
    [SerializeField] private AnimancerComponent animancerComponent;
    [SerializeField] private AnimationClip idleAnimation;
    void Start()
    {
        animancerComponent.Play(idleAnimation);
    }
}
