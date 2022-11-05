package com.iffy.unitytest;

import android.util.Log;

public class Model {
    public String getPhoneModel() {
        Log.e("iffy", "I received the getPhoneModel message from unity");
        Log.e("iffy", "my model is" + android.os.Build.MODEL);
        return android.os.Build.MODEL;
    }

    public void sendMessage(String s) {
        Log.e("iffy", "I received the message from unity" + s);
    }
}
