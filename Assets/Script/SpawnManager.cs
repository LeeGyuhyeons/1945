using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public float ss = -2;
    public float es = 2;
    public float StartTime = 1;
    public float SpawnStop = 10;

    bool swi = true;
    bool swi2 = true;

    [SerializeField]
    private GameObject enemy;
    [SerializeField]
    private GameObject enemy2;

    void Start()
    {
        StartCoroutine("RandomSpawn");
    }
    IEnumerator RandomSpawn()
    {

        while (swi)
        {
            yield return new WaitForSeconds(StartTime);

            float x = Random.Range(ss, es);
            Vector2 r = new Vector2(x, transform.position.y);

            Instantiate(enemy, r, Quaternion.identity);
        }
    }

    IEnumerator RandomSpawn2()
    {

        while (swi2)
        {
            yield return new WaitForSeconds(StartTime + 2);

            float x = Random.Range(ss, es);
            Vector2 r = new Vector2(x, transform.position.y);

            Instantiate(enemy2, r, Quaternion.identity);
        }
    }

    private void Stop()
    {
        swi = false;
        StopCoroutine("RandomSpawn");

        StartCoroutine("RandomSpawn2");
        Invoke("Stop2", SpawnStop + 20);
    }
    private void Stop2()
    {
        swi2 = false;
        StopCoroutine("RandomSpawn2");

    }
    //보스몬스터
    void Update()
    {

    }
}
