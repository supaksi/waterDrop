using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cloud : MonoBehaviour
{

    [SerializeField] GameObject WaterPrefab = default;

    public float mouseYMinRange = 3f;
    public float mouseYMaxRange = 3.5f;

    AudioSource audioSource;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

        Vector3 mousePosition = Input.mousePosition;
        //mousePosition.y = // y 값은 3~3.5 사이로 고정 시켜 놓고 싶
        mousePosition.z = -Camera.main.transform.position.z;
        mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
        bool positionedInRange = mousePosition.y > mouseYMinRange && mousePosition.y < mouseYMaxRange;

        if (positionedInRange) gameObject.transform.position = mousePosition;



        // 마우스 클릭했을때 설정한 프리팹이 랜덤하게 나오도록 설정

        if (Input.GetMouseButtonDown(0))
        {
            Instantiate<GameObject>(WaterPrefab, gameObject.transform.position, Quaternion.identity);
            audioSource.Play();
        }
               
    }
}
