using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Credits : MonoBehaviour {

    public float switchTime = 6F;
    public List<Sprite> sprites;
    public GUIText name;
    public GUIText description;

    private float elapsed = 0F;
    private int current = 0;
    private List<CreditsItem> creditItems = new List<CreditsItem>()
    {
        new CreditsItem(){
            Name = "Trevor Olsen",
            Description = "Lead Developer\nDesign\nSound Effects"
        },
        new CreditsItem(){
            Name = "Carlos Cruz",
            Description = "Developer\nDesign\nSound Effects\nArt and Animation"
        },
        new CreditsItem(){
            Name = "Ronnie Dickison",
            Description = "Music"
        },
        new CreditsItem(){
            Name = "Clinton Olsen",
            Description = "Programming"
        }
    };

    void Start()
    {
        SetPerson(0);
    }

    void FixedUpdate()
    {
        if (elapsed >= switchTime)
        {
            elapsed = 0F;

            current++;
            if (current < sprites.Count)
                SetPerson(current);
            else
            {
                current = 0;
                SetPerson(current);
            }
        }
        elapsed += Time.deltaTime;

    }

    void SetPerson(int index)
    {
        GetComponent<SpriteRenderer>().sprite = sprites[current];
        name.text = creditItems[current].Name;
        description.text = creditItems[current].Description;
    }
}

public class CreditsItem
{
    public string Name { get; set; }
    public string Description { get; set; }

}
