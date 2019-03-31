using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid : MonoBehaviour
{
    public List<Sprite> sprites= new List<Sprite>();
    
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<SpriteRenderer>().sprite = sprites[Random.Range(0, sprites.Count)];
        gameObject.AddComponent<PolygonCollider2D>().density=0.02f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
