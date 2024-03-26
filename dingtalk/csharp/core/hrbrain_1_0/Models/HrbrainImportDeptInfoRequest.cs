// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkhrbrain_1_0.Models
{
    public class HrbrainImportDeptInfoRequest : TeaModel {
        [NameInMap("body")]
        [Validation(Required=false)]
        public List<HrbrainImportDeptInfoRequestBody> Body { get; set; }
        public class HrbrainImportDeptInfoRequestBody : TeaModel {
            [NameInMap("createDate")]
            [Validation(Required=false)]
            public string CreateDate { get; set; }

            [NameInMap("deptName")]
            [Validation(Required=false)]
            public string DeptName { get; set; }

            [NameInMap("deptNo")]
            [Validation(Required=false)]
            public string DeptNo { get; set; }

            [NameInMap("effectiveDate")]
            [Validation(Required=false)]
            public string EffectiveDate { get; set; }

            [NameInMap("extendInfo")]
            [Validation(Required=false)]
            public Dictionary<string, object> ExtendInfo { get; set; }

            [NameInMap("isEffective")]
            [Validation(Required=false)]
            public string IsEffective { get; set; }

            [NameInMap("superDeptName")]
            [Validation(Required=false)]
            public string SuperDeptName { get; set; }

            [NameInMap("superDeptNo")]
            [Validation(Required=false)]
            public string SuperDeptNo { get; set; }

            [NameInMap("superEmpId")]
            [Validation(Required=false)]
            public string SuperEmpId { get; set; }

            [NameInMap("superName")]
            [Validation(Required=false)]
            public string SuperName { get; set; }

        }

        [NameInMap("corpId")]
        [Validation(Required=false)]
        public string CorpId { get; set; }

    }

}
