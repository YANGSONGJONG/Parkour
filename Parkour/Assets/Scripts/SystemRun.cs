
using UnityEngine;

namespace YANGSONGJING
{
    /// <summary>
    /// �]�B�t��
    /// </summary>
    
    public class SystemRun : MonoBehaviour
    {
        #region ��� : �O�s�t�λݭn�����
        // ��� Field : �O�s���
        // �y�k :
        //�׹��� ����ƫ��A ���ۭq�W�� (���w �w�]�� �D���n);

        //�׹���
        // ���} ��ܦb���O�A���\��L���O�s�� public
        // �p�H : ����ܦb���O�A �����\��L���O�s�� private (�ʸ�)
        // Seriallize Field �ǦC����� : �N�p�H������
        // Header ���D : �i�H�ϥΤ���
        // Tooltip ���� : �i�H�ϥΤ���
        // Range �d�� : �ȭ���ƭ�������� int, float, byte, long

        [SerializeField, Header("�]�B�t��"), Tooltip("�o�O���⪺�]�B�t��"), Range(0, 100)]
        private float speedRun = 3.5f;
        [SerializeField, Header("���D����"), Tooltip("�o�O���⪺���D�t��"), Range(0, 3000)]
        private float heightJump = 350;
        private Animator ani;
        private Rigidbody2D rig;
        #endregion

        #region �\�� : ��@�Өt�Ϊ�������k

        #endregion

        #region �ƥ� : �{���J�f
        // �}�l�ƥ� : ����C���ɰ���@��
        // ��l�Ƴ]�w�A�Ҧp : �^���p���@500 �� �A�ͩR��l�� 3 ��....
        // ����ƥ� : �}�l�ƥ�e����@���A���o���󵥵�
        private void Awake()
        {
            // ani ���w �Ԫ��t���W�� Animator
            ani = GetComponent<Animator>();
            rig = GetComponent<Rigidbody2D>();
        }
        private void Start()
        {
           // print("12");
        }
        // ��s�ƥ� : �C���������Q�� 60FPS Frame per second
        /// <summary>
        /// �]�B�\��
        /// </summary>
        private void Run()
        {
            print("�]�B��~");
            rig.velocity = new Vector2(speedRun, rig.velocity.y);
        }
        private void Update()
        {
            // print("<color=yellow>��s�ƥ���椤~</color>");
            Run();
        }

        // ������Q�Ŀ�ɰ���@��
        private void OnEnable()
        {
            
        }

        //������Q�����ɰ���@��
        private void OnDisable()
        {
            rig.velocity = Vector3.zero;
        }
        // ��k Method
        // �y�k
        // �׹��� �Ǧ^��ƫ��A ��k�W��(�Ѽ�) { �{�� }

        #endregion
    }
}
