using System;
using System.Reflection;
using UnityEngine;

public class Homework2 : MonoBehaviour
{
    public Transform[] players;
    private Transform currentPlayer;
    private  int index;
    public float passDistance;

    public Transform relayBaton;
    void Start()
    {
        index = 0;
        currentPlayer = players[index];

    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
    }

    private void MovePlayer()
    {
        currentPlayer.position = Vector3.MoveTowards(currentPlayer.position, players[index + 1].position, Time.deltaTime);
        if (passDistance >= Vector3.Distance(currentPlayer.position, players[index + 1].position) && (index + 1) < players.Length)
        {
            index++;
            currentPlayer = players[index];
            relayBaton.SetParent(currentPlayer);
            relayBaton.localPosition = Vector3.forward;
            currentPlayer.LookAt(players[index + 1]);            
        }
    }
}
