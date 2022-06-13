
using UnityEngine;

namespace YANGSONGJING
{
    /// <summary>
    ///   靜態API (Static API)
    /// </summary>
    public class StaicAPI : MonoBehaviour
    {
        private void Start()
        {
            // 取得靜態屬性 get
            // 語法 :
            // 類別,靜態屬性名稱
            print("隨機值 : " + Random.value);
            print("PI : " + Mathf.PI);
            print("無限大 : " + Mathf.Infinity);

            // 設定靜態屬性 set (Read Only 不能使用)
            // 語法 :
            // 類別,靜態屬性名稱 指定 值;
            Cursor.visible = false;
            Physics2D.gravity = new Vector2(7, 0f);
            Time.timeScale = 1f;

            // 使用靜態方法
            // 語法 :
            // 類別.靜態方法名稱(對應引數)
            float range = Random.Range(20.5f, 100.5f);
            print("隨機範圍 : " + range);
        
        }
        
        private void Update()
        {
            int rangeint = Random.Range(1, 3);
            print("隨機範圍 : " + rangeint);
        }
        

    }
}
