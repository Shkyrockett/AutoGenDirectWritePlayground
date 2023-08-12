// <copyright file="Form1.Designer.cs" company="Shkyrockett" >
// Copyright © 2020 - 2023 Shkyrockett. All rights reserved.
// </copyright>
// <author id="shkyrockett">Shkyrockett</author>
// <license>
// Licensed under the MIT License. See LICENSE file in the project root for full license information.
// </license>
// <summary></summary>
// <remarks></remarks>

using System.Runtime.InteropServices;

namespace AutoGenDirectWritePlayground;

/// <summary>
/// The form1.
/// </summary>
/// <seealso cref="System.Windows.Forms.Form" />
partial class Form1
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// The timer.
    /// </summary>
    private System.Timers.Timer timer;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components is not null))
        {
            components.Dispose();
        }

        if (disposing && (DirectWriteFactory is not null))
        {
            Marshal.ReleaseComObject(DirectWriteFactory!);
        }

        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code
    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        this.timer = new System.Timers.Timer();
        this.SuspendLayout();
        // 
        // timer
        // 
        this.timer.Enabled = true;
        this.timer.SynchronizingObject = this;
        this.timer.Elapsed += new System.Timers.ElapsedEventHandler(this.Timer_Tick);
        // 
        // Form1
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.BackColor = System.Drawing.Color.CornflowerBlue;
        this.ClientSize = new System.Drawing.Size(800, 450);
        this.DoubleBuffered = true;
        this.Name = "Form1";
        this.Text = "Auto Generated DirectWrite Playground";
        this.Resize += new System.EventHandler(this.Form1_Resize);
        this.ResumeLayout(false);
    }
    #endregion
}

