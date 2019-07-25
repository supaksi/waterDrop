using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Water : MonoBehaviour
{
    [SerializeField] GameObject destoryFXPrefab = default;
    [SerializeField] Sprite sprite1 = default;
    [SerializeField] Sprite sprite2 = default;
    [SerializeField] Sprite sprite3 = default;
    [SerializeField] Sprite sprite4 = default;
    [SerializeField] Sprite sprite5 = default;

    //void onTriggerEnter2D(Collision2D other)
    //{

    //    Debug.Log("collision from onTriggerEnter2D!!");

    //}

    GameObject audioPlayer;
    AudioSource audioSource;

    private void Start()
    {
        SpriteRenderer renderer = GetComponent<SpriteRenderer>();
        int spriteNumber = Random.Range(0,5);
        if (spriteNumber == 0)
        {
            renderer.sprite = sprite1;
        }
        else if (spriteNumber == 1) renderer.sprite = sprite2;
        else if (spriteNumber == 2) renderer.sprite = sprite3;
        else if (spriteNumber == 3) renderer.sprite = sprite4;
        else if (spriteNumber == 4) renderer.sprite = sprite5;


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
            Debug.Log("Audio Play!");

            //Instantiate, Destroy
            Instantiate(destoryFXPrefab, gameObject.transform.position, Quaternion.identity);
            Destroy(gameObject);


        }
    }

}