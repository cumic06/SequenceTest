using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainManager : Singleton<MainManager>
{
    public SequenceExecutor sequenceExecutor;

    [Space]

    public Button startButton;

    [Space]

    public Material skybox;
    public GameObject skyboxCloud;
    public float skyboxRotateSpeed = 1;
    private float skyboxRotation = 0;

    private void Start()
    {
        AddEvent();
    }

    private void Update()
    {
        UpdateSkybox();
    }

    private void OnDestroy()
    {
        RemoveEvent();
    }

    private void AddEvent()
    {
        startButton.onClick.AddListener(HandleOnStartButton);
    }

    private void RemoveEvent()
    {
        startButton.onClick.RemoveListener(HandleOnStartButton);
    }

    private void HandleOnStartButton()
    {
        PlaySequence();
        startButton.interactable = false;
    }

    private void PlaySequence()
    {
        sequenceExecutor.PlaySequence(() => SceneLoadManager.Instance.LoadIntroScene());
    }

    private void UpdateSkybox()
    {
        skyboxRotation += skyboxRotateSpeed * Time.deltaTime;
        skyboxCloud.transform.eulerAngles = new Vector3(0, -skyboxRotation, 0);
        skybox.SetFloat("_Rotation", skyboxRotation);
    }
}
