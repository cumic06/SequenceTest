using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class SequenceDataa : MonoBehaviour
{
    private SequenceDataEndAction sequenceDataEndAction;

    public List<UnityEvent> sequeceEvents = new();

    private void Awake()
    {
        sequenceDataEndAction = GetComponent<SequenceDataEndAction>();
    }

    public void PlaySequence(Action onSequenceAction)
    {
        foreach (var sequece in sequeceEvents)
        {
            sequece?.Invoke();
        }
        sequenceDataEndAction.EndAction(onSequenceAction);
    }
}
