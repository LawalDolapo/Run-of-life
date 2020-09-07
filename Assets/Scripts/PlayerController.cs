using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRb;
    private float jumpForce = 10.0f;
    public GameObject bullet;
    public float gravityModifier;
    public bool isOnground = true;

    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        Physics.gravity *= gravityModifier;
        
    }

    // Update is called once per frame
    void Update()
    {
        ShootProjectile();
        MovePlayer();
    }

    private void OnCollisionEnter(Collision collision)
    {
        isOnground = true;
    }

    //move player based on key input and prevent player from jumping twice

    void ShootProjectile()
    {
        if (Input.GetKeyDown(KeyCode.X))
        {
            Debug.Log("x was pressed");
            Instantiate(bullet, transform.position, bullet.transform.rotation);
        }
    }

    void MovePlayer()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isOnground)
            {
                playerRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
                isOnground = false;
            }
       
    }


}
