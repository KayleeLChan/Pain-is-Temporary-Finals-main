using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ItemsCollected : MonoBehaviour
{

    public float items;

    // Start is called before the first frame update
    void Start()
    {
        items = 0;
    }

    private void Update()
    {
        if(items == 4)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }

    //Item counter increases with each item entering cave
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Item")
        {
            items += 1;
        }
    }

    //Item counter decreases with each item exiting cave
    private void OnTriggerExit(Collider other)
    {
        if(other.gameObject.tag == "Item")
        {
            items -= 1;
        }
    }
}
