using UnityEngine;

public class SeaUrchinController : MonoBehaviour
{
    public float speed = -5f;
    public float limitSec = 3f;

    void Start()
    {
        Destroy(this.gameObject, limitSec);
    }

    void Update()
    {
        transform.Translate(0, speed * Time.deltaTime, 0);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            Debug.LogError("게임 오버!");
            Time.timeScale = 0f;
        }
    }
}