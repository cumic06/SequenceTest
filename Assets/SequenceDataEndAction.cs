using UnityEngine;
using System;

public class SequenceDataEndAction : MonoBehaviour
{
    public virtual void EndAction(Action endAction)
    {
        endAction?.Invoke();
    }
}