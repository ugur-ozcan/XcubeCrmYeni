﻿using DevExpress.XtraEditors;
using System.ComponentModel;
using System.Drawing;
using XCubeCrm.UI.Win.Interfaces;

namespace XCubeCrm.UI.Win.Forms.UserControls.Controls
{
    [ToolboxItem(true)]
    public class MyTextEdit : TextEdit, IStatusBarAciklama
    {
        public MyTextEdit()
        {
            Properties.AppearanceFocused.BackColor = Color.LightCyan;
            Properties.MaxLength = 50;
        }
        public override bool EnterMoveNextControl { get; set; } = true;
        public string  StatusBarAciklama { get; set; }
    
    }
}
