using UnityEngine;

// 계속 회전한다
public class Forever_Rotate : MonoBehaviour
{
    public float angle = 90;

    void FixedUpdate()
    {
        this.transform.Rotate(0, 0, angle / 50);
    }
}