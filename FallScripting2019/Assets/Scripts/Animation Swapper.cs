using System;
using UnityEngine;
using System.Collections;
using Tutorial_Variants;

public class ExampleClass : MonoBehaviour
{
    public Animation anim;

    void Start()
    {
        anim = GetComponent<Animation>();
        foreach (AnimationState state in anim)
        {
            state.speed = 0.5F;
        }

        anim.Play();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            anim.clip.length();
        }
    }
}