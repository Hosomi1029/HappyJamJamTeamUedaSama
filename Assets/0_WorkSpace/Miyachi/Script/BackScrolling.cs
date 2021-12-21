using UnityEngine;

public class BackScrolling : MonoBehaviour
{
    [SerializeField] private float scrollSpeed; //�w�i���X�N���[��������X�s�[�h
    [SerializeField] private float startLine;//�w�i�̃X�N���[�����J�n����ʒu
    [SerializeField] private float deadLine; //�w�i�̃X�N���[�����I������ʒu
    void Start()
    {
        
    }
    private void FixedUpdate()
    {
        transform.Translate(scrollSpeed * Time.deltaTime, 0, 0); //x���W��scrollSpeed��������

        if (transform.position.x < deadLine) //�����w�i��x���W���deadLine���傫���Ȃ�����
        {
            transform.position = new Vector3(startLine, 0, 0);//�w�i��startLine�܂Ŗ߂�
        }

    }
 
}
