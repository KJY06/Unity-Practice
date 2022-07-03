using UnityEngine;

public class ArrowPoint : MonoBehaviour
{
    private float angle;
    private Vector2 target, mouse;
    public GameObject bulletprefab;
    private float time;
    void Start()
    {
        target = transform.position;
    }
    void Update()
    {
        shoot();
        Follow();
    }
    void shoot()
    {
        time += Time.deltaTime;
        if (Input.GetKeyDown(KeyCode.Mouse0) || Input.GetKeyDown(KeyCode.S))
        {
            
            if (time >= 0.3f)
            {
                time = 0;
                Instantiate(bulletprefab, transform.position, transform.rotation);
            }
        }
    }
    void Follow()
    {
        mouse = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        angle = Mathf.Atan2(mouse.y - target.y, mouse.x - target.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.AngleAxis(angle - 90, Vector3.forward);
    }
}
