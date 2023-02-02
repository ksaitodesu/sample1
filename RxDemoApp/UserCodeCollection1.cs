/*
 * Created by Ranorex
 * User: ksaito
 * Date: 2023/01/18
 * Time: 18:08
 * 
 * To change this template use Tools > Options > Coding > Edit standard headers.
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;

namespace RxDemoApp
{
    /// <summary>
    /// ユーザー コード ライブラリにユーザー コード メソッドを公開するためのファイルです。
    /// </summary>
    [UserCodeCollection]
    public class UserCodeCollection1
    {
        // You can use the "Insert New User Code Method" functionality from the context menu,
        // to add a new method with the attribute [UserCodeMethod].
        
        
        public void Key_sequence(string Hensuu)
        {
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Hensuu'.");
            Keyboard.Press(Hensuu);
        }
    }
}
