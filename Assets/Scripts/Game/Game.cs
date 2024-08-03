
using System.Collections.Generic;
using System.Collections;
using UnityEngine;

public class Game : MonoBehaviour
{
    public static Game Instance;

    public static List<Card> cardHeap = new List<Card>();

    public delegate bool targetFilter(Player player);
    private void Awake()
    {
        Instance = this;
    }
    private void Start()
    {
        AddCards();
        Shuffle();
    }

    public void AddCard<T>(int number,Card.Suit color) where T : Card,new()
    {
        T card = new T();
        card.number = number;
        card.suit = color;
        cardHeap.Add(card);
    }

    public void printCardHeap()
    {
        foreach (Card card in cardHeap)
        {
            print(card.GetInfo());
        }
    }

    /// <summary>
    /// 洗牌
    /// </summary>
    public void Shuffle()
    {
        for(int i = 0;i< cardHeap.Count;i++)
        {
            int inx = Random.Range(0, cardHeap.Count);
            if(inx != i)
            {
                var tmp = cardHeap[i];
                cardHeap[i] = cardHeap[inx];
                cardHeap[inx] = tmp;
            }
        }
    }

    /// <summary>
    /// 获得牌堆顶的一张牌
    /// </summary>
    /// <returns>牌堆顶的一张牌</returns>
    public Card GetTop()
    {
        var card = cardHeap[0];
        cardHeap.RemoveAt(0);
        return card;
    }


    void AddCards()
    {
        AddCard<Sha>(7, Card.Suit.Spade);
        AddCard<Sha>(8, Card.Suit.Spade);
        AddCard<Sha>(8, Card.Suit.Spade);
        AddCard<Sha>(9, Card.Suit.Spade);
        AddCard<Sha>(9, Card.Suit.Spade);
        AddCard<Sha>(10, Card.Suit.Spade);
        AddCard<Sha>(10, Card.Suit.Spade);

        AddCard<Sha>(10, Card.Suit.Heart);
        AddCard<Sha>(10, Card.Suit.Heart);

        AddCard<Sha>(2, Card.Suit.Club);
        AddCard<Sha>(3, Card.Suit.Club);
        AddCard<Sha>(4, Card.Suit.Club);
        AddCard<Sha>(5, Card.Suit.Club);
        AddCard<Sha>(6, Card.Suit.Club);
        AddCard<Sha>(7, Card.Suit.Club);
        AddCard<Sha>(8, Card.Suit.Club);
        AddCard<Sha>(8, Card.Suit.Club);
        AddCard<Sha>(9, Card.Suit.Club);
        AddCard<Sha>(9, Card.Suit.Club);
        AddCard<Sha>(10, Card.Suit.Club);
        AddCard<Sha>(10, Card.Suit.Club);
        AddCard<Sha>(11, Card.Suit.Club);
        AddCard<Sha>(11, Card.Suit.Club);

        AddCard<Sha>(6, Card.Suit.Diamond);
        AddCard<Sha>(7, Card.Suit.Diamond);
        AddCard<Sha>(8, Card.Suit.Diamond);
        AddCard<Sha>(9, Card.Suit.Diamond);
        AddCard<Sha>(10, Card.Suit.Diamond);
        AddCard<Sha>(13, Card.Suit.Diamond);
    }

    public void chooseTarget(int number,targetFilter targetFilter)
    {

    }

    public string Translate(string text)
    {
        switch (text)
        {
            case "Spade":
                {
                    return "♠";
                }
            case "Heart":
                {
                    return "♥";
                }
            case "Diamond":
                {
                    return "♦";
                }
            case "Club":
                {
                    return "♣";
                }
        }
        List<int> num = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 };
        foreach (int i in num)
        {
            if(i.ToString() == text)
            {
                if (text == "1") return "A";
                if (text == "11") return "J";
                if (text == "12") return "Q";
                if (text == "13") return "K";
                return text;
            }
        }
        return "undefined";
    }
}
