using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class player : MonoBehaviour
{
    public Transform point;
    public GameObject bulletprefab;
    private void Start()
    {

    }
    void Update()
    {
        shot();
        move();
        
    }
    void shot()
    {
        if (Input.GetMouseButtonDown(0))
            
        {
            Instantiate(bulletprefab, point.position, transform.rotation);
        }
    }
    void move()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");

        transform.position += new Vector3(x, y, 0) *Time.deltaTime * 15f;
    }
    
}
