using UnityEngine;
using System;

public class SequenceExecutorr : MonoBehaviour
{
    private int currentSequenceDatasIndex;

    public Sequencee[] sequenceDatas;

    public void PlaySequence(Action action)
    {
        foreach (var sequence in sequenceDatas)
        {
            if (sequence == null)
            {
                return;
            }

            sequence.StartSequence(() =>
            {
                if (IsEndSequenceDatas())
                {
                    action?.Invoke();
                }
            });
        }
    }

    private bool IsEndSequenceDatas()
    {
        return ++currentSequenceDatasIndex >= sequenceDatas.Length;
    }
}