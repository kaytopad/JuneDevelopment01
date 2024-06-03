using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowCountroller : MonoBehaviour
{
    GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        //プレイヤーをGameObjectに代入
        this.player = GameObject.Find("player");
    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.Find("GameDirector").GetComponent<GameDirector>().IsGameOver())
        {
            Destroy(this);
            return;
        }
        //フレームごとに等速で落下
        transform.Translate(0, -0.1f, 0);
        //画面外に出たらオブジェクトを破棄
        if (transform.position.y < -5.0f)
        {
            Destroy(gameObject);
        }
        //当たり判定
        Vector2 p1 = transform.position;                //矢の中心座標
        Vector2 p2 = this.player.transform.position;    //プレイヤーの中心座標
        Vector2 dir = p1 - p2;
        float d = dir.magnitude;
        float r1 = 0.5f;                                //矢の半径
        float r2 = 1.0f;                                //プレイヤーの半径

        if (d < r1 + r2)
        {
            //ディレクタースクリプトにプレイヤーと衝突したことを伝える
            GameObject director = GameObject.Find("GameDirector");
            director.GetComponent<GameDirector>().DecreaseHp();
            //衝突したので矢を消す
            Destroy(gameObject);
        }

    }
}
