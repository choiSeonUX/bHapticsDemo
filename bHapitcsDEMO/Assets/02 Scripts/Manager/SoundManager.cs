using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class SoundManager : SingletonBehaviour<SoundManager>
{

    [SerializeField] AudioSource effect;
    [SerializeField] AudioSource BGM;
    [SerializeField] AudioClip[] effectList;

    Dictionary<string, AudioClip> EffectList;

    private void Start()
    {
        EffectList = new Dictionary<string, AudioClip>();
        // 추후 쓸 때 effectList.add(name, audioEffect[index]); 
    }
    public void BGSoundPlay(AudioClip audioClip)
    {
        BGM.clip = audioClip;
        BGM.loop = true;
        BGM.volume = 0.1f;
        BGM.Play();

    }

    public void setEffect(string name)
    {
        effect.clip = EffectList[name];
        effect.PlayOneShot(effect.clip); 
    }

}
