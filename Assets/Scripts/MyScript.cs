using UnityEngine;

public class MyScript : MonoBehaviour
{
    void Start()
    {
        Debug.Log("Hello from Unity!");
    }

    void Update()
    {
        //Debug.Log("Hello man");
    }

    void debugger()
    {
        string a = Debug.Log("HelloMyForstNicePeople");
        debugger() = a+ a;
    }
}
