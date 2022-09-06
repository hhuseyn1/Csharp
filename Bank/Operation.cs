namespace Operation;
class Operation{
    public  Guid Id { get; set; }= Guid.NewGuid();
    public string Process_Name { get; set; }
    public  DateTime DateTime { get; set; }

    public Operation(string process_name)
    {
        Process_Name = process_name;
        DateTime = DateTime.Now;
    }

    public override string ToString(){
        return  @$"Id: {Id}
Process Name: {Process_Name}
Date Time: {DateTime}";
    }
}

