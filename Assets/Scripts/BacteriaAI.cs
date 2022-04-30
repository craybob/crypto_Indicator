using UnityEngine;

public class BacteriaAI : MonoBehaviour
{
    [SerializeField]
    private Rigidbody rigidbody;

    [SerializeField]
    private float speed;
    [SerializeField]
    private float minSpeed = 0.1f;
    [SerializeField]
    private float maxSpeed = 1f;

    [SerializeField]
    private float speedRoot;
    private float currentSpeedRoot = 0;

    [SerializeField]
    private Vector2 direction;

    [SerializeField]
    private float changeTime = 1;

    private float timer = 0;

    [SerializeField]
    private bool isAmeba = false;


    private void Update()
    {
        if(timer < changeTime)
        {
            timer += Time.deltaTime;
        }
        else
        {
            timer = 0;
            speed = Random.Range(minSpeed, maxSpeed);
            direction = new Vector2(Random.Range(-1.0f, 1.0f), Random.Range(-1.0f, 1.0f));
            currentSpeedRoot = Random.Range(0, speedRoot);
        }
        if(isAmeba)
        {
            transform.Rotate(currentSpeedRoot * Time.deltaTime, currentSpeedRoot * Time.deltaTime, currentSpeedRoot * Time.deltaTime);
        }
    }

    private void FixedUpdate()
    {
        rigidbody.velocity = new Vector3(direction.x * Time.deltaTime * speed, 0, direction.y * Time.deltaTime * speed);
    }
}
