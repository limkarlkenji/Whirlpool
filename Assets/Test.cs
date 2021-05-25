using System.Collections;
using UnityEngine;

public class Test : MonoBehaviour
{
    public Material mat;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void Update()
    {
        if(Input.GetKeyUp(KeyCode.Space))
        {
            StartCoroutine(s());
        }

        if (Input.GetKeyUp(KeyCode.Backspace))
        {
            mat.SetFloat("Vector1_be04b499a65b4662bf15d1784e13aa60", 0);
        }
    }

    IEnumerator s()
    {
        float t = 0;

        while(t < 1)
        {
            t += Time.deltaTime * speed;
            mat.SetFloat("Vector1_be04b499a65b4662bf15d1784e13aa60", Mathf.Lerp(0, 1, t));
            yield return null;
        }
    }
}
