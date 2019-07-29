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
        // message 생성, 주소가 필요
        var message = new OSCMessage(Address);
        
        // message에 데이터 추가 "스트링"
        message.AddValue(OSCValue.Float(transform.position.y));

        // 전송!
        Transmitter.Send(message);
    }


    #endregion
}
