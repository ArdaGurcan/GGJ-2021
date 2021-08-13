using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMaker : MonoBehaviour
{
    GameObject selected = null;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(!Camera.main.gameObject.GetComponent<GameManager>().finding && selected == null)
        {
            selected = GameObject.FindGameObjectsWithTag("Character")[Random.Range(0, GameObject.FindGameObjectsWithTag("Character").Length)];
            GameObject sample = Instantiate(selected, new Vector3(-8.8f, 0), Quaternion.identity);
            sample.transform.localScale *= 3;
            selected.GetComponent<CharacterScript>().found = false;
            selected.GetComponent<CharacterScript>().selected = true;
        }
    }
}
