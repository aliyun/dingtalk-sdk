// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkhrbrain_1_0.Models
{
    public class HrbrainImportEmpInfoRequest : TeaModel {
        [NameInMap("body")]
        [Validation(Required=false)]
        public List<HrbrainImportEmpInfoRequestBody> Body { get; set; }
        public class HrbrainImportEmpInfoRequestBody : TeaModel {
            [NameInMap("birthday")]
            [Validation(Required=false)]
            public string Birthday { get; set; }

            [NameInMap("deptName")]
            [Validation(Required=false)]
            public string DeptName { get; set; }

            [NameInMap("deptNo")]
            [Validation(Required=false)]
            public string DeptNo { get; set; }

            [NameInMap("dimissionDate")]
            [Validation(Required=false)]
            public string DimissionDate { get; set; }

            [NameInMap("empSource")]
            [Validation(Required=false)]
            public string EmpSource { get; set; }

            [NameInMap("empStatus")]
            [Validation(Required=false)]
            public string EmpStatus { get; set; }

            [NameInMap("empType")]
            [Validation(Required=false)]
            public string EmpType { get; set; }

            [NameInMap("extendInfo")]
            [Validation(Required=false)]
            public Dictionary<string, object> ExtendInfo { get; set; }

            [NameInMap("gender")]
            [Validation(Required=false)]
            public string Gender { get; set; }

            [NameInMap("highestDegree")]
            [Validation(Required=false)]
            public string HighestDegree { get; set; }

            [NameInMap("highestEduName")]
            [Validation(Required=false)]
            public string HighestEduName { get; set; }

            [NameInMap("isDimission")]
            [Validation(Required=false)]
            public string IsDimission { get; set; }

            [NameInMap("jobCodeName")]
            [Validation(Required=false)]
            public string JobCodeName { get; set; }

            [NameInMap("jobLevel")]
            [Validation(Required=false)]
            public string JobLevel { get; set; }

            [NameInMap("lastSchoolName")]
            [Validation(Required=false)]
            public string LastSchoolName { get; set; }

            [NameInMap("marriage")]
            [Validation(Required=false)]
            public string Marriage { get; set; }

            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("nation")]
            [Validation(Required=false)]
            public string Nation { get; set; }

            [NameInMap("nationCtry")]
            [Validation(Required=false)]
            public string NationCtry { get; set; }

            [NameInMap("politicalStatus")]
            [Validation(Required=false)]
            public string PoliticalStatus { get; set; }

            [NameInMap("postName")]
            [Validation(Required=false)]
            public string PostName { get; set; }

            [NameInMap("registDate")]
            [Validation(Required=false)]
            public string RegistDate { get; set; }

            [NameInMap("regularDate")]
            [Validation(Required=false)]
            public string RegularDate { get; set; }

            [NameInMap("superEmpId")]
            [Validation(Required=false)]
            public string SuperEmpId { get; set; }

            [NameInMap("superName")]
            [Validation(Required=false)]
            public string SuperName { get; set; }

            [NameInMap("workEmail")]
            [Validation(Required=false)]
            public string WorkEmail { get; set; }

            [NameInMap("workLocAddr")]
            [Validation(Required=false)]
            public string WorkLocAddr { get; set; }

            [NameInMap("workLocCity")]
            [Validation(Required=false)]
            public string WorkLocCity { get; set; }

            [NameInMap("workNo")]
            [Validation(Required=false)]
            public string WorkNo { get; set; }

        }

        [NameInMap("corpId")]
        [Validation(Required=false)]
        public string CorpId { get; set; }

    }

}
