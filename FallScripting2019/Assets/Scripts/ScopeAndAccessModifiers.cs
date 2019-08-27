﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScopeAndAccessModifiers : MonoBehaviour
{
    // Unity Tutorial Variant
    
    public int alpha;
    private int beta = 0;
    private int gamma = 5;

    private void Example(int twigs, int leaves)
    {
        int answer;
        answer = twigs * leaves * alpha;
        Debug.Log(answer);
    }

    private void Update()
    {
        Debug.Log("Alpha is set to: " + alpha);
    }
}