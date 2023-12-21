using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;
using DG.Tweening;
using Unity.VisualScripting;

public class EggController : MonoBehaviour
{
    public float eggXp;
    public float levelXp = 20;
    public float currentLevel = 1;
    public float levelXpValue;
    public TextMeshProUGUI xpText;
    public TextMeshProUGUI levelText;
    public float scaleUpValue = 0.02f;
    public float scaleUpValueDrag = 0.02f;
    public GameObject woodDown;
    public GameObject rockDown;

    public GameObject dragon;

    public List<float> levels;
    public List<GameObject> eggs;

    public float onClickShakeValue=0.01f;

    public ParticleSystem clickEffect;



    // Start is called before the first frame update
    void Start()
    {
        clickEffect.Stop();

    }

    // Update is called once per frame
    void Update()
    {
        xpText.text = eggXp + " / " + levelXpValue;
        UpdateCurrentLevel();
    }

    void UpdateCurrentLevel()
    {
        for(int i=0; i <levels.Count; i++)
        {
            float cLevelValue = levels[i];
            if (eggXp >= cLevelValue)
            {
                levelXpValue = levels[i+1];
                if (currentLevel == i + 1)
                {
                    currentLevel = i + 2;
                    GetLevel(currentLevel);
                }
            }
        }
    }

    void GetLevel(float levelValue)
    {
        levelText.text = "Level " + currentLevel;

        switch (levelValue)
        {
            case 1:
                onClickShakeValue = 0.01f;
                break;
            case 2:
                onClickShakeValue += 0.005f;
                eggs[0].transform.DOScale(new Vector3(eggs[0].transform.localScale.x + scaleUpValue, eggs[0].transform.localScale.y + scaleUpValue, eggs[0].transform.localScale.z + scaleUpValue), 1f);

                //if (gameObject.transform.GetChild(0).gameObject.tag == "eggMesh")

                // Instantiate(dragon,transform.position,transform.rotation);
                break;
            case 3:
                eggs[0].transform.DOScale(new Vector3(eggs[0].transform.localScale.x + scaleUpValue, eggs[0].transform.localScale.y + scaleUpValue, eggs[0].transform.localScale.z + scaleUpValue), 1f);

                onClickShakeValue += 0.005f;
                break;
            case 4:
                eggs[0].transform.DOScale(new Vector3(eggs[0].transform.localScale.x + scaleUpValue, eggs[0].transform.localScale.y + scaleUpValue, eggs[0].transform.localScale.z + scaleUpValue), 1f);

                onClickShakeValue += 0.005f;
                woodDown.active = false;
                rockDown.active = true;
                break;
            case 5:

                onClickShakeValue = 0.05f;
                dragon.active = true;
                Destroy(gameObject.transform.GetChild(0).gameObject);
                break;
            case 6:
                onClickShakeValue += 0.01f;
                dragon.transform.DOScale(new Vector3(dragon.transform.localScale.x + scaleUpValueDrag, dragon.transform.localScale.y + scaleUpValueDrag, dragon.transform.localScale.z + scaleUpValueDrag), 0.1f);
                rockDown.active = false;

                break;

            case 7:
                onClickShakeValue += 0.01f;
                dragon.transform.DOScale(new Vector3(dragon.transform.localScale.x + scaleUpValueDrag, dragon.transform.localScale.y + scaleUpValueDrag, dragon.transform.localScale.z + scaleUpValueDrag), 0.1f);
                break;
            case 8:
                onClickShakeValue += 0.01f;
                dragon.transform.DOScale(new Vector3(dragon.transform.localScale.x + scaleUpValueDrag, dragon.transform.localScale.y + scaleUpValueDrag, dragon.transform.localScale.z + scaleUpValueDrag), 0.1f);
                break;
            case 9:
                onClickShakeValue += 0.01f;
                dragon.transform.DOScale(new Vector3(dragon.transform.localScale.x + scaleUpValueDrag, dragon.transform.localScale.y + scaleUpValueDrag, dragon.transform.localScale.z + scaleUpValueDrag), 0.1f);
                break;
            case 10:
                onClickShakeValue += 0.01f;
                dragon.transform.DOScale(new Vector3(dragon.transform.localScale.x + scaleUpValueDrag, dragon.transform.localScale.y + scaleUpValueDrag, dragon.transform.localScale.z + scaleUpValueDrag), 0.1f);
                break;

        }
        
    }
    public void EffectOnClick()
    {
        clickEffect.Play();
    }

}
