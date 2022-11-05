using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Test : MonoBehaviour
{
   AndroidJavaClass javaClass = null; //静态方法
   AndroidJavaObject aobj = null;//创建对象使用
   public Text titleB;
   public void StartGame(){
    titleB.text ="开始游戏";
	   
   }
   
   public void ExitGame(){
	   Application.Quit();
   }

   public void getModel(){
      titleB.text ="开始游戏？？？？";
      //javaClass = new AndroidJavaClass("com.iffy.unitytest.Model");
      aobj = new AndroidJavaObject("com.iffy.unitytest.Model");
      titleB.text = aobj.Call<string>("getPhoneModel");
   }

}
