
using UnityEngine;

namespace YANGSONGJING
{
    /// <summary>
    ///   �R�AAPI (Static API)
    /// </summary>
    public class StaicAPI : MonoBehaviour
    {
        private Vector3 a = new Vector3(1, 1, 1);
        private Vector3 b = new Vector3(22, 22, 22);
        private void Start()
        {
            // ���o�R�A�ݩ� get
            // �y�k :
            // ���O,�R�A�ݩʦW��
            print("�H���� : " + Random.value);
            print("PI : " + Mathf.PI);
            print("�L���j : " + Mathf.Infinity);

            // �]�w�R�A�ݩ� set (Read Only ����ϥ�)
            // �y�k :
            // ���O,�R�A�ݩʦW�� ���w ��;
            Cursor.visible = false;
            Physics2D.gravity = new Vector2(7, 0f);
            Time.timeScale = 1f;

            // �ϥ��R�A��k
            // �y�k :
            // ���O.�R�A��k�W��
            float range = Random.Range(20.5f, 100.5f);
            print("�H���d�� : " + range);
            print("Camera �ƶq:"+Camera.allCamerasCount);
            print("�ثe�����x :" + Application.platform);
            Physics.sleepThreshold = 10;
            print("�ίv�{�ɭ� :" + Physics.sleepThreshold);
            Time.timeScale = 0.5f;
            print("�ɶ��j�p :" + Time.timeScale);
            // ���O.�R�A��k�W��(�����޼�)
            print("9.999 �h���p���I�|�ˤ��J:" + Mathf.Round(9.999f));

            float distance = Vector3.Distance(a,b);
            print("<color=yellow>�Z��: " + distance + "</color>");
            //Application.OpenURL("https://unity.com/");          
        }

        private void Update()
        {
            int rangeint = Random.Range(1, 3);
            print("�H���d�� : " + rangeint);
            print("<color=red>�O�_���U�ť��� :" + Input.GetKeyDown(KeyCode.Space) + "</color>");

        }
    }
}
