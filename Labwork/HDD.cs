namespace HDD;
using Storage;
class HDD : Storage
{
	public double USB2Speed =480;
	public HDD(string MediaName,string Model,double Memory,double UsedMemory) : base(MediaName, Model,Memory, UsedMemory) { }


	public override string ToString(){
return @$"{base.ToString()}
Usb 2.0 Speed: {USB2Speed} mb/s
";
}

}
