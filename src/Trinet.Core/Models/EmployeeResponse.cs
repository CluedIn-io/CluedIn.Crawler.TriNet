using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace CluedIn.Crawling.Trinet.Core.Models
{
  
    public class NameObject
    {

        [JsonProperty("nameType")]
        public string NameType { get; set; }

        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("personTitle")]
        public string PersonTitle { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("nameFormat")]
        public string NameFormat { get; set; }

        [JsonProperty("formOfAddress")]
        public string FormOfAddress { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("middleName")]
        public string MiddleName { get; set; }

        [JsonProperty("suffix")]
        public string Suffix { get; set; }

        [JsonProperty("effectiveDate")]
        public string EffectiveDate { get; set; }

        [JsonProperty("uniqueId")]
        public int UniqueId { get; set; }

        [JsonProperty("reasonChangeCode")]
        public object ReasonChangeCode { get; set; }
    }

    public class WorkersCompCode
    {

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }
    }

    public class Location
    {

        [JsonProperty("locationName")]
        public string LocationName { get; set; }

        [JsonProperty("headquarter")]
        public object Headquarter { get; set; }

        [JsonProperty("phone")]
        public object Phone { get; set; }

        [JsonProperty("locationId")]
        public string LocationId { get; set; }

        [JsonProperty("shortDesc")]
        public object ShortDesc { get; set; }

        [JsonProperty("officeHours")]
        public object OfficeHours { get; set; }

        [JsonProperty("effectiveDate")]
        public object EffectiveDate { get; set; }
    }

    public class Department
    {

        [JsonProperty("deptName")]
        public string DeptName { get; set; }

        [JsonProperty("deptId")]
        public string DeptId { get; set; }
    }

    public class Supervisor
    {

        [JsonProperty("supervisorName")]
        public string SupervisorName { get; set; }

        [JsonProperty("supervisorId")]
        public string SupervisorId { get; set; }
    }

    public class EmploymentInfo
    {

        [JsonProperty("employeeClass")]
        public object EmployeeClass { get; set; }

        [JsonProperty("regularTemporary")]
        public string RegularTemporary { get; set; }

        [JsonProperty("serviceDate")]
        public string ServiceDate { get; set; }

        [JsonProperty("workEmail")]
        public string WorkEmail { get; set; }

        [JsonProperty("standardHours")]
        public string StandardHours { get; set; }

        [JsonProperty("jobCode")]
        public string JobCode { get; set; }

        [JsonProperty("workersCompCode")]
        public WorkersCompCode WorkersCompCode { get; set; }

        [JsonProperty("flsaCode")]
        public string FlsaCode { get; set; }

        [JsonProperty("employmentStatus")]
        public string EmploymentStatus { get; set; }

        [JsonProperty("payGroup")]
        public string PayGroup { get; set; }

        [JsonProperty("terminationDate")]
        public string TerminationDate { get; set; }

        [JsonProperty("eventCode")]
        public string EventCode { get; set; }

        [JsonProperty("customGroupB")]
        public string CustomGroupB { get; set; }

        [JsonProperty("employeeType")]
        public string EmployeeType { get; set; }

        [JsonProperty("eventDesc")]
        public string EventDesc { get; set; }

        [JsonProperty("businessTitle")]
        public string BusinessTitle { get; set; }

        [JsonProperty("customGroupA")]
        public string CustomGroupA { get; set; }

        [JsonProperty("workPhone")]
        public string WorkPhone { get; set; }

        [JsonProperty("location")]
        public Location Location { get; set; }

        [JsonProperty("reasonCode")]
        public string ReasonCode { get; set; }

        [JsonProperty("department")]
        public Department Department { get; set; }

        [JsonProperty("effectiveDate")]
        public string EffectiveDate { get; set; }

        [JsonProperty("supervisor")]
        public Supervisor Supervisor { get; set; }

        [JsonProperty("reasonDesc")]
        public string ReasonDesc { get; set; }
    }

    public class EmployeePhoto
    {

        [JsonProperty("photoId")]
        public int PhotoId { get; set; }

        [JsonProperty("mimeType")]
        public string MimeType { get; set; }

        [JsonProperty("uri")]
        public string Uri { get; set; }
    }

    public class Employee
    {

        [JsonProperty("alternateId")]
        public string AlternateId { get; set; }

        [JsonProperty("names")]
        public List<NameObject> Names { get; set; }

        [JsonProperty("employmentInfo")]
        public EmploymentInfo EmploymentInfo { get; set; }

        [JsonProperty("employeePhoto")]
        public EmployeePhoto EmployeePhoto { get; set; }

        [JsonProperty("employeeId")]
        public string EmployeeId { get; set; }
    }

    public class Data
    {

        [JsonProperty("employeesTotal")]
        public int EmployeesTotal { get; set; }

        [JsonProperty("hasMore")]
        public bool HasMore { get; set; }

        [JsonProperty("employeeData")]
        public List<Employee> EmployeeData { get; set; }
    }

    public class EmployeeResponse
    {

        [JsonProperty("data")]
        public Data Data { get; set; }

        [JsonProperty("_requestId")]
        public string RequestId { get; set; }

        [JsonProperty("_statusCode")]
        public string StatusCode { get; set; }

        [JsonProperty("_statusText")]
        public string StatusText { get; set; }

        [JsonProperty("_statusMessage")]
        public string StatusMessage { get; set; }
    }


}
