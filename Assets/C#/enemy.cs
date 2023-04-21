using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class enemy : MonoBehaviour
{
    public GameObject explosion;

    GameController gameController;

    void Start()
    {
        gameController = GameObject.Find("GameController").GetComponent<GameController>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position -= new Vector3(0, 2 * Time.deltaTime, 0);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            
        }
        if (collision.CompareTag("bllet") == true)
        {
            collision.gameObject.SetActive(false);
            gameController.AddScore();
        }


        Instantiate(explosion, transform.position, transform.rotation);
        Destroy(gameObject);
        //collision.gameObject.SetActive(false);
        gameController.AddScore();
        Debug.Log("ゲームオーバー");
    }
}
