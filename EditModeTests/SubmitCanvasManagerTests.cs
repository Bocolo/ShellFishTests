using NUnit.Framework;
using UI.Submit;
using UnityEngine;

public class SubmitCanvasManagerTests
{
    private SubmitCanvasManager submitCanvasManager;
    [SetUp]
    public void SetUp()
    {
        GameObject go = new GameObject();
        submitCanvasManager = go.AddComponent<SubmitCanvasManager>();
        submitCanvasManager.SetUp();
    }
  
 /*   [Test]
    public void CanvasManager_Pop_Up_Set_Text()
    {
        submitCanvasManager.DisplayPopUP("Pop up text test");
        Assert.AreEqual("Pop up text test", submitCanvasManager.MissingValuesPopUp.text);
      
    }*/
/*    [Test]
    public void CanvasManager_Pop_Up_Active()
    {
        submitCanvasManager.DisplayPopUP("");
        Assert.That(submitCanvasManager.MissingValuesPopUp.isActiveAndEnabled);

    }
    [Test]
    public void CanvasManager_Pop_Up_InActive()
    {
        Assert.That(submitCanvasManager.MissingValuesPopUp.isActiveAndEnabled);
        submitCanvasManager.HidePopUp();
        Assert.That(!submitCanvasManager.MissingValuesPopUp.isActiveAndEnabled);
    }*/
   
}
