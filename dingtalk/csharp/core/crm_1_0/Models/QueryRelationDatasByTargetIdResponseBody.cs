// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcrm_1_0.Models
{
    public class QueryRelationDatasByTargetIdResponseBody : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("relations")]
        [Validation(Required=false)]
        public List<QueryRelationDatasByTargetIdResponseBodyRelations> Relations { get; set; }
        public class QueryRelationDatasByTargetIdResponseBodyRelations : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("bizDataList")]
            [Validation(Required=false)]
            public List<QueryRelationDatasByTargetIdResponseBodyRelationsBizDataList> BizDataList { get; set; }
            public class QueryRelationDatasByTargetIdResponseBodyRelationsBizDataList : TeaModel {
                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{}</para>
                /// </summary>
                [NameInMap("extendValue")]
                [Validation(Required=false)]
                public string ExtendValue { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>customer_name</para>
                /// </summary>
                [NameInMap("key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>abc123</para>
                /// </summary>
                [NameInMap("value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("openConversationIds")]
            [Validation(Required=false)]
            public List<string> OpenConversationIds { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>abc123</para>
            /// </summary>
            [NameInMap("relationId")]
            [Validation(Required=false)]
            public string RelationId { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>abc123</para>
            /// </summary>
            [NameInMap("relationType")]
            [Validation(Required=false)]
            public string RelationType { get; set; }

        }

    }

}
