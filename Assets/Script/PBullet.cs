using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PBullet : MonoBehaviour
{
    public float Speed = 4.0f;
    public int Attack = 10;


    void Update()
    {
        //�̻��� ���ʹ������� �����̱�
        //���� ���� * ���ǵ� * Ÿ��
        transform.Translate(Vector2.up * Speed * Time.deltaTime);
    }

    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Monster"))
        {
            //���� ����
            //Destroy(collision.gameObject);

            //������ ���
            //collision.gameObject.GetComponent<Monster>().ItemDrop();
            
            collision.gameObject.GetComponent<Monster>().Damage(Attack);


            //�̻��� ����
            Destroy(gameObject);
        }
    }
}
