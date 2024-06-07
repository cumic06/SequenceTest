using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SequenceDataEndSend_Timer : SequenceDataEndSend
{
    public float timer;

    public override void SendEnd(Action OnEnd)
    {
        StartCoroutine(StartEndTimer(OnEnd));
    }

    private IEnumerator StartEndTimer(Action OnEnd)
    {
        yield return new WaitForSeconds(timer);

        OnEnd?.Invoke();
    }
}
