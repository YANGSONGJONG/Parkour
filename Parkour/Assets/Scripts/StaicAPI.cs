
using UnityEngine;

namespace YANGSONGJING
{
    /// <summary>
    ///   靜態API (Static API)
    /// </summary>
    public class StaicAPI : MonoBehaviour
    {
        private Vector3 a = new Vector3(1, 1, 1);
        private Vector3 b = new Vector3(22, 22, 22);
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
            // 類別.靜態方法名稱
            float range = Random.Range(20.5f, 100.5f);
            print("隨機範圍 : " + range);
            print("Camera 數量:"+Camera.allCamerasCount);
            print("目前的平台 :" + Application.platform);
            Physics.sleepThreshold = 10;
            print("睡眠臨界值 :" + Physics.sleepThreshold);
            Time.timeScale = 0.5f;
            print("時間大小 :" + Time.timeScale);
            // 類別.靜態方法名稱(對應引數)
            print("9.999 去掉小數點四捨五入:" + Mathf.Round(9.999f));

            float distance = Vector3.Distance(a,b);
            print("<color=yellow>距離: " + distance + "</color>");
            //Application.OpenURL("https://unity.com/");          
        }

        private void Update()
        {
            int rangeint = Random.Range(1, 3);
            print("隨機範圍 : " + rangeint);
            print("<color=red>是否按下空白鍵 :" + Input.GetKeyDown(KeyCode.Space) + "</color>");

        }
    }
}
