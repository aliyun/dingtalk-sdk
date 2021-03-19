// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcrm_1_0.Models
{
    public class GetOfficialAccountContactsRequest : TeaModel {
        [NameInMap("context")]
        [Validation(Required=false)]
        public GetOfficialAccountContactsRequestContext Context { get; set; }
        public class GetOfficialAccountContactsRequestContext : TeaModel {
            [NameInMap("dingIsvOrgId")]
            [Validation(Required=false)]
            public long? DingIsvOrgId { get; set; }
            [NameInMap("dingOrgId")]
            [Validation(Required=false)]
            public long? DingOrgId { get; set; }
            [NameInMap("dingSuiteKey")]
            [Validation(Required=false)]
            public string DingSuiteKey { get; set; }
            [NameInMap("dingCorpId")]
            [Validation(Required=false)]
            public string DingCorpId { get; set; }
            [NameInMap("dingTokenGrantType")]
            [Validation(Required=false)]
            public long? DingTokenGrantType { get; set; }
        };

        /// <summary>
        /// 取数游标，第一次传0
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// 分页大小，最大不超过10
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public long? MaxResults { get; set; }

    }

}
