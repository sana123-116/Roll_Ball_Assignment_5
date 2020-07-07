using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class attach_text : MonoBehaviour
{
    public Text nameLabel;
    void Update()
    {
        Vector3 namepos = Camera.main.WorldToScreenPoint(this.transform.position);
        nameLabel.transform.position = namepos;
    }
}
