// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkhrbrain_1_0.Models
{
    public class HrbrainImportDimissionRequest : TeaModel {
        [NameInMap("body")]
        [Validation(Required=false)]
        public List<HrbrainImportDimissionRequestBody> Body { get; set; }
        public class HrbrainImportDimissionRequestBody : TeaModel {
            [NameInMap("deptName")]
            [Validation(Required=false)]
            public string DeptName { get; set; }

            [NameInMap("deptNo")]
            [Validation(Required=false)]
            public string DeptNo { get; set; }

            [NameInMap("dimissionDate")]
            [Validation(Required=false)]
            public string DimissionDate { get; set; }

            [NameInMap("dimissionReaasonDesc")]
            [Validation(Required=false)]
            public string DimissionReaasonDesc { get; set; }

            [NameInMap("dimissionReason")]
            [Validation(Required=false)]
            public string DimissionReason { get; set; }

            [NameInMap("empType")]
            [Validation(Required=false)]
            public string EmpType { get; set; }

            [NameInMap("extendInfo")]
            [Validation(Required=false)]
            public Dictionary<string, object> ExtendInfo { get; set; }

            [NameInMap("jobCodeName")]
            [Validation(Required=false)]
            public string JobCodeName { get; set; }

            [NameInMap("jobLevel")]
            [Validation(Required=false)]
            public string JobLevel { get; set; }

            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("postName")]
            [Validation(Required=false)]
            public string PostName { get; set; }

            [NameInMap("superName")]
            [Validation(Required=false)]
            public string SuperName { get; set; }

            [NameInMap("workLocAddr")]
            [Validation(Required=false)]
            public string WorkLocAddr { get; set; }

            [NameInMap("workNo")]
            [Validation(Required=false)]
            public string WorkNo { get; set; }

        }

        [NameInMap("corpId")]
        [Validation(Required=false)]
        public string CorpId { get; set; }

    }

}
