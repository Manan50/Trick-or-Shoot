﻿using UnityEngine;
using System.Collections;

public class CameraShake : MonoBehaviour
{



    public IEnumerator Shake(float duration, float magnitude)
    {
        Vector3 orignalPosition = new Vector3(0, 0, -10);
        float elapsed = 0.0f;

        while (elapsed < duration)
        {
            float x = Random.Range(-1f, 1f) * magnitude;
            float y = Random.Range(-1f, 1f) * magnitude;

            transform.position = new Vector3(x, y, orignalPosition.z);
            elapsed += Time.deltaTime;
            yield return 0;
        }
        transform.position = orignalPosition;
    }


}