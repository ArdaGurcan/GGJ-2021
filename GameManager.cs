using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    int numberOfCharacters = 40;
    // Start is called before the first frame update
    public Sprite[] heads;
    public Sprite[] torsos;
    public Sprite[] legs;
    public bool finding = true;

    public GameObject characterPrefab;

    void Start()
    {
        //for (int i = 0; i < numberOfCharacters; i++)
        //{
        //    GameObject newCharacter = Instantiate(characterPrefab, new Vector3(Random.Range(-4.5f, 4.5f), Random.Range(-2.5f, 4.5f), 0), Quaternion.identity);
        //    Transform head = newCharacter.transform.GetChild(0);
        //    Transform torso = newCharacter.transform.GetChild(1);
        //    Transform leg = newCharacter.transform.GetChild(2);

        //    head.GetComponent<SpriteRenderer>().sprite = heads[Random.Range(0, heads.Length)];
        //    torso.GetComponent<SpriteRenderer>().sprite = torsos[Random.Range(0, torsos.Length)];
        //    leg.GetComponent<SpriteRenderer>().sprite = legs[Random.Range(0, legs.Length)];

        //    //torso.GetComponent<Renderer>().material.SetTexture("Texture", torso.GetComponent<SpriteRenderer>().sprite.texture);
        //    //leg.GetComponent<Renderer>().material.SetTexture("Texture", leg.GetComponent<SpriteRenderer>().sprite.texture);


        //    //head.GetComponent<SpriteRenderer>().sortingOrder = Mathf.RoundToInt(newCharacter.transform.position.y * -100);
        //    //torso.GetComponent<SpriteRenderer>().sortingOrder = Mathf.RoundToInt(newCharacter.transform.position.y * -100);
        //    //leg.GetComponent<SpriteRenderer>().sortingOrder = Mathf.RoundToInt(newCharacter.transform.position.y * -100);

        //    torso.GetComponent<Renderer>().material.SetFloat("_HueDiff", Random.Range(-0.5f, 0.5f));
        //    leg.GetComponent<Renderer>().material.SetFloat("_HueDiff", Random.Range(-0.5f, 0.5f));
        //}

    }

    // Update is called once per frame
    void Update()
    {
        if (finding)
        {
            finding = true;
            while(GameObject.FindGameObjectsWithTag("Character").Length < numberOfCharacters)
            {
                GameObject newCharacter = Instantiate(characterPrefab, new Vector3(Random.Range(-4f, 4f), Random.Range(-2.5f, 4.5f), 0), Quaternion.identity);
                Transform head = newCharacter.transform.GetChild(0);
                Transform torso = newCharacter.transform.GetChild(1);
                Transform leg = newCharacter.transform.GetChild(2);

                head.GetComponent<SpriteRenderer>().sprite = heads[Random.Range(0, heads.Length)];
                torso.GetComponent<SpriteRenderer>().sprite = torsos[Random.Range(0, torsos.Length)];
                leg.GetComponent<SpriteRenderer>().sprite = legs[Random.Range(0, legs.Length)];

                //torso.GetComponent<Renderer>().material.SetTexture("Texture", torso.GetComponent<SpriteRenderer>().sprite.texture);
                //leg.GetComponent<Renderer>().material.SetTexture("Texture", leg.GetComponent<SpriteRenderer>().sprite.texture);


                head.GetComponent<SpriteRenderer>().sortingOrder = Mathf.RoundToInt(newCharacter.transform.position.y * -100);
                torso.GetComponent<SpriteRenderer>().sortingOrder = Mathf.RoundToInt(newCharacter.transform.position.y * -100);
                leg.GetComponent<SpriteRenderer>().sortingOrder = Mathf.RoundToInt(newCharacter.transform.position.y * -100);
                float hue = Random.Range(-0.5f, 0.5f);

                torso.GetComponent<Renderer>().material.SetVector("_HSVAAdjust", new Vector4(hue, -0.2f, 0f, 0));
                leg.GetComponent<Renderer>().material.SetVector("_HSVAAdjust", new Vector4(hue, -0.2f, 0f, 0));
            }
            finding = false;
        }

        
    }
}
