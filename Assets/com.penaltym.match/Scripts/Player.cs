using UnityEngine;

public class Player : MonoBehaviour
{
    Camera _camera;
    Vector2 target;

    const float speed = 6.5f;

    private void Awake()
    {
        _camera = Camera.main;
    }

    private void Update()
    {
        target = new Vector2(_camera.ScreenToWorldPoint(Input.mousePosition).x, transform.position.y);
        transform.position = Vector2.MoveTowards(transform.position, target, speed * Time.deltaTime);
    }
}
