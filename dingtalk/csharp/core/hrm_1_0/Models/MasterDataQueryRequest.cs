// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkhrm_1_0.Models
{
    public class MasterDataQueryRequest : TeaModel {
        /// <summary>
        /// 数据唯一键
        /// </summary>
        [NameInMap("bizUK")]
        [Validation(Required=false)]
        public string BizUK { get; set; }

        /// <summary>
        /// 分页查询每页数据条数
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// 分页查询的游标
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public int? NextToken { get; set; }

        /// <summary>
        /// 当前操作人userId
        /// </summary>
        [NameInMap("optUserId")]
        [Validation(Required=false)]
        public string OptUserId { get; set; }

        /// <summary>
        /// 其他查询条件
        /// </summary>
        [NameInMap("queryParams")]
        [Validation(Required=false)]
        public List<MasterDataQueryRequestQueryParams> QueryParams { get; set; }
        public class MasterDataQueryRequestQueryParams : TeaModel {
            /// <summary>
            /// 需要筛选的字段
            /// </summary>
            [NameInMap("fieldCode")]
            [Validation(Required=false)]
            public string FieldCode { get; set; }

            /// <summary>
            /// 筛选条件连接类型
            /// </summary>
            [NameInMap("joinType")]
            [Validation(Required=false)]
            public string JoinType { get; set; }

            /// <summary>
            /// 筛选条件
            /// </summary>
            [NameInMap("conditionList")]
            [Validation(Required=false)]
            public List<MasterDataQueryRequestQueryParamsConditionList> ConditionList { get; set; }
            public class MasterDataQueryRequestQueryParamsConditionList : TeaModel {
                /// <summary>
                /// 字段关系符
                /// </summary>
                [NameInMap("operate")]
                [Validation(Required=false)]
                public string Operate { get; set; }

                /// <summary>
                /// 操作值
                /// </summary>
                [NameInMap("value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

        }

        /// <summary>
        /// 关联id列表，一般为userId
        /// </summary>
        [NameInMap("relationIds")]
        [Validation(Required=false)]
        public List<string> RelationIds { get; set; }

        /// <summary>
        /// 领域code 由钉钉分配
        /// </summary>
        [NameInMap("scopeCode")]
        [Validation(Required=false)]
        public string ScopeCode { get; set; }

        /// <summary>
        /// 数据生产方的租户id，由钉钉分配
        /// </summary>
        [NameInMap("tenantId")]
        [Validation(Required=false)]
        public long? TenantId { get; set; }

        /// <summary>
        /// 实体code
        /// </summary>
        [NameInMap("viewEntityCode")]
        [Validation(Required=false)]
        public string ViewEntityCode { get; set; }

    }

}
