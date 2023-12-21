using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using DG.Tweening;

public class ClickerScipt : MonoBehaviour
{
    public float clickValue = 1;
    GameObject eggObject;
    // Start is called before the first frame update
    void Start()
    {
        eggObject = GameObject.FindGameObjectWithTag("Egg");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnClickPoint()
    {
        eggObject.GetComponent<EggController>().eggXp += 5;
        float clickValue = eggObject.GetComponent<EggController>().onClickShakeValue;
        eggObject.transform.GetChild(0).DOPunchScale(new Vector3(clickValue, clickValue, clickValue), 0.1f, 5, 0.1f);
        eggObject.GetComponent<EggController>().EffectOnClick();

    }

}
