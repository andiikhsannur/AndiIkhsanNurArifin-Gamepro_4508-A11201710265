using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerControl : MonoBehaviour
{
    public Vector2 jumpForce = new Vector2(0, 100);
    int score = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float touchclicked = Input.GetAxis ("Fire1");
        if (touchclicked == 1f)
        {
            GetComponent<Rigidbody2D> ().velocity = Vector2.zero;
            GetComponent<Rigidbody2D> ().AddForce(jumpForce);
        }
        Vector2 screenPosition = Camera.main.WorldToScreenPoint (transform.position);
        if (screenPosition.y > Screen.height || screenPosition.y < 0)
        {
            Die();
        }
    }

    // Jika player melebihi batasan tinggi atau jatuh akan mati
    void Die()
    {
        Debug.Log ("game over");
        SceneManager.LoadScene ("Menu");
    }

    //
    void Score()
    {
        score++;
    }

    //
    void OnCollisionEnter2D (Collision2D coll)
    {
        if (coll.gameObject.tag == "enemyTag") //jika object player menabrak object dengan tag enemyTag maka akan mati
        {
            Die ();
        }
        if (coll.gameObject.tag == "koinTag") //jika obejct player menabrak object dengan tag koinTag maka score + 1
        {
            Score();
        } 
    }

}
