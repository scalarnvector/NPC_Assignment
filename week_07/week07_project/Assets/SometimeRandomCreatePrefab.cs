using UnityEngine;

public class SometimeRandomCreatePrefab : MonoBehaviour
{
    public GameObject newPrefab;
    public float intervalSec = 0.3f;

    private float timer = 0f;

    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= intervalSec)
        {
            CreateObject();
            timer = 0f;
        }
    }

    void CreateObject()
    {
        Vector3 spawnPos = transform.position;
        spawnPos.x += Random.Range(-6f, 6f);

        Instantiate(newPrefab, spawnPos, Quaternion.identity);
    }
}