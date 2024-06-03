using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowGenerator : MonoBehaviour
{
    //Game�I�u�W�F�N�g��ǉ�
    public GameObject arrowPrefab;
    //�X�p���Ő���
    float span = 0.5f;
    float delta = 0;
    //�f���^�^�C���̐ݒ�
    // Update is called once per frame
    void Update()
    {
        if (GameObject.Find("GameDirector").GetComponent<GameDirector>().IsGameOver())
        {
            Destroy(this);
            return;
        }
        //�t���[���J�E���g���擾
        this.delta += Time.deltaTime;
        if (this.delta > this.span)
        {
            this.delta = 0;
            //�Q�[���I�u�W�F�N�g����
            GameObject go = Instantiate(arrowPrefab);
            int px = Random.Range(-6, 7);
            go.transform.position = new Vector3(px, 7, 0);
        }

        
    }
}
