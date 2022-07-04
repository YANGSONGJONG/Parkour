
using UnityEngine;
namespace YANGSONGJING
{
    /// <summary>
    /// 跳躍系統
    /// </summary>
    public class systemJump : MonoBehaviour
    {
        #region 資料
        
        [SerializeField, Header("跳躍高度"), Range(0, 3000)]
        private float heightJump = 350;
        [SerializeField, Header("檢查地板尺寸")]
        private Vector3 v3checkGroundSize = Vector3.one;
        [SerializeField, Header("檢查地板位移")]
        private Vector3 v3checkGrounfOffset;
        [SerializeField, Header("檢查地板顏色")]
        private Color colorCheckGround = new Color(1, 0, 0.2f, 0.5f);
        [SerializeField, Header("檢查地板圖層")]
        private LayerMask LayerCheckGround;
        private Animator ani;
        private Rigidbody2D rig;
        private bool clickjump;
        private bool isGround;
        #endregion

        #region 事件
        //繪製圖示
        //在編輯器內繪製輔助用的線條 形狀或圖片
        private void OnDrawGizmos()
        {
            // 1. 決定顏色
            Gizmos.color = colorCheckGround;
            // 2.繪製圖示
            Gizmos.DrawCube(transform.position + v3checkGrounfOffset, v3checkGroundSize);
        }
        #endregion
        private void Awake()
        {

            ani = GetComponent<Animator>();
            rig = GetComponent<Rigidbody2D>();
        }
        

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
            else if (Input.GetKeyUp(KeyCode.Space))
            {
                clickjump = false;
            }
        }
        
        //Input API 建議在 Update 呼叫
        // 一秒約 60 次
        private void Update()
        {
            JumpKey();
            CheckGround();
        }
        // 一秒固定 50 次
        private void FixedUpdate()
        {
            JumpForce();
        }
        private void JumpForce()
        {
            if(clickjump && isGround)
            {
                rig.AddForce(new Vector2(0, heightJump));
                clickjump = false;
            }
        }
       /// <summary>
       /// 檢查是否碰到地板
       /// </summary>
       private void CheckGround()
        {
            // 2D 碰撞器 = 2D 物理，覆蓋盒型區域(中心點，尺寸，角度);
            // transform.position : 當前物件的座標
            Collider2D hit = Physics2D.OverlapBox(transform.position + v3checkGrounfOffset, v3checkGroundSize, 0, LayerCheckGround);
            // print("碰到的物件 : " + hit.name);
            isGround = hit;
        }
        #endregion
    }






}



