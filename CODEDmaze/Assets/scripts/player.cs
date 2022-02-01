using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class player : MonoBehaviour
{
    // player movment

    void OnMouseDrag(){
        Vector3 mousePos = new Vector3(Input.mousePosition.x, Input.mousePosition.y, transform.position.z);
        Vector3 playerPos = Camera.main.ScreenToWorldPoint(mousePos);
        transform.position = playerPos;
    }
    

    // game over

    void OnCollisionEnter(Collision other){
        if (other.gameObject.tag == "Finish"){
            SceneManager.LoadScene("lvl2");
        }
        else{
        Destroy(this.gameObject);
        SceneManager.LoadScene("JumpScare");
        }
    }

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
