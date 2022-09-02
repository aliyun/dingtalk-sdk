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
            /// <summary>
            /// 分页大小
            /// </summary>
            [NameInMap("maxResults")]
            [Validation(Required=false)]
            public long? MaxResults { get; set; }

            /// <summary>
            /// 下一页的游标，为null则表示无数据
            /// </summary>
            [NameInMap("nextToken")]
            [Validation(Required=false)]
            public string NextToken { get; set; }

            /// <summary>
            /// 客户数据节点
            /// </summary>
            [NameInMap("values")]
            [Validation(Required=false)]
            public List<QueryAllCustomerResponseBodyResultValues> Values { get; set; }
            public class QueryAllCustomerResponseBodyResultValues : TeaModel {
                /// <summary>
                /// 记录创建时间
                /// </summary>
                [NameInMap("createTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// 创建记录的用户昵称
                /// </summary>
                [NameInMap("creatorNick")]
                [Validation(Required=false)]
                public string CreatorNick { get; set; }

                /// <summary>
                /// 创建记录的用户ID
                /// </summary>
                [NameInMap("creatorUserId")]
                [Validation(Required=false)]
                public string CreatorUserId { get; set; }

                /// <summary>
                /// 数据内容
                /// </summary>
                [NameInMap("data")]
                [Validation(Required=false)]
                public Dictionary<string, object> Data { get; set; }

                /// <summary>
                /// 扩展数据内容
                /// </summary>
                [NameInMap("extendData")]
                [Validation(Required=false)]
                public Dictionary<string, object> ExtendData { get; set; }

                /// <summary>
                /// 数据ID
                /// </summary>
                [NameInMap("instanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// 记录修改时间
                /// </summary>
                [NameInMap("modifyTime")]
                [Validation(Required=false)]
                public string ModifyTime { get; set; }

                /// <summary>
                /// 数据类型
                /// </summary>
                [NameInMap("objectType")]
                [Validation(Required=false)]
                public string ObjectType { get; set; }

                /// <summary>
                /// 数据权限信息
                /// </summary>
                [NameInMap("permission")]
                [Validation(Required=false)]
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

                /// <summary>
                /// 审批状态
                /// </summary>
                [NameInMap("processInstanceStatus")]
                [Validation(Required=false)]
                public string ProcessInstanceStatus { get; set; }

                /// <summary>
                /// 审批结果
                /// </summary>
                [NameInMap("processOutResult")]
                [Validation(Required=false)]
                public string ProcessOutResult { get; set; }

            }

        }

    }

}
