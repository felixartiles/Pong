using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raqueta : MonoBehaviour
{
    //Velocidad
    public float velocidad= 30.0f;

    public string eje;
    public string eje2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Es llamado una vez cada fixed frame
    void FixedUpdate () {
    //Capto el valor del eje vertical de la raqueta
    float v = Input.GetAxisRaw(eje);
    //Capto el valor del eje horizontal de la raqueta
    float h = Input.GetAxisRaw(eje2);
    //Modifico la velocidad de la raqueta
    GetComponent<Rigidbody2D>().velocity = new Vector2(0, v * velocidad);
    }

}
