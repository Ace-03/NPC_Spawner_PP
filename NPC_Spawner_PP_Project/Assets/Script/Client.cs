using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Client : MonoBehaviour
{
    public NPCSpawner m_SpawnerNPC;

    public TextMeshProUGUI _text;

    public ParticleSystem _partShop;
    public ParticleSystem _partFarm;
    public ParticleSystem _partBeg;
    public ParticleSystem _partKing;

    public void Start()
    {
        _partShop.GetComponent<ParticleSystem>();
        _partFarm.GetComponent<ParticleSystem>();
        _partBeg.GetComponent<ParticleSystem>();
        _partKing.GetComponent<ParticleSystem>();
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            m_SpawnerNPC.SpawnVillagers();
            _partShop.Play();
            _partFarm.Stop();
            _partBeg.Stop();
            _partKing.Stop();
            _text.SetText(m_SpawnerNPC.m_Shopowner.Speak());
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            m_SpawnerNPC.SpawnVillagers();
            _partShop.Stop();
            _partFarm.Play();
            _partBeg.Stop();
            _partKing.Stop();
            _text.SetText(m_SpawnerNPC.m_Farmer.Speak());
        }
        else if (Input.GetKeyDown(KeyCode.F))
        {
            m_SpawnerNPC.SpawnVillagers();
            _partShop.Stop();
            _partFarm.Stop();
            _partBeg.Play();
            _partKing.Stop();
            _text.SetText(m_SpawnerNPC.m_Beggar.Speak());
        }
        else if (Input.GetKeyDown(KeyCode.G))
        {
            m_SpawnerNPC.SpawnVillagers();
            _partShop.Stop();
            _partFarm.Stop();
            _partBeg.Stop();
            _partKing.Play();
            _text.SetText(m_SpawnerNPC.m_King.Speak());
        }
        //else if (Input.GetKeyDown(KeyCode.G))
            //_text.SetText("LOLOL");

    }
}
