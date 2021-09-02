using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyScript : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        for (int n = 1 ; n <= 100 ; n++)
        {
            print(n);
        }

        for (int n = 1 ; n <= 100 ; n++)
        {
            if (n%2==0)
            {
                print(n);
            }
        }

        float r = 5 ;
        float a = 3.14f;
        {
            float result = 0.0f;
            result = r * r * a;
            print (result);
        }
       
        
    }

}
