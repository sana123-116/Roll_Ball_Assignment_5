using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Rotator : MonoBehaviour
{
  //  public Text obj_str;

    void Start()
    {
       // obj_str.text = "(x, s, 6)";
    }

    void Update()
    {
        transform.Rotate(new Vector3(15, 30, 45) * Time.deltaTime);
       // Vector3 name_lab = Camera.main.WorldToScreenPoint(this.transform.position);
     //   obj_str.transform.position = name_lab;
    }
}
