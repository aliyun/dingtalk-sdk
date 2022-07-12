// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcrm_1_0.Models
{
    public class QueryAllCustomerResponseBody : TeaModel {
        /// <summary>
        /// 分页结果
        /// </summary>
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
                public string CreateTime { get; set; }
                public string CreatorNick { get; set; }
                public string CreatorUserId { get; set; }
                public Dictionary<string, string> Data { get; set; }
                public Dictionary<string, string> ExtendData { get; set; }
                public string InstanceId { get; set; }
                public string ModifyTime { get; set; }
                public string ObjectType { get; set; }
                public QueryAllCustomerResponseBodyResultValuesPermission Permission { get; set; }
                public class QueryAllCustomerResponseBodyResultValuesPermission : TeaModel {
                    /// <summary>
                    /// 负责人用户ID列表
                    /// </summary>
                    [NameInMap("ownerStaffIds")]
                    [Validation(Required=false)]
                    public List<string> OwnerStaffIds { get; set; }

                    /// <summary>
                    /// 协同人用户ID列表
                    /// </summary>
                    [NameInMap("participantStaffIds")]
                    [Validation(Required=false)]
                    public List<string> ParticipantStaffIds { get; set; }

                }
                public string ProcessInstanceStatus { get; set; }
                public string ProcessOutResult { get; set; }
            }
        };

    }

}
