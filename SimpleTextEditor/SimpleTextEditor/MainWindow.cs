using System;
using Gtk;
using System.IO;

public partial class MainWindow : Gtk.Window
{
    public MainWindow() : base(Gtk.WindowType.Toplevel)
    {
        Build();
    }

    protected void OnDeleteEvent(object sender, DeleteEventArgs a)
    {
        Application.Quit();
        a.RetVal = true;
    }

    protected virtual void OnButton1Clicked(object sender, EventArgs e)
    {
        //code executed when the Clear button is clicked
        textview1.Buffer.Text = ""; //clears the buffer displayed by the TextView

        //changement du texte dans le bouton : 
        button1.Label = "vidé";
    }

    protected virtual void OnButton2Clicked(object sender, System.EventArgs e)
    {
        //code executed when the Upper Case button is clicked
        textview1.Buffer.Text = textview1.Buffer.Text.ToUpper();

        //Test de changement d'un AUTRE bouton : 
        button2.Label = "fait"; 
        button3.Label = "à faire";

    }

    protected virtual void OnButton3Clicked(object sender, System.EventArgs e)
    {
        //code executed when the Lower Case button is clicked
        textview1.Buffer.Text = textview1.Buffer.Text.ToLower();

        //Test de changement d'un AUTRE bouton : 
        button3.Label = "fait";
        button2.Label = "à faire";
    }

    protected virtual void OnButton4Clicked(object sender, System.EventArgs e)
    {
        //code executed when the Copy button is clicked
        StreamWriter sw = new StreamWriter("Test.txt");
        sw.Write(textview1.Buffer.Text); //Write textview1 text to file
        textview1.Buffer.Text = "Saved to file !"; //Notify user
        sw.Close();
    }

    protected void OnButton5Clicked(object sender, EventArgs e)
    {
        //entry2.GetData
        //clicl sur le bouton "Calc"
        textview2.Buffer.Text = "clic sur Calc effectué"; //clears the buffer displayed by the TextView
    }

    protected void OnEntry2TextInserted(object o, TextInsertedArgs args)
    {

    }

    protected void OnEntry3TextInserted(object o, TextInsertedArgs args)
    {

    }

    //protected void OnButton4Clicked(object sender, EventArgs e)
    //{
    //}
}