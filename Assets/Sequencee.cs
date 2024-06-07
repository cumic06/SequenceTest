using System.Collections.Generic;
using UnityEngine;
using System;

public class Sequencee : MonoBehaviour
{
    private Action onEnd;
    private int currentSequenceDataIndex;
    public List<SequenceDataa> sequenceDatas = new();

    public void StartSequence(Action onEnd)
    {
        this.onEnd = onEnd;

        if (sequenceDatas.Count <= 0)
        {
            EndSequenceData();
            return;
        }
        PlaySequenceData(sequenceDatas[currentSequenceDataIndex]);
    }

    private void PlaySequenceData(SequenceDataa sequenceData)
    {
        sequenceData.PlaySequence(() =>
        {
            if (IsEndSequnceData())
            {
                EndSequenceData();
            }
            else
            {
                PlaySequenceData(sequenceDatas[currentSequenceDataIndex]);
            }
        });
    }

    private bool IsEndSequnceData()
    {
        return ++currentSequenceDataIndex >= sequenceDatas.Count;
    }

    private void EndSequenceData()
    {
        onEnd?.Invoke();
        currentSequenceDataIndex = 0;
    }
}