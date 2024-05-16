using System.Collections;

ArrayList arrayList = new ArrayList();
arrayList.Add("adsf");
arrayList.Add(2);
arrayList.Add(3);
arrayList.Add(4);
arrayList.Add(DateTime.Now);


foreach (var item in arrayList)
{
    int value = (int)item;

}
