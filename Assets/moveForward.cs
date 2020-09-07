using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveForward : MonoBehaviour
{
    private float speed = 20.0f;
    private float destroyBullet = 24.0f;

    public GameObject bullet;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.up * Time.deltaTime * speed);

       if (transform.position.x > destroyBullet)
        {
            Destroy(gameObject);
        }
    }
}
