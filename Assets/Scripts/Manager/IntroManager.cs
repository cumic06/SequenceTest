using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntroManager : Singleton<IntroManager>
{
    public SequenceExecutor sequenceExecutor;

    private void Start()
    {
        AddEvent();
        PlaySequence();
    }

    private void OnDestroy()
    {
        RemoveEvent();
    }

    private void AddEvent()
    {
    }

    private void RemoveEvent()
    {
    }

    private void PlaySequence()
    {
        sequenceExecutor.PlaySequence(() => SceneLoadManager.Instance.LoadGameScene());
    }
}
