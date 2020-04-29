using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class battle : MonoBehaviour
{

    public int bat_hp = 300;
    public int s_hp = 300;
    public int heal = 10;
    public int damage = 10;
    
    public Enemy enemy;

    public Text result;

    public void  BatDamages()
    {
        int temp= enemy.Attack(s_hp);
        print("史萊姆受到了傷害 : " + damage + "\n" + "史萊姆剩餘血量 : " + temp);
        result.text = "史萊姆受到了傷害 : " + damage + "\n" + "史萊姆剩餘血量 : " + temp;
        s_hp = enemy.Attack(s_hp);
    }

    public void SDamages()
    {
        int temp = enemy.Attack(bat_hp);
        print("蝙蝠受到了傷害 : " + damage + "\n" + "蝙蝠剩餘血量 : " + temp);
        result.text = "蝙蝠受到了傷害 : " + damage + "\n" + "蝙蝠剩餘血量 : " + temp;
        bat_hp = enemy.Attack(bat_hp);        
    }



    public void BatHeal()
    {
        int temp = enemy.Heal(bat_hp);
        print("蝙蝠回復了 : "+ heal+"點血量"+ "\n" + "蝙蝠剩餘血量 :" +temp);
        result.text = "蝙蝠回復了 : " + heal + "點血量" + "\n" + "蝙蝠剩餘血量 :" + temp;
        bat_hp = enemy.Heal(bat_hp);
    }

    public void SHeal()
    {
        int temp = enemy.Heal(s_hp);
        print("史萊姆回復了" + heal+"點血量" + "\n" + "史萊姆剩餘血量 :" + temp);
        result.text = "史萊姆回復了" + heal + "點血量" + "\n" + "史萊姆剩餘血量 :" + temp;
        s_hp = enemy.Heal(s_hp);
    }   
}
