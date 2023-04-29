using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Sirenix.OdinInspector;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    private bool _showInputKeys;

    [ShowIf("_showInputKeys")]
    [HorizontalGroup("UpKey")]
    public KeyCode upKey1, upKey2;

    [ShowIf("_showInputKeys")]
    [HorizontalGroup("DownKey")]
    public KeyCode downKey1, downKey2;

    [ShowIf("_showInputKeys")]
    [HorizontalGroup("LeftKey")]
    public KeyCode leftKey1, leftKey2;

    [ShowIf("_showInputKeys")]
    [HorizontalGroup("RightKey")]
    public KeyCode rightKey1, rightKey2;

    private float _movementSpeed;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void InputHandler()
    {
 
    }
}


