// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkhrm_1_0.Models
{
    public class MasterDataQueryRequest : TeaModel {
        [NameInMap("bizUK")]
        [Validation(Required=false)]
        public string BizUK { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public int? NextToken { get; set; }

        [NameInMap("optUserId")]
        [Validation(Required=false)]
        public string OptUserId { get; set; }

        [NameInMap("queryParams")]
        [Validation(Required=false)]
        public List<MasterDataQueryRequestQueryParams> QueryParams { get; set; }
        public class MasterDataQueryRequestQueryParams : TeaModel {
            [NameInMap("conditionList")]
            [Validation(Required=false)]
            public List<MasterDataQueryRequestQueryParamsConditionList> ConditionList { get; set; }
            public class MasterDataQueryRequestQueryParamsConditionList : TeaModel {
                [NameInMap("operate")]
                [Validation(Required=false)]
                public string Operate { get; set; }

                [NameInMap("value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            [NameInMap("fieldCode")]
            [Validation(Required=false)]
            public string FieldCode { get; set; }

            [NameInMap("joinType")]
            [Validation(Required=false)]
            public string JoinType { get; set; }

        }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("relationIds")]
        [Validation(Required=false)]
        public List<string> RelationIds { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("scopeCode")]
        [Validation(Required=false)]
        public string ScopeCode { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("tenantId")]
        [Validation(Required=false)]
        public long? TenantId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("viewEntityCode")]
        [Validation(Required=false)]
        public string ViewEntityCode { get; set; }

    }

}
