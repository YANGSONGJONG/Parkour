using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace YANGSONGJING
{
    /// <summary>
    /// 管理死亡
    /// </summary>
    public class ManageDead : MonoBehaviour
    {
        [SerializeField, Header("目標名稱")]
        private string nameTarget = "原住民";
        [SerializeField, Header("結束管理器")]
        private ManageFinal manageFinal;
        [SerializeField, Header("CM 攝影機控制物件")]
        private GameObject goCM;

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.name.Contains(nameTarget))
            {
                manageFinal.stringTitle = "挑戰失敗~";
                manageFinal.enabled = true;
                goCM.SetActive(false);
            }
        }
    }
    
    




}
