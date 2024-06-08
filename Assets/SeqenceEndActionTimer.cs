using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeqenceEndActionTimer : SequenceDataEndAction
{
    public float delayTime;

    public override void EndAction(Action endAction)
    {
        StartCoroutine(EndActionTimer(endAction));
    }

    private IEnumerator EndActionTimer(Action endAction)
    {
        yield return new WaitForSeconds(delayTime);
        endAction?.Invoke();
        Debug.Log("End");
    }
}
