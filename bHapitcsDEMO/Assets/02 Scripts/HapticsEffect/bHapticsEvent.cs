using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Bhaptics.SDK2;
using TMPro;
using UnityEditor;

public class bHapticsEvent : MonoBehaviour
{
    [SerializeField] private Slider BombSlider;
    [SerializeField] private float fontSize = 5f;
    [SerializeField] private TextMeshProUGUI text;
    [SerializeField] private GameObject Cube; 
    public void Gun()
    {
        BhapticsLibrary.Play(BhapticsEvent.GUUUUN);
    }

    public void shotGun()
    {
        BhapticsLibrary.Play(BhapticsEvent.SHOTGUN);
    }

    public void Bomb()
    {
        BhapticsLibrary.Play(BhapticsEvent.BOOOMB);
    }
    public void Knife()
    {
        BhapticsLibrary.Play(BhapticsEvent.KNIFE);
    }

    public void modulateSlider()
    {

    }

    public void textAnimation()
    {
        // 글자 튀어나오는 효과 
    }

    public void Reset()
    {
        Cube.GetComponent<Cube>().Reset(); 
    }

    public void ExplosionCube()
     {
        Cube.GetComponent<Cube>().Explosion(); 
    }
}
