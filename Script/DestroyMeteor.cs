﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyMeteor : MonoBehaviour {
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "meteor")
        {
            Destroy(collision.gameObject);
        }
    }
}
