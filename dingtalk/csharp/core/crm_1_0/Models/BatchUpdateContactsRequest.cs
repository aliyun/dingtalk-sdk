// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcrm_1_0.Models
{
    public class BatchUpdateContactsRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>manager021a</para>
        /// </summary>
        [NameInMap("operatorUserId")]
        [Validation(Required=false)]
        public string OperatorUserId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("relationList")]
        [Validation(Required=false)]
        public List<BatchUpdateContactsRequestRelationList> RelationList { get; set; }
        public class BatchUpdateContactsRequestRelationList : TeaModel {
            [NameInMap("bizDataList")]
            [Validation(Required=false)]
            public List<BatchUpdateContactsRequestRelationListBizDataList> BizDataList { get; set; }
            public class BatchUpdateContactsRequestRelationListBizDataList : TeaModel {
                /// <summary>
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
                /// <para>TextField_71U51A</para>
                /// </summary>
                [NameInMap("key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>XX有限公司</para>
                /// </summary>
                [NameInMap("value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <b>if can be null:</b>
            /// <c>true</c>
            /// </summary>
            [NameInMap("bizExtMap")]
            [Validation(Required=false)]
            public Dictionary<string, string> BizExtMap { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>fasdg8i814-0afsd</para>
            /// </summary>
            [NameInMap("relationId")]
            [Validation(Required=false)]
            public string RelationId { get; set; }

        }

    }

}
