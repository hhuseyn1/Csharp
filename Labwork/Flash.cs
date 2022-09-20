namespace Flash;
using Storage;
 class Flash:Storage{ 

	public double Usb3Speed = 500;

	public Flash(string MediaName, string Model, double Memory,double UsedMemory) : base(MediaName, Model, Memory,UsedMemory) { }


	public override string ToString(){
return $@"{base.ToString()}
Usb 3.0 speed: {Usb3Speed} mb/s";
}


}
