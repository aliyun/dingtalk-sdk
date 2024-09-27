// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkhrm_1_0.Models
{
    public class MasterDataQueryRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>uk_12123</para>
        /// </summary>
        [NameInMap("bizUK")]
        [Validation(Required=false)]
        public string BizUK { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public int? NextToken { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>admin1234</para>
        /// </summary>
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
                /// <summary>
                /// <b>Example:</b>
                /// <para>EQUAL</para>
                /// </summary>
                [NameInMap("operate")]
                [Validation(Required=false)]
                public string Operate { get; set; }

                [NameInMap("value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>performance_code</para>
            /// </summary>
            [NameInMap("fieldCode")]
            [Validation(Required=false)]
            public string FieldCode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>AND</para>
            /// </summary>
            [NameInMap("joinType")]
            [Validation(Required=false)]
            public string JoinType { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("relationIds")]
        [Validation(Required=false)]
        public List<string> RelationIds { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PERFORMANCE</para>
        /// </summary>
        [NameInMap("scopeCode")]
        [Validation(Required=false)]
        public string ScopeCode { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("tenantId")]
        [Validation(Required=false)]
        public long? TenantId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>base</para>
        /// </summary>
        [NameInMap("viewEntityCode")]
        [Validation(Required=false)]
        public string ViewEntityCode { get; set; }

    }

}
