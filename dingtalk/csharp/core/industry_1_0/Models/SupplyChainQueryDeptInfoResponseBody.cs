// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkindustry_1_0.Models
{
    public class SupplyChainQueryDeptInfoResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public SupplyChainQueryDeptInfoResponseBodyResult Result { get; set; }
        public class SupplyChainQueryDeptInfoResponseBodyResult : TeaModel {
            [NameInMap("deptId")]
            [Validation(Required=false)]
            public long? DeptId { get; set; }

            [NameInMap("deptType")]
            [Validation(Required=false)]
            public string DeptType { get; set; }

            [NameInMap("hasSubDept")]
            [Validation(Required=false)]
            public bool? HasSubDept { get; set; }

            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("partnerNumber")]
            [Validation(Required=false)]
            public string PartnerNumber { get; set; }

            [NameInMap("partnerTypeInfoList")]
            [Validation(Required=false)]
            public List<SupplyChainQueryDeptInfoResponseBodyResultPartnerTypeInfoList> PartnerTypeInfoList { get; set; }
            public class SupplyChainQueryDeptInfoResponseBodyResultPartnerTypeInfoList : TeaModel {
                [NameInMap("id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("superId")]
                [Validation(Required=false)]
                public long? SuperId { get; set; }

                [NameInMap("superName")]
                [Validation(Required=false)]
                public string SuperName { get; set; }

            }

            [NameInMap("superId")]
            [Validation(Required=false)]
            public long? SuperId { get; set; }

        }

    }

}
