// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcrm_1_0.Models
{
    public class QueryAllCustomerResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public QueryAllCustomerResponseBodyResult Result { get; set; }
        public class QueryAllCustomerResponseBodyResult : TeaModel {
            [NameInMap("maxResults")]
            [Validation(Required=false)]
            public long? MaxResults { get; set; }

            [NameInMap("nextToken")]
            [Validation(Required=false)]
            public string NextToken { get; set; }

            [NameInMap("values")]
            [Validation(Required=false)]
            public List<QueryAllCustomerResponseBodyResultValues> Values { get; set; }
            public class QueryAllCustomerResponseBodyResultValues : TeaModel {
                [NameInMap("createTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                [NameInMap("creatorNick")]
                [Validation(Required=false)]
                public string CreatorNick { get; set; }

                [NameInMap("creatorUserId")]
                [Validation(Required=false)]
                public string CreatorUserId { get; set; }

                [NameInMap("data")]
                [Validation(Required=false)]
                public Dictionary<string, object> Data { get; set; }

                [NameInMap("extendData")]
                [Validation(Required=false)]
                public Dictionary<string, object> ExtendData { get; set; }

                [NameInMap("instanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                [NameInMap("modifyTime")]
                [Validation(Required=false)]
                public string ModifyTime { get; set; }

                [NameInMap("objectType")]
                [Validation(Required=false)]
                public string ObjectType { get; set; }

                [NameInMap("permission")]
                [Validation(Required=false)]
                public QueryAllCustomerResponseBodyResultValuesPermission Permission { get; set; }
                public class QueryAllCustomerResponseBodyResultValuesPermission : TeaModel {
                    [NameInMap("ownerStaffIds")]
                    [Validation(Required=false)]
                    public List<string> OwnerStaffIds { get; set; }

                    [NameInMap("participantStaffIds")]
                    [Validation(Required=false)]
                    public List<string> ParticipantStaffIds { get; set; }

                }

                [NameInMap("processInstanceStatus")]
                [Validation(Required=false)]
                public string ProcessInstanceStatus { get; set; }

                [NameInMap("processOutResult")]
                [Validation(Required=false)]
                public string ProcessOutResult { get; set; }

            }

        }

    }

}
