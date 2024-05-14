// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkindustry_1_0.Models
{
    public class IndustryManufactureLabourCostResponseBody : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("hasMore")]
        [Validation(Required=false)]
        public bool? HasMore { get; set; }

        [NameInMap("list")]
        [Validation(Required=false)]
        public List<IndustryManufactureLabourCostResponseBodyList> List { get; set; }
        public class IndustryManufactureLabourCostResponseBodyList : TeaModel {
            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("corpId")]
            [Validation(Required=false)]
            public string CorpId { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("ext")]
            [Validation(Required=false)]
            public string Ext { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("gmtCreate")]
            [Validation(Required=false)]
            public long? GmtCreate { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("gmtModified")]
            [Validation(Required=false)]
            public long? GmtModified { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("instanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("labourCostName")]
            [Validation(Required=false)]
            public string LabourCostName { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("labourCostNo")]
            [Validation(Required=false)]
            public string LabourCostNo { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("materialName")]
            [Validation(Required=false)]
            public string MaterialName { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("materialNo")]
            [Validation(Required=false)]
            public string MaterialNo { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("processCode")]
            [Validation(Required=false)]
            public string ProcessCode { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("processName")]
            [Validation(Required=false)]
            public string ProcessName { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("processNo")]
            [Validation(Required=false)]
            public string ProcessNo { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("qualifiedPrice")]
            [Validation(Required=false)]
            public float? QualifiedPrice { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("unQualifiedInfo")]
            [Validation(Required=false)]
            public string UnQualifiedInfo { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("unQualifiedPrice1")]
            [Validation(Required=false)]
            public float? UnQualifiedPrice1 { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("unQualifiedPrice2")]
            [Validation(Required=false)]
            public float? UnQualifiedPrice2 { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("unQualifiedReason1")]
            [Validation(Required=false)]
            public string UnQualifiedReason1 { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("unQualifiedReason2")]
            [Validation(Required=false)]
            public string UnQualifiedReason2 { get; set; }

        }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("nextCursor")]
        [Validation(Required=false)]
        public long? NextCursor { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
