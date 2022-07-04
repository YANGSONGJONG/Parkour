
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
        // 喚醒事件 : 開始事件前執行一次，取得元件等等
        private void Awake()
        {
            // ani 指定 忍者龜身上的 Animator
            ani = GetComponent<Animator>();
            rig = GetComponent<Rigidbody2D>();
        }
        private void Start()
        {
           // print("12");
        }
        // 更新事件 : 每秒執行約六十次 60FPS Frame per second
        /// <summary>
        /// 跑步功能
        /// </summary>
        private void Run()
        {
            print("跑步中~");
            rig.velocity = new Vector2(speedRun, rig.velocity.y);
        }
        private void Update()
        {
            // print("<color=yellow>更新事件執行中~</color>");
            Run();
        }

        // 此元件被勾選時執行一次
        private void OnEnable()
        {
            
        }

        //此元件被取消時執行一次
        private void OnDisable()
        {
            rig.velocity = Vector3.zero;
        }
        // 方法 Method
        // 語法
        // 修飾詞 傳回資料型態 方法名稱(參數) { 程式 }

        #endregion
    }
}
