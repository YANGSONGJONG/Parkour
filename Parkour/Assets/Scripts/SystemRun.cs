
using UnityEngine;

namespace YANGSONGJING
{
    /// <summary>
    /// 跑步系統
    /// </summary>

    public class SystemRun : MonoBehaviour
    {
        #region 資料 : 保存系統需要的資料
        // 欄位 Field : 保存資料
        // 語法 :
        //修飾詞 欄位資料型態 欄位自訂名稱 (指定 預設值 非必要);

        //修飾詞
        // 公開 顯示在面板，允許其他類別存取 public
        // 私人 : 不顯示在面板， 不允許其他類別存取 private (封裝)
        // Seriallize Field 序列化欄位 : 將私人欄位顯示
        // Header 標題 : 可以使用中文
        // Tooltip 提示 : 可以使用中文
        // Range 範圍 : 僅限於數值類型資料 int, float, byte, long
        
        [SerializeField, Header("跑步速度"), Tooltip("這是角色的跑步速度"), Range(0, 100)]
        private float speedRun = 3.5f;
        [SerializeField, Header("跳躍高度"), Tooltip("這是角色的跳躍速度"), Range(0, 3000)]
        private float heightJump = 350;
        private Animator ani;
        private Rigidbody2D rig;
        #endregion

        #region 功能 : 實作該系統的複雜方法

        #endregion

        #region 事件 : 程式入口
        // 開始事件 : 播放遊戲時執行一次
        // 初始化設定，例如 : 英雄聯盟　500 塊 ，生命初始化 3 條....
        private void Start()
        {
            print("12");
        }
        #endregion
    }
}
