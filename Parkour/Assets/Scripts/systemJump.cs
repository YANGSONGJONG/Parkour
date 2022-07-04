
using UnityEngine;
namespace YANGSONGJING
{
    /// <summary>
    /// ���D�t��
    /// </summary>
    public class systemJump : MonoBehaviour
    {
        #region ���
        
        [SerializeField, Header("���D����"), Range(0, 3000)]
        private float heightJump = 350;
        [SerializeField, Header("�ˬd�a�O�ؤo")]
        private Vector3 v3checkGroundSize = Vector3.one;
        [SerializeField, Header("�ˬd�a�O�첾")]
        private Vector3 v3checkGrounfOffset;
        [SerializeField, Header("�ˬd�a�O�C��")]
        private Color colorCheckGround = new Color(1, 0, 0.2f, 0.5f);
        [SerializeField, Header("�ˬd�a�O�ϼh")]
        private LayerMask LayerCheckGround;
        private Animator ani;
        private Rigidbody2D rig;
        private bool clickjump;
        private bool isGround;
        #endregion

        #region �ƥ�
        //ø�s�ϥ�
        //�b�s�边��ø�s���U�Ϊ��u�� �Ϊ��ιϤ�
        private void OnDrawGizmos()
        {
            // 1. �M�w�C��
            Gizmos.color = colorCheckGround;
            // 2.ø�s�ϥ�
            Gizmos.DrawCube(transform.position + v3checkGrounfOffset, v3checkGroundSize);
        }
        #endregion
        private void Awake()
        {

            ani = GetComponent<Animator>();
            rig = GetComponent<Rigidbody2D>();
        }
        

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
            else if (Input.GetKeyUp(KeyCode.Space))
            {
                clickjump = false;
            }
        }
        
        //Input API ��ĳ�b Update �I�s
        // �@��� 60 ��
        private void Update()
        {
            JumpKey();
            CheckGround();
        }
        // �@��T�w 50 ��
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
       /// �ˬd�O�_�I��a�O
       /// </summary>
       private void CheckGround()
        {
            // 2D �I���� = 2D ���z�A�л\�����ϰ�(�����I�A�ؤo�A����);
            // transform.position : ��e���󪺮y��
            Collider2D hit = Physics2D.OverlapBox(transform.position + v3checkGrounfOffset, v3checkGroundSize, 0, LayerCheckGround);
            // print("�I�쪺���� : " + hit.name);
            isGround = hit;
        }
        #endregion
    }






}



