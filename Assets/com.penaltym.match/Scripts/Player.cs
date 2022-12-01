using System;
using UnityEngine;

public class Player : MonoBehaviour
{
    Camera _camera;
    Vector2 target;

    const float speed = 6.5f;

    public static Action OnCollided { get; set; } = delegate { };

    private void Awake()
    {
        _camera = Camera.main;
    }

    private void Update()
    {
        target = new Vector2(_camera.ScreenToWorldPoint(Input.mousePosition).x, transform.position.y);
        transform.position = Vector2.MoveTowards(transform.position, target, speed * Time.deltaTime);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        collision.rigidbody.AddForce(Vector2.up * 6, ForceMode2D.Impulse);
        OnCollided?.Invoke();
    }
}
