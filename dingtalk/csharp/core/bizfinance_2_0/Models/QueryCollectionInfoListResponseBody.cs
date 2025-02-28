// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkbizfinance_2_0.Models
{
    public class QueryCollectionInfoListResponseBody : TeaModel {
        [NameInMap("collectionInfoList")]
        [Validation(Required=false)]
        public List<QueryCollectionInfoListResponseBodyCollectionInfoList> CollectionInfoList { get; set; }
        public class QueryCollectionInfoListResponseBodyCollectionInfoList : TeaModel {
            [NameInMap("accountHolderName")]
            [Validation(Required=false)]
            public string AccountHolderName { get; set; }

            [NameInMap("alipayLogonId")]
            [Validation(Required=false)]
            public string AlipayLogonId { get; set; }

            [NameInMap("auditStatus")]
            [Validation(Required=false)]
            public string AuditStatus { get; set; }

            [NameInMap("certNo")]
            [Validation(Required=false)]
            public string CertNo { get; set; }

            [NameInMap("collectionInfoId")]
            [Validation(Required=false)]
            public string CollectionInfoId { get; set; }

            [NameInMap("failReason")]
            [Validation(Required=false)]
            public string FailReason { get; set; }

            [NameInMap("gmtAudit")]
            [Validation(Required=false)]
            public long? GmtAudit { get; set; }

            [NameInMap("merchantName")]
            [Validation(Required=false)]
            public string MerchantName { get; set; }

            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

    }

}
