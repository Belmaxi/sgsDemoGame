using Platformer.Core;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using static Platformer.Core.Simulation;

public class CardUI : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerClickHandler
{
    public Card card;
    public Text color;
    public Text number;

    public Image image;
    void Start()
    {
        image = GetComponent<Image>();
    }
    public void Init(Card _card)
    {
        card = _card;
        //image.sprite = card.texture;
        color.text = Game.Instance.Translate(_card.suit.ToString());
        number.text = Game.Instance.Translate(_card.number.ToString());
    }
    public void OnPointerEnter(PointerEventData eventData)
    {
        if(card.isSelected)
        {
            return;
        }
        transform.position += new Vector3(0, 30, 0);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        if (card.isSelected)
        {
            return;
        }
        transform.position -= new Vector3(0, 30, 0);
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        var ev = Schedule<SelectCard>();
        ev.card = card;
        if (card.isSelected)
        {
            card.isSelected = false;
            image.color = Color.white;
        }
        else
        {
            card.isSelected = true;
            image.color = Color.yellow;
        }
    }

}
