
using UnityEngine;
namespace Mike
{
    /// <summary>
    /// 跳躍系統
    /// </summary>
    public class systemJump : MonoBehaviour
    {
        #region 資料
        [SerializeField, Header("跑步速度"), Tooltip("這是角色的跑步速度"), Range(0, 100)]
        private float speedRun = 3.5f;
        [SerializeField, Header("跳躍高度"), Tooltip("這是角色的跳躍速度"), Range(0, 3000)]
        private float heightJump = 350;
        private Animator ani;
        private Rigidbody2D rig;
        private bool clickjump;

        private void Awake()
        {

            ani = GetComponent<Animator>();
            rig = GetComponent<Rigidbody2D>();
        }
        #endregion

        #region 功能
        private void JumpKey()
        {
            // 如果 玩家 按下 控癌鍵 就往上 跳躍
            // if
            // switch
            // if 判斷式語法 : if (布林值) {布林值 為true 執行程式}
            if (Input.GetKeyDown(KeyCode.Space))
            {
                print("跳躍~");
                clickjump = true;
            }
        }
        
        //Input API 建議在 Update 呼叫
        // 一秒約 60 次
        private void Update()
        {
            JumpKey();
        }
        // 一秒固定 50 次
        private void FixedUpdate()
        {
            JumpForce();
        }
        private void JumpForce()
        {
            if(clickjump)
            {
                rig.AddForce(new Vector2(0, heightJump));
                clickjump = false;
            }
        }
        #endregion
    }






}



