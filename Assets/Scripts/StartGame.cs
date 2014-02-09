using UnityEngine;
using System.Collections;

public class StartGame : MonoBehaviour {

    public Sprite hover;
    public AudioClip hoverSound;
    public AudioClip selectSound;

    private Sprite normal;
    private SpriteRenderer renderer;
    private AudioSource audio;

    void Awake()
    {
        renderer = GetComponent<SpriteRenderer>();
        audio = GetComponent<AudioSource>();
        normal = renderer.sprite;
    }

    void OnMouseEnter()
    {
        renderer.sprite = hover;
        audio.clip = hoverSound;
        audio.Play();
    }

    void OnMouseExit()
    {
        renderer.sprite = normal;
    }

    void OnMouseUp()
    {
        audio.clip = selectSound;
        audio.Play();
        Application.LoadLevel(1);
    }
}
