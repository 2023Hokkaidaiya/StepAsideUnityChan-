using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemEraser : MonoBehaviour
{
    //Unity�����̃I�u�W�F�N�g
    private GameObject unitychan;


    //Unity�����Ƃ̋���
    private float difference;

    // Use this for initialization
    void Start()
    {
        //Unity�����̃I�u�W�F�N�g���擾
        this.unitychan = GameObject.Find("unitychan");

    }

    // Update is called once per frame
    void Update()
    {
        //Unity�����ƃR�C���̈ʒu�iz���W�j�̍������߂�
        this.difference = unitychan.transform.position.z - this.transform.position.z;
        //�����A�C�e�������j�e�B�����̌��ɍs������(difference6�ȏ�j
        if (this.difference >= 6) 
        //���̃A�C�e����j��
        { 
            Destroy(this.gameObject);
        }
    }
}
