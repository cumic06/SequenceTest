using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIImageTest : MonoBehaviour
{
    public Image image;
    public float imageLerpTime = 1.0f;

    public void Fill0to1Lerp()
    {
        FillImageLerp(0, 1);
    }

    public void Fill1to0Lerp()
    {
        FillImageLerp(1, 0);
    }

    public void FillImageLerp(int startFillAmount, int endFillAmount)
    {
        StartCoroutine(StartFillImage(startFillAmount, endFillAmount));
    }

    private IEnumerator StartFillImage(int startFillAmount, int endFillAmount)
    {
        float imageLerpTimer = 0;
        while (imageLerpTimer <= imageLerpTime)
        {
            imageLerpTimer = imageLerpTimer > imageLerpTime ? imageLerpTime : imageLerpTimer + Time.deltaTime;
            image.fillAmount = Mathf.Lerp(startFillAmount, endFillAmount, imageLerpTimer / imageLerpTime);
            yield return null;
        }
    }

    public void Fade0to1Lerp()
    {
        FadeImageLerp(0, 1);
    }

    public void Fade1to0Lerp()
    {
        FadeImageLerp(1, 0);
    }

    public void FadeImageLerp(int startFillAmount, int endFillAmount)
    {
        StartCoroutine(StartFadeImage(startFillAmount, endFillAmount));
    }

    private IEnumerator StartFadeImage(int startFillAmount, int endFillAmount)
    {
        float imageLerpTimer = 0;
        while (imageLerpTimer <= imageLerpTime)
        {
            imageLerpTimer = imageLerpTimer > imageLerpTime ? imageLerpTime : imageLerpTimer + Time.deltaTime;
            image.color = new Color(image.color.r, image.color.g, image.color.b, Mathf.Lerp(startFillAmount, endFillAmount, imageLerpTimer / imageLerpTime));
            yield return null;
        }
    }
}
