using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    private Rigidbody2D rb;
    public float speed;
    public float launchTime;

    public Vector3 startPosition;

    private void Awake() 
    {
        rb = this.GetComponent<Rigidbody2D>();    
    }

    // Start is called before the first frame update
    void Start()
    {
        startPosition = transform.position;
        StartCoroutine(Launch());
    }

    public void Reset()
    {
        rb.velocity =  Vector2.zero;
        transform.position = startPosition;
        StartCoroutine(Launch());
    }


    IEnumerator  Launch()
    {
        yield return new WaitForSeconds(launchTime);

        int x = Random.Range(0,2) == 0 ? -1 : 1;
        int y = Random.Range(0,2) == 0 ? -1 : 1;
    
        rb.velocity = new Vector2(x, y) * speed;

    }
}
