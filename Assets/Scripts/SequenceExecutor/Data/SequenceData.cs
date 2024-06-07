using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(SequenceDataEndAction))]
public class SequenceData : MonoBehaviour
{
    private SequenceDataEndSend sequenceDataEndSend;
    public List<UnityEvent> sequences = new List<UnityEvent>();

    private void Awake()
    {
        sequenceDataEndSend = GetComponent<SequenceDataEndSend>();
    }

    public void PlaySequence(Action OnSequenceEnd)
    {
        foreach (var sequence in sequences)
            sequence?.Invoke();

        sequenceDataEndSend.SendEnd(OnSequenceEnd);
    }
}
