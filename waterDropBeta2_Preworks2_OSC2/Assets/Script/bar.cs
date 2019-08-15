using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using extOSC;

public class bar : MonoBehaviour
{

    [Header("OSC Settings")]
    public string Address = "/example/1";
    public OSCTransmitter Transmitter;

    BoxCollider m_boxCollider;

    void Start()
    {
        m_boxCollider = GetComponent<BoxCollider>();

    }

    private void OnTriggerEnter(Collider other)
    {

        Debug.Log("entered");
        var message = new OSCMessage(Address);
        message.AddValue(OSCValue.String("bang"));
        Transmitter.Send(message);

    }
}
