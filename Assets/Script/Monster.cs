using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour
{
    public int HP = 100;


    public float speed = 3f;
    public float delay = 1f;
    public Transform ms1;
    public Transform ms2;
    public GameObject mbullet;
    public GameObject powerItem;
    void Start()
    {
        Invoke("CreateBullet", delay);
    }

    void CreateBullet()
    {
        Instantiate(mbullet, ms1.position, Quaternion.identity);
        Instantiate(mbullet, ms2.position, Quaternion.identity);
        Invoke("CreateBullet", delay);

    }
    void Update()
    {
        transform.Translate(Vector2.down * speed * Time.deltaTime);
    }

    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }

    public void Damage(int attack)
    {
        HP -= attack;

        if(HP <= 0)
        {
            ItemDrop();
            Destroy(gameObject) ;
        }
    }



    public void ItemDrop()
    {
        int randomDrop = Random.Range(0, 100);
        if (randomDrop < 20)
        {

            Instantiate(powerItem, transform.position, Quaternion.identity);
        }

    }
}
