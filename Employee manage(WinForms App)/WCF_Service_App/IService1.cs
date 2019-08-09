namespace WCF_Service_App
{
    using System.Data;
    using System.Runtime.Serialization;
    using System.ServiceModel;

    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        string InsertEmployer(Employers e);

        [OperationContract]

        string[] FindEmployerById(int id);

        [OperationContract]
        DataSet ShowAllEntities();
    }

    [DataContract]
    public class Employers
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string FIO { get; set; }
        [DataMember]
        public string Address { get; set; }
        [DataMember]
        public int Phone { get; set; }
        [DataMember]
        public string Email { get; set; }
        [DataMember]
        public string Datebirthday { get; set; }
        [DataMember]
        public string Salary { get; set; }
    }
}
