
using UnityEngine;
namespace Mike
{
    /// <summary>
    /// ���D�t��
    /// </summary>
    public class systemJump : MonoBehaviour
    {
        #region ���
        [SerializeField, Header("�]�B�t��"), Tooltip("�o�O���⪺�]�B�t��"), Range(0, 100)]
        private float speedRun = 3.5f;
        [SerializeField, Header("���D����"), Tooltip("�o�O���⪺���D�t��"), Range(0, 3000)]
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

        #region �\��
        private void JumpKey()
        {
            // �p�G ���a ���U ������ �N���W ���D
            // if
            // switch
            // if �P�_���y�k : if (���L��) {���L�� ��true ����{��}
            if (Input.GetKeyDown(KeyCode.Space))
            {
                print("���D~");
                clickjump = true;
            }
        }
        
        //Input API ��ĳ�b Update �I�s
        // �@��� 60 ��
        private void Update()
        {
            JumpKey();
        }
        // �@��T�w 50 ��
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



