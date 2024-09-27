// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcrm_1_0.Models
{
    public class BatchAddRelationDatasRequest : TeaModel {
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
        public List<BatchAddRelationDatasRequestRelationList> RelationList { get; set; }
        public class BatchAddRelationDatasRequestRelationList : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("bizDataList")]
            [Validation(Required=false)]
            public List<BatchAddRelationDatasRequestRelationListBizDataList> BizDataList { get; set; }
            public class BatchAddRelationDatasRequestRelationListBizDataList : TeaModel {
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

            [NameInMap("relationPermissionDTO")]
            [Validation(Required=false)]
            public BatchAddRelationDatasRequestRelationListRelationPermissionDTO RelationPermissionDTO { get; set; }
            public class BatchAddRelationDatasRequestRelationListRelationPermissionDTO : TeaModel {
                [NameInMap("participantUserIds")]
                [Validation(Required=false)]
                public List<string> ParticipantUserIds { get; set; }

                [NameInMap("principalUserIds")]
                [Validation(Required=false)]
                public List<string> PrincipalUserIds { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ddsf3234234</para>
            /// </summary>
            [NameInMap("sourceDataId")]
            [Validation(Required=false)]
            public string SourceDataId { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>crm_customer</para>
        /// </summary>
        [NameInMap("relationType")]
        [Validation(Required=false)]
        public string RelationType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("skipDuplicateCheck")]
        [Validation(Required=false)]
        public bool? SkipDuplicateCheck { get; set; }

    }

}
