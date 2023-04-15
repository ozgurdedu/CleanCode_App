using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class YouWinPanel : MonoBehaviour
{
    [SerializeField] private GameObject youWinPanel;
    [SerializeField] private Button tryAgainButton;
    private void OnEnable()
    {
        GameManager.Instance.OnMissionSucceed += OnMissionSucceed;
    }

    private void OnDisable()
    {
        GameManager.Instance.OnMissionSucceed -= OnMissionSucceed;
    }

    private void Awake()
    {
        if (youWinPanel.activeSelf)
            youWinPanel.SetActive(false);
    }

    private void Start()
    {
        tryAgainButton.onClick.AddListener(ClickedTryAgain);
        
    }

    private void OnMissionSucceed()
    {
        if (!youWinPanel.activeSelf)
            youWinPanel.SetActive(true);
    }

    private void ClickedTryAgain()
    {
        GameManager.Instance.LoadLevelScene();
    }


}
