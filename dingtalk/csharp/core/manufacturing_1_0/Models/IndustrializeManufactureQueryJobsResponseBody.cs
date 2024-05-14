// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkmanufacturing_1_0.Models
{
    public class IndustrializeManufactureQueryJobsResponseBody : TeaModel {
        [NameInMap("content")]
        [Validation(Required=false)]
        public IndustrializeManufactureQueryJobsResponseBodyContent Content { get; set; }
        public class IndustrializeManufactureQueryJobsResponseBodyContent : TeaModel {
            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("corpId")]
            [Validation(Required=false)]
            public string CorpId { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("gmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("gmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("instNo")]
            [Validation(Required=false)]
            public string InstNo { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("isBatchJob")]
            [Validation(Required=false)]
            public string IsBatchJob { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("manufactureDate")]
            [Validation(Required=false)]
            public string ManufactureDate { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("manufactureDay")]
            [Validation(Required=false)]
            public string ManufactureDay { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("mesAppKey")]
            [Validation(Required=false)]
            public string MesAppKey { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("processName")]
            [Validation(Required=false)]
            public string ProcessName { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("qualifiedQuantity")]
            [Validation(Required=false)]
            public string QualifiedQuantity { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("scrappedQuantity")]
            [Validation(Required=false)]
            public string ScrappedQuantity { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("unitPrice")]
            [Validation(Required=false)]
            public string UnitPrice { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("userIdList")]
            [Validation(Required=false)]
            public string UserIdList { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("userNameList")]
            [Validation(Required=false)]
            public string UserNameList { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("uuid")]
            [Validation(Required=false)]
            public string Uuid { get; set; }

        }

        [NameInMap("httpCode")]
        [Validation(Required=false)]
        public string HttpCode { get; set; }

    }

}
