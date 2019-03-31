using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid : MonoBehaviour
{
    public List<Sprite> sprites= new List<Sprite>();
    public float area;


 
    // Start is called before the first frame update
    void Awake()
    {
        GetComponent<SpriteRenderer>().sprite = sprites[Random.Range(0, sprites.Count)];
        gameObject.AddComponent<PolygonCollider2D>();
        area = calculateMassScale();

    }

    public float calculateMassScale() {

        float radius = GetComponent<PolygonCollider2D>().bounds.extents.x;
        return radius * radius * Mathf.PI;
    }

}
