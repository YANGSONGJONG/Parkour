using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace YANGSONGJING
{
    public class ManagePass : MonoBehaviour
    {
        [SerializeField, Header("目標名稱")]
        private string nameTarget = "原住民";
        [SerializeField, Header("跑步系統")]
        private SystemRun systemRun;
        [SerializeField, Header("跳躍系統")]
        private systemJump systemJump;
        [SerializeField, Header("結束管理器")]
        private ManageFinal managefinal;

        #region 其中一個物件有勾選 Is Trigger
        // 兩個物件碰撞時執行一次
        private void OnTriggerEnter2D(Collider2D collision)
        {
            // print(collision.name);

            // 如果 碰撞物名稱 包含(原住民)
            if (collision.name.Contains(nameTarget))
            {
                systemRun.enabled = false;  //關閉跑步系統
                systemJump.enabled = false; //關閉跳躍系統
                managefinal.enabled = true;
                managefinal.stringTitle = "恭喜你過關~";
            }
        }
        // 兩個物件碰撞離開時執行一次
        private void OnTriggerExit2D(Collider2D collision)
        {

        }

        //兩個物件碰撞重疊時持續執行
        private void OnTriggerStay2D(Collider2D collision)
        {

        }
        #endregion

        #region 兩個物件都沒有勾選 Is Trigger
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



