using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainPenal : MonoBehaviour
{
    public static MainPenal Instance;
    private int remainCardsNumber;

    private List<Card> cards;
    public GameObject area;
    public GameObject cardsArea;
    public CardUI cardUI;

    private void Awake()
    {
        Instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        CardUI cardui = Instantiate<CardUI>(cardUI, cardsArea.transform);
        cardui.Init(Game.Instance.GetTop());
        CardUI cardui2 = Instantiate<CardUI>(cardUI, cardsArea.transform);
        cardui2.Init(Game.Instance.GetTop());
    }
}
