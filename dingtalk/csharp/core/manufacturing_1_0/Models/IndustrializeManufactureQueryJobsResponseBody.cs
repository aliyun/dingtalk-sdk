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
            [NameInMap("corpId")]
            [Validation(Required=false)]
            public string CorpId { get; set; }

            [NameInMap("gmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            [NameInMap("gmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            [NameInMap("id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            [NameInMap("instNo")]
            [Validation(Required=false)]
            public string InstNo { get; set; }

            [NameInMap("isBatchJob")]
            [Validation(Required=false)]
            public string IsBatchJob { get; set; }

            [NameInMap("manufactureDate")]
            [Validation(Required=false)]
            public string ManufactureDate { get; set; }

            [NameInMap("manufactureDay")]
            [Validation(Required=false)]
            public string ManufactureDay { get; set; }

            [NameInMap("mesAppKey")]
            [Validation(Required=false)]
            public string MesAppKey { get; set; }

            [NameInMap("processName")]
            [Validation(Required=false)]
            public string ProcessName { get; set; }

            [NameInMap("qualifiedQuantity")]
            [Validation(Required=false)]
            public string QualifiedQuantity { get; set; }

            [NameInMap("scrappedQuantity")]
            [Validation(Required=false)]
            public string ScrappedQuantity { get; set; }

            [NameInMap("unitPrice")]
            [Validation(Required=false)]
            public string UnitPrice { get; set; }

            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

            [NameInMap("userIdList")]
            [Validation(Required=false)]
            public string UserIdList { get; set; }

            [NameInMap("userNameList")]
            [Validation(Required=false)]
            public string UserNameList { get; set; }

            [NameInMap("uuid")]
            [Validation(Required=false)]
            public string Uuid { get; set; }

        }

        [NameInMap("httpCode")]
        [Validation(Required=false)]
        public string HttpCode { get; set; }

    }

}
