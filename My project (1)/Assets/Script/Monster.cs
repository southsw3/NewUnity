using UnityEngine;

public class Monster : MonoBehaviour
{

    public int HP = 100;
    public float Speed = 3;
    public float Delay = 1f;
    public Transform ms1;
    public Transform ms2;
    public GameObject bullet;
    //������ ��������
    public GameObject Item = null;


    void Start()
    {
        //�ѹ��Լ�ȣ��
        Invoke("CreateBullet", Delay);
    }

    void CreateBullet()
    {
        Instantiate(bullet, ms1.position, Quaternion.identity);
        Instantiate(bullet, ms2.position, Quaternion.identity);

        //���ȣ��
        Invoke("CreateBullet", Delay);
    }








    void Update()
    {
        //�Ʒ� �������� ��������
        transform.Translate(Vector3.down * Speed * Time.deltaTime);
    }

    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }



    //�̻��Ͽ� ���� ������ �Դ� �Լ�
    public void Damage(int attack)
    {
        HP -= attack;

        if (HP <= 0)
        {
            ItemDrop();
            Destroy(gameObject);
        }


    }



    public void ItemDrop()
    {
        //������ ����
        Instantiate(Item, transform.position, Quaternion.identity);
    }








}