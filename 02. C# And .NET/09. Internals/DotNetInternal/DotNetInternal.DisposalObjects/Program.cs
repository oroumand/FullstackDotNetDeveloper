using DotNetInternal.DisposalObjects;

using (var mf = new DotNetInternal.DisposalObjects.MyFileStream())
{

}

using MyFileStream mf = new MyFileStream();


