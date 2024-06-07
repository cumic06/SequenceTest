using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sequence : MonoBehaviour
{
    private Action OnEnd = null;

    private int currentSequenceDataIndex = 0;
    public List<SequenceData> sequenceDatas = new List<SequenceData>();

    public void StartSequnceData(Action OnEnd)
    {
        this.OnEnd = OnEnd;

        if (sequenceDatas.Count <= 0)
        {
            EndSeqeunceData();
            return;
        }

        PlaySequenceData(sequenceDatas[currentSequenceDataIndex]);
    }

    private void PlaySequenceData(SequenceData sequenceData)
    {
        sequenceData.PlaySequence(() =>
        {
            if (EndCheckSequenceData())
                EndSeqeunceData();
            else
                PlaySequenceData(sequenceDatas[currentSequenceDataIndex]);
        });
    }

    private bool EndCheckSequenceData()
    {
        return ++currentSequenceDataIndex >= sequenceDatas.Count;
    }

    private void EndSeqeunceData()
    {
        OnEnd?.Invoke();
        currentSequenceDataIndex = 0;
    }
}
