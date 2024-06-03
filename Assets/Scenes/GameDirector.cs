using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameDirector : MonoBehaviour
{
    //�I�u�W�F�N�g
    GameObject hpGauge;
    public GameObject gameover;
    // Start is called before the first frame update
    void Start()
    {
        
        //�Q�[���I�u�W�F�N�g���擾
        this.hpGauge = GameObject.Find("hpGauge");
        gameover.SetActive(false);
    }

    private void Update()
    {
        if (IsGameOver())
        {
            this.gameover.SetActive(true);
        }
    }

    public bool IsGameOver()
    {
        if (hpGauge.GetComponent<Image>().fillAmount <=0.0f)
        {
            return true;
        }
        return false;
    }
    //�����蔻�肪��������A�Q�[�W�����炷���\�b�h�����
    public void DecreaseHp()
    {
        this.hpGauge.GetComponent<Image>().fillAmount -= 0.1f;
    }
}
