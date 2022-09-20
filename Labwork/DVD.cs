namespace DVD;
using Storage;
class DVD:Storage{

	public int Type { get; set; }	


	public DVD(string MediaName,string Model,double Memory, double UsedMemory,int Type):base(MediaName,Model,Memory,UsedMemory)
	{
		this.Type = Type;
	}


	public double WriteSpeed()
	{
		if (Type == 1)
			return 3.8;
		else
			return 6.1;
	}
	public double ReadSpeed()
	{
		if (Type == 1)
			return 4.2;
		else
			return 7.9;
	}
	public override string ToString(){
return $@"{base.ToString()}
Type: {Type}
Write Speed: {WriteSpeed} mb/s
Read Speed: {ReadSpeed} mb/s 
";
}

}
