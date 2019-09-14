using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using extOSC;

public class GroundOSC : MonoBehaviour
{
    #region Fields

    public string Address = "/water/ground";

    [Header("OSC Settings")]
    public OSCTransmitter Transmitter;

    #endregion

    #region Unity Methods

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Water")
        {
            Destroy(other.gameObject);
            SendBangtoMax();
        }
    }

    void SendBangtoMax()
    {
        var message = new OSCMessage(Address);
        message.AddValue(OSCValue.String("bang"));

        Transmitter.Send(message);

    }

    #endregion


}
