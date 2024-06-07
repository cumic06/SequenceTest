using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SequenceDataEndSend : MonoBehaviour
{
    public virtual void SendEnd(Action OnEnd)
    {
        OnEnd?.Invoke();
    }
}