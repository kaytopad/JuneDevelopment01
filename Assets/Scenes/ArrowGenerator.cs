using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowGenerator : MonoBehaviour
{
    //Gameオブジェクトを追加
    public GameObject arrowPrefab;
    //スパンで生成
    float span = 0.5f;
    float delta = 0;
    //デルタタイムの設定
    // Update is called once per frame
    void Update()
    {
        if (GameObject.Find("GameDirector").GetComponent<GameDirector>().IsGameOver())
        {
            Destroy(this);
            return;
        }
        //フレームカウントを取得
        this.delta += Time.deltaTime;
        if (this.delta > this.span)
        {
            this.delta = 0;
            //ゲームオブジェクト生成
            GameObject go = Instantiate(arrowPrefab);
            int px = Random.Range(-6, 7);
            go.transform.position = new Vector3(px, 7, 0);
        }

        
    }
}
