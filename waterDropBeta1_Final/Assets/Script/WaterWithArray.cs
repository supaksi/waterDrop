using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterWithArray : MonoBehaviour
{
    [SerializeField] Sprite[] waters = new Sprite[5];
    [SerializeField] GameObject splashPrefab;

    int m_SpriteNumber;

    GameObject audioPlayer;
    AudioSource audioSource;

    private void Start()
    {
        SpriteRenderer m_Renderer = GetComponent<SpriteRenderer>();
        m_SpriteNumber = Random.Range(0,5);
        m_Renderer.sprite = waters[m_SpriteNumber];


        // 오디오플레이어 로드
        audioPlayer = GameObject.FindGameObjectWithTag("MyAudioPlayer");
        audioSource = audioPlayer.GetComponent<AudioSource>();
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            //오디오 재생
            audioSource.Play();
            //Debug.Log("Audio Play!");


            GameObject temp_Splash = Instantiate(splashPrefab, gameObject.transform.position, Quaternion.identity);
            Splash splashScript = temp_Splash.GetComponent<Splash>();
            splashScript.ChangeSprite(m_SpriteNumber);
            Destroy(gameObject);
        }
    }
}