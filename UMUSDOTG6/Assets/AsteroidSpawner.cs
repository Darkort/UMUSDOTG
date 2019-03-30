using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidSpawner : MonoBehaviour
{
    public float SpawnerSpeed=0.001f;
    public float LineRotationSpeed = 0.1f;
    public Transform AstPrefab;

    public float MaxSpeed= 350;
    public float MinSpeed= 300;
    public float MaxSize= 5;
    public float MinSize= 1;
    public float Rotation= 180;
    


    private void Start()
    {
        StartCoroutine("Spawn");
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        Move();
    }

    public IEnumerator Spawn()
    {
        List<Transform> asteroidList = new List<Transform>();
        

        while (true)
        {

            CreateAsteroid(asteroidList);
            yield return new WaitForSeconds(SpawnerSpeed);

        }
    }


    public void CreateAsteroid(List<Transform> asteroidList)
    {
        float AsteroidSize = Random.Range(MinSize,MaxSize);
        Transform asteroid = Instantiate(AstPrefab, transform.position, new Quaternion(0, 0, 0, 0));
        asteroid.GetComponent<Rigidbody2D>().angularVelocity = Random.Range(-Rotation,Rotation);
        asteroid.localScale = new Vector2(AsteroidSize, AsteroidSize);


        Vector2 angle = new Vector2(transform.right.x + Random.Range(-0.5f, 0.5f), transform.right.y + Random.Range(-0.5f, 0.5f));
        asteroid.GetComponent<Rigidbody2D>().AddForce(angle * Random.Range(MinSpeed, MaxSpeed));

        Vector2 SpawnLine = new Vector2(transform.position.y, -transform.position.x).normalized;

        float line = Random.Range(-12, 12);

        Vector2 PositionOffset = new Vector2(transform.position.x, transform.position.y);

        asteroid.position = PositionOffset + (SpawnLine * line);

        asteroidList.Add(asteroid);



    }

    public void Move()
    {
        transform.RotateAround(Vector3.zero,new Vector3(0,0,1), LineRotationSpeed);
    }



}
