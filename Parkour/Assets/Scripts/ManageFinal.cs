using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace YANGSONGJING
{
    /// <summary>
    /// �޲z�����e��
    /// �L���P����
    /// </summary> 
    public class ManageFinal : MonoBehaviour
    {
        [SerializeField, Header("�e��")]
        private CanvasGroup groupFinal;
        [SerializeField, Header("�C���������D")]
        private TextMeshProUGUI textFinal;

        private void Start()
        {
            InvokeRepeating("FadeIn", 0, 0.2f);
        }
        /// <summary>
        /// �C���������D����r���e
        /// </summary>
        public string stringTitle;

        /// <summary>
        /// �H�J
        /// </summary>
        private void FadeIn()
        {
            //�z���׻��W
            groupFinal.alpha += 0.1f;

            // �p�G�z���� >= 1 �N�Ұʤ��ʻP�B�׮g�u
            if (groupFinal.alpha >= 1)
            {
                groupFinal.interactable = true;
                groupFinal.blocksRaycasts = true;
            }
        }
        // ���s�P�{�����q�覡
        // 1. �w�q���}��k
        // 2. Button On Click �]�w���}�������}��k
        public void Quit()
        {
            print("���}�C��");
            // �u�b�o�������� �q���P����˸m�W���@��
            Application.Quit();
        }
        /// <summary>
        /// ���s�C��
        /// </summary>
        public void Replay()
        {
            SceneManager.LoadScene("SampleScene");
        }
        

    }
}

