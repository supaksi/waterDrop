using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using extOSC;

public class transmitterTest : MonoBehaviour
{
    #region Public Vars

    public string Address = "/example/1";

    [Header("OSC Settings")]
    public OSCTransmitter Transmitter;

    #endregion

    #region Unity Methods

    private void Update()
    {
        var message = new OSCMessage(Address);

        message.AddValue(OSCValue.Float(transform.position.y));

        Transmitter.Send(message);
    }


    #endregion
}
