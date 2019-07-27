using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour {

    [SerializeField] Button leftBtn;
    [SerializeField] Button rightBtn;
    [SerializeField] Button powerBtn;

    GameController gameController;
    Ball playerBall;

    private void Start() {
        gameController = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>();
        playerBall = GameObject.FindGameObjectWithTag("Player").GetComponent<Ball>();
        leftBtn.onClick.AddListener(playerBall.RotateArrowLeft);
        rightBtn.onClick.AddListener(playerBall.RotateArrowRight);
        powerBtn.onClick.AddListener(playerBall.AddPower);
    }



}
