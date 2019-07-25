using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Splash : MonoBehaviour
{
    [SerializeField] float m_ThresholdTime = 1f;
    [SerializeField] Sprite[] splashes = new Sprite[5];
    SpriteRenderer m_Renderer; //member variable

    float m_ElapsedTime = 0f;


    // Start is called before the first frame update
    void Awake()
    {
        m_Renderer = gameObject.GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        m_ElapsedTime += Time.deltaTime;
        if (m_ElapsedTime > m_ThresholdTime)
        {
            Destroy(gameObject);
        }
    }

    public void ChangeSprite(int splashIndex)
    {
        m_Renderer.sprite = splashes[splashIndex];
    }
}
