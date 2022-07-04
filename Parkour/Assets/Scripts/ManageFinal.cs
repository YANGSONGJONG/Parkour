using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace YANGSONGJING
{
    /// <summary>
    /// 管理結束畫面
    /// 過關與失敗
    /// </summary> 
    public class ManageFinal : MonoBehaviour
    {
        [SerializeField, Header("畫布")]
        private CanvasGroup groupFinal;
        [SerializeField, Header("遊戲結束標題")]
        private TextMeshProUGUI textFinal;

        private void Start()
        {
            InvokeRepeating("FadeIn", 0, 0.2f);
        }
        /// <summary>
        /// 遊戲結束標題的文字內容
        /// </summary>
        public string stringTitle;

        /// <summary>
        /// 淡入
        /// </summary>
        private void FadeIn()
        {
            //透明度遞增
            groupFinal.alpha += 0.1f;

            // 如果透明度 >= 1 就啟動互動與遮擋射線
            if (groupFinal.alpha >= 1)
            {
                groupFinal.interactable = true;
                groupFinal.blocksRaycasts = true;
            }
        }
        // 按鈕與程式溝通方式
        // 1. 定義公開方法
        // 2. Button On Click 設定此腳本的公開方法
        public void Quit()
        {
            print("離開遊戲");
            // 只在發布執行檔 電腦與手機裝置上有作用
            Application.Quit();
        }
        /// <summary>
        /// 重新遊戲
        /// </summary>
        public void Replay()
        {
            SceneManager.LoadScene("SampleScene");
        }
        

    }
}

