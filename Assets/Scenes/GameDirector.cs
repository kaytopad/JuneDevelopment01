using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameDirector : MonoBehaviour
{
    //オブジェクト
    GameObject hpGauge;
    public GameObject gameover;
    // Start is called before the first frame update
    void Start()
    {
        
        //ゲームオブジェクトを取得
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
    //当たり判定があったら、ゲージを減らすメソッドを作る
    public void DecreaseHp()
    {
        this.hpGauge.GetComponent<Image>().fillAmount -= 0.1f;
    }
}
