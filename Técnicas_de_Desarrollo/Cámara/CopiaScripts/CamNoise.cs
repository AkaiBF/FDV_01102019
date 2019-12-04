using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CamNoise : MonoBehaviour
{
    public CamNoise instance;
    private CinemachineVirtualCamera vcam;
    private CinemachineBasicMultiChannelPerlin noise;

    // Awake is called before the game starts
    void Awake()
    {
      instance = this;
      vcam = GetComponent<CinemachineVirtualCamera>();
      noise = vcam.GetCinemachineComponent<CinemachineBasicMultiChannelPerlin>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Shake(float duration)
    {
      instance.StopAllCoroutines();
      instance.StartCoroutine(instance.cShake(duration));
    }

    public IEnumerator cShake(float duration)
    {
      while (duration > 0)
      {
        noise.m_AmplitudeGain = 1f;
        duration -= Time.deltaTime;
        yield return null;
      }
      noise.m_AmplitudeGain = 0f;
    }
}
