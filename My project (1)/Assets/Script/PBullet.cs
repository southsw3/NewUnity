using UnityEngine;

public class PBullet : MonoBehaviour
{
    public float Speed = 4.0f;
    //���ݷ�
    public int Attack = 10;
    //����Ʈ
    public GameObject effect;

    void Update()
    {
        //�̻��� ���ʹ������� �����̱�
        //���� ���� * ���ǵ� * Ÿ��
        transform.Translate(Vector2.up * Speed * Time.deltaTime);
    }


    //ȭ������� �������
    private void OnBecameInvisible()
    {
        //�ڱ� �ڽ� �����
        Destroy(gameObject);
    }


    //�浹ó��
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Monster"))
        {




            //����Ʈ����
            GameObject go = Instantiate(effect, transform.position, Quaternion.identity);
            //1�ʵڿ� �����
            Destroy(go, 1);

            //���ͻ���
            collision.gameObject.GetComponent<Monster>().Damage(Attack);
            

            //�̻��� ����
            Destroy(gameObject);

        }


        if (collision.CompareTag("Boss"))
        {

            //����Ʈ����
            GameObject go = Instantiate(effect, transform.position, Quaternion.identity);
            //1�ʵڿ� �����
            Destroy(go, 1);

            //�̻��� ����
            Destroy(gameObject);

        }
    }



}