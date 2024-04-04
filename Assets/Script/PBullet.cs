using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PBullet : MonoBehaviour
{
    public float Speed = 4.0f;
    public int Attack = 10;


    void Update()
    {
        //미사일 위쪽방향으로 움직이기
        //위의 방향 * 스피드 * 타임
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
            //몬스터 삭제
            //Destroy(collision.gameObject);

            //아이템 드롭
            //collision.gameObject.GetComponent<Monster>().ItemDrop();
            
            collision.gameObject.GetComponent<Monster>().Damage(Attack);


            //미사일 삭제
            Destroy(gameObject);
        }
    }
}
