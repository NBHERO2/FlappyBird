using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyPipe : MonoBehaviour
{

    private void Awake()
    {
        StartCoroutine(waiter());
    }

    IEnumerator waiter()
    {
        yield return new WaitForSeconds(5);
        Object.Destroy(gameObject);
    }
}
