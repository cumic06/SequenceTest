using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SequenceExecutor : MonoBehaviour
{
    private int currentSequenceIndex = 0;
    public Sequence[] startPlaySequences;

    public void PlaySequence(Action OnEnd = null)
    {
        for (int i = 0; i < startPlaySequences.Length; i++)
            startPlaySequences[i].StartSequnceData(() =>
            {
                if (EndCheckSequence())
                    OnEnd?.Invoke();
            });
    }

    private bool EndCheckSequence()
    {
        return ++currentSequenceIndex >= startPlaySequences.Length;
    }
}
