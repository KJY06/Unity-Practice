using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public float speed = 5f;
    float h, v;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0f,Input.GetAxis("Mouse X") * speed, 0f, 0);

        //if (Input.GetButton("Horizontal"))
        //{
        //    transform.Translate(Vector3.right * speed * Time.deltaTime);
        //}
        //else if (Input.GetButton("Horizontal"))
        //{
        //    transform.Translate(Vector3.left * speed * Time.deltaTime);
        //}
        //else if (Input.GetButton("Vertical"))
        //{
        //    transform.Translate(Vector3.forward * speed * Time.deltaTime);
        //}
        //else if (Input.GetButton("Vertical"))
        //{
        //    transform.Translate(Vector3.back * speed * Time.deltaTime);
        //}

        var vec =  new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical"));
        transform.Translate(vec * speed * Time.deltaTime);
    }
}
