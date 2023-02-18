using System;

public class Referance
{
   
    private string _referance = "";
    List<string> _referList = new List<string>(){
        "Mosiah 5:15",
        "Ether 12:12",
        "Moroni 10:4",
        "1 Nephi 3:7",
        "Jacob 4:4"
    }; 
    public string RandReferance(int index){
        string _referance = _referList[index];
        return _referance;
    }
    public int GetListLength(){
        return _referList.Count();
    }

}