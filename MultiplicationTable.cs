using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultiplicationTable : MonoBehaviour
{
    int MultNumbers(int num1, int num2) {
        return num1 * num2;
    }
    void Start()
    {
        for (int i = 1; i <= 10; i++) {
            string line = "";
            line = "" + 5 + " X " + i + " = ";
            Debug.Log(line + (i * 5));
        }
    }
}
