using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class IntroSequenceManager : MonoBehaviour
{
    public SequenceExecutorr sequenceExecutor;
    public Button startButton;

    public void Start()
    {
        startButton.onClick.AddListener(PlaySequence);
    }

    private void PlaySequence()
    {
        sequenceExecutor.PlaySequence(() => SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1));
    }

    private void OnDestroy()
    {
        startButton.onClick.RemoveAllListeners();
    }
}
