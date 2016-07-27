using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;

///
/// !!! Machine generated code !!!
///
/// A class which deriveds ScritableObject class so all its data 
/// can be serialized onto an asset data file.
/// 
[System.Serializable]
public class MusicObject : ScriptableObject 
{	
    [HideInInspector] [SerializeField] 
    public string sheetName = "";
    
    [HideInInspector] [SerializeField] 
    public string worksheetName = "";
    
    [ExposeProperty]
    public string SheetName 
    {
        get { return sheetName; }
        set { sheetName = value;}
    }
    
    [ExposeProperty]
    public string WorksheetName
    {
        get { return worksheetName; }
        set { worksheetName = value;}
    }
    
    // Note: initialize in OnEnable() not here.
    public MusicObjectData[] dataArray;
    
	public List<MusicObjectData> MusicObjectDataList;

    void OnEnable()
    {		
//#if UNITY_EDITOR
        //hideFlags = HideFlags.DontSave;
//#endif
        // Important:
        //    It should be checked an initialization of any collection data before it is initialized.
        //    Without this check, the array collection which already has its data get to be null 
        //    because OnEnable is called whenever Unity builds.
        // 		
        if (dataArray == null)
            dataArray = new MusicObjectData[0];
		MusicObjectDataList = new System.Collections.Generic.List<MusicObjectData>( dataArray );
    }
    
    //
    // Highly recommand to use LINQ to query the data sources.
    //

}
