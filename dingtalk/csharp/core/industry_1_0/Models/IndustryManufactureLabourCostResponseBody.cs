// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkindustry_1_0.Models
{
    public class IndustryManufactureLabourCostResponseBody : TeaModel {
        [NameInMap("hasMore")]
        [Validation(Required=false)]
        public bool? HasMore { get; set; }

        [NameInMap("list")]
        [Validation(Required=false)]
        public List<IndustryManufactureLabourCostResponseBodyList> List { get; set; }
        public class IndustryManufactureLabourCostResponseBodyList : TeaModel {
            [NameInMap("corpId")]
            [Validation(Required=false)]
            public string CorpId { get; set; }

            [NameInMap("ext")]
            [Validation(Required=false)]
            public string Ext { get; set; }

            [NameInMap("gmtCreate")]
            [Validation(Required=false)]
            public long? GmtCreate { get; set; }

            [NameInMap("gmtModified")]
            [Validation(Required=false)]
            public long? GmtModified { get; set; }

            [NameInMap("instanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            [NameInMap("labourCostName")]
            [Validation(Required=false)]
            public string LabourCostName { get; set; }

            [NameInMap("labourCostNo")]
            [Validation(Required=false)]
            public string LabourCostNo { get; set; }

            [NameInMap("materialName")]
            [Validation(Required=false)]
            public string MaterialName { get; set; }

            [NameInMap("materialNo")]
            [Validation(Required=false)]
            public string MaterialNo { get; set; }

            [NameInMap("processCode")]
            [Validation(Required=false)]
            public string ProcessCode { get; set; }

            [NameInMap("processName")]
            [Validation(Required=false)]
            public string ProcessName { get; set; }

            [NameInMap("processNo")]
            [Validation(Required=false)]
            public string ProcessNo { get; set; }

            [NameInMap("qualifiedPrice")]
            [Validation(Required=false)]
            public float? QualifiedPrice { get; set; }

            [NameInMap("unQualifiedInfo")]
            [Validation(Required=false)]
            public string UnQualifiedInfo { get; set; }

            [NameInMap("unQualifiedPrice1")]
            [Validation(Required=false)]
            public float? UnQualifiedPrice1 { get; set; }

            [NameInMap("unQualifiedPrice2")]
            [Validation(Required=false)]
            public float? UnQualifiedPrice2 { get; set; }

            [NameInMap("unQualifiedReason1")]
            [Validation(Required=false)]
            public string UnQualifiedReason1 { get; set; }

            [NameInMap("unQualifiedReason2")]
            [Validation(Required=false)]
            public string UnQualifiedReason2 { get; set; }

        }

        [NameInMap("nextCursor")]
        [Validation(Required=false)]
        public long? NextCursor { get; set; }

        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
