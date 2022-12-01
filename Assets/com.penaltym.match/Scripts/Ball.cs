using UnityEngine;

public class Ball : MonoBehaviour
{
    private static Vector2 Velocity { get; set; }
    private static Rigidbody2D Rigidbody2D { get; set; }

    private void Awake()
    {
        Rigidbody2D = GetComponent<Rigidbody2D>();
    }

    public static void Sleep()
    {
        Velocity = Rigidbody2D.velocity;
        Rigidbody2D.Sleep();
    }

    public static void WakeUp()
    {
        Rigidbody2D.WakeUp();
        Rigidbody2D.velocity = Velocity;
    }
}
