using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Homming : MonoBehaviour
{
    GameObject target; //타겟
    public float speed = 3.0f;

    Vector2 dir;
    Vector2 dirNo;

    void Start()
    {
        //플레이어를 태그로 찾기
        target = GameObject.FindGameObjectWithTag("Player");


        //A - B -> A를 바라보는 벡터
        dir = target.transform.position - transform.position;
        //방향벡터만 구하기 단위벡터 1의 크기로 만든다.
        dirNo = dir.normalized;


    }



    void Update()
    {
        transform.Translate(dirNo * speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Destroy(gameObject);
        }
    }

    private void OnBecameInvisible()
    {
        Destroy(gameObject);

    }
}
