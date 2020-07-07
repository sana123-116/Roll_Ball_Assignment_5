using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public float speed;
    Text name;
    private Rigidbody rb;
    //private int count;
    public Text message;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
       // count = 0;
        //counter.text = "Objects Picked: "+count.ToString();
    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        rb.AddForce(movement * speed);
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pick Up"))
        {
           


            string label = other.gameObject.name;
            string last_chr = label.Substring(label.Length - 1);
            name = GameObject.Find("Sphere" + last_chr + "/Canvas/Text").GetComponent<Text>();
            if (check_palindrome(name.text))
            {
                other.gameObject.SetActive(false);
                name.text="";
                message.text = "Wow...It's Palindrome";
            }
            else
            {
                message.text = "Not a Palindrome";
            }
        }
    }
    public bool check_palindrome(string name_str)
    {
        bool result = false;
        string rev;
        //string1 = "Malayalam";
        char[] ch = name_str.ToCharArray();
        Array.Reverse(ch);
        rev = new string(ch);
        result = name_str.Equals(rev, StringComparison.OrdinalIgnoreCase);
        return result;
    }
}
