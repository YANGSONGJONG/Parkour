
using UnityEngine;

namespace YANGSONGJING
{
    /// <summary>
    ///   �R�AAPI (Static API)
    /// </summary>
    public class StaicAPI : MonoBehaviour
    {
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
            // ���O.�R�A��k�W��(�����޼�)
            float range = Random.Range(20.5f, 100.5f);
            print("�H���d�� : " + range);
        
        }
        
        private void Update()
        {
            int rangeint = Random.Range(1, 3);
            print("�H���d�� : " + rangeint);
        }
        

    }
}
