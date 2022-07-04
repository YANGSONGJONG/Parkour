using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace YANGSONGJING
{
    public class ManagePass : MonoBehaviour
    {
        [SerializeField, Header("�ؼЦW��")]
        private string nameTarget = "����";
        [SerializeField, Header("�]�B�t��")]
        private SystemRun systemRun;
        [SerializeField, Header("���D�t��")]
        private systemJump systemJump;
        [SerializeField, Header("�����޲z��")]
        private ManageFinal managefinal;

        #region �䤤�@�Ӫ��󦳤Ŀ� Is Trigger
        // ��Ӫ���I���ɰ���@��
        private void OnTriggerEnter2D(Collider2D collision)
        {
            // print(collision.name);

            // �p�G �I�����W�� �]�t(����)
            if (collision.name.Contains(nameTarget))
            {
                systemRun.enabled = false;  //�����]�B�t��
                systemJump.enabled = false; //�������D�t��
                managefinal.enabled = true;
                managefinal.stringTitle = "���ߧA�L��~";
            }
        }
        // ��Ӫ���I�����}�ɰ���@��
        private void OnTriggerExit2D(Collider2D collision)
        {

        }

        //��Ӫ���I�����|�ɫ������
        private void OnTriggerStay2D(Collider2D collision)
        {

        }
        #endregion

        #region ��Ӫ��󳣨S���Ŀ� Is Trigger
        private void OnCollisionEnter2D(Collision2D collision)
        {

        }

        private void OnCollisionExit2D(Collision2D collision)
        {

        }

        private void OnCollisionStay2D(Collision2D collision)
        {

        }
        #endregion
    }
}



