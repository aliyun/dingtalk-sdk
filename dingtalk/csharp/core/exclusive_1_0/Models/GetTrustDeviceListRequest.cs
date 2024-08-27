// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkexclusive_1_0.Models
{
    public class GetTrustDeviceListRequest : TeaModel {
        [NameInMap("gmtCreateEnd")]
        [Validation(Required=false)]
        public long? GmtCreateEnd { get; set; }

        [NameInMap("gmtCreateStart")]
        [Validation(Required=false)]
        public long? GmtCreateStart { get; set; }

        [NameInMap("gmtModifiedEnd")]
        [Validation(Required=false)]
        public long? GmtModifiedEnd { get; set; }

        [NameInMap("gmtModifiedStart")]
        [Validation(Required=false)]
        public long? GmtModifiedStart { get; set; }

        [NameInMap("macAddress")]
        [Validation(Required=false)]
        public string MacAddress { get; set; }

        [NameInMap("pageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        [NameInMap("platform")]
        [Validation(Required=false)]
        public string Platform { get; set; }

        [NameInMap("status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

        [NameInMap("userIds")]
        [Validation(Required=false)]
        public List<string> UserIds { get; set; }

    }

}
