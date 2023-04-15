using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class YouLosePanel : MonoBehaviour
{
    [SerializeField] private GameObject youLosePanel;
    [SerializeField] private Button tryAgainButton;
    private void OnEnable()
    {
        GameManager.Instance.OnGameOver += OnGameOver;
    }

    private void OnDisable()
    {
        GameManager.Instance.OnGameOver -= OnGameOver;
    }

    private void Awake()
    {
        if (youLosePanel.activeSelf)
            youLosePanel.SetActive(false);
    }

    private void Start()
    {
        tryAgainButton.onClick.AddListener(ClickedTryAgain);
        
    }

    private void OnGameOver()
    {
        if(!youLosePanel.activeSelf)
            youLosePanel.SetActive(true);
    }

    private void ClickedTryAgain()
    {
        GameManager.Instance.LoadLevelScene();
    }
    
    
}
