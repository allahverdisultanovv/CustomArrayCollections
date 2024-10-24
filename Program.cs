using CustomListArrayCollections.Models;

CustomList<int> customListArray = new CustomList<int>();
customListArray.Add(3);
customListArray.Add(2);
customListArray.Add(5);
customListArray.Add(4);
customListArray.Add(9);
customListArray.Add(6);


CustomList<string> customList = new CustomList<string>();
customList.Add("rgd");
customList.Add("regnu");
customList.Add("grd");


Console.WriteLine(customListArray.ToString());


Console.WriteLine(customList.Contains("grd"));

Console.WriteLine(customList.Capacity);