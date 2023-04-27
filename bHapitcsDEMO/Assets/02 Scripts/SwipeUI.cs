using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SpatialTracking;
using UnityEngine.UI;
using UnityEngine.UIElements;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;
public class SwipeUI : MonoBehaviour
{
    [SerializeField] private GameObject scrollbar;
    private float scrollPos = 0;
    private float[] pos;

    Hand rightHand = new Hand();
    Hand leftHand = new Hand();
    Bone rightHand_Bone = new Bone();
    Bone leftHand_bone = new Bone();

    List<InputDevice> inputDevices  = new List<InputDevice>();

    private void FixedUpdate()
    {
        InputDevices.GetDevicesWithCharacteristics(InputDeviceCharacteristics.HandTracking, inputDevices);
    }

    private void Update()
    {
        pos = new float[transform.childCount];
        float distance = 1f / (pos.Length - 1f);
        for(int i = 0; i<pos.Length; ++i)
        {
            pos[i] = distance * i;
        }

        //스크롤 UI 크기 조절 
        for(int i = 0; i<pos.Length; ++i)
        {
            if(scrollPos < pos[i] + (distance/2) && scrollPos > pos[i] - (distance/2))
            {
                transform.GetChild(i).localScale = Vector2.Lerp(transform.GetChild(i).localScale, new Vector2(1f, 1f), 0.1f);
                for(int j = 0; j<pos.Length; ++j)
                {
                    if(i==j)
                    {
                        transform.GetChild(j).localScale = Vector2.Lerp(transform.GetChild(j).localScale, new Vector2(0.8f, 0.8f), 0.1f);
                    }
                }
            }
        }
    }

 
}
