using UnityEngine;

public class OnKeyPressMove : MonoBehaviour
{
    public float speed = 8f;

    void Update()
    {
        float xInput = Input.GetAxisRaw("Horizontal");
        transform.Translate(xInput * speed * Time.deltaTime, 0, 0);
    }
}