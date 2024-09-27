// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcrm_1_0.Models
{
    public class FindTargetRelatedFollowRecordsResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public FindTargetRelatedFollowRecordsResponseBodyResult Result { get; set; }
        public class FindTargetRelatedFollowRecordsResponseBodyResult : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("hasMore")]
            [Validation(Required=false)]
            public bool? HasMore { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1000</para>
            /// </summary>
            [NameInMap("nextToken")]
            [Validation(Required=false)]
            public string NextToken { get; set; }

            [NameInMap("resultList")]
            [Validation(Required=false)]
            public List<FindTargetRelatedFollowRecordsResponseBodyResultResultList> ResultList { get; set; }
            public class FindTargetRelatedFollowRecordsResponseBodyResultResultList : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>manager7617</para>
                /// </summary>
                [NameInMap("creatorUserId")]
                [Validation(Required=false)]
                public string CreatorUserId { get; set; }

                [NameInMap("followContent")]
                [Validation(Required=false)]
                public List<FindTargetRelatedFollowRecordsResponseBodyResultResultListFollowContent> FollowContent { get; set; }
                public class FindTargetRelatedFollowRecordsResponseBodyResultResultListFollowContent : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>follow_record_related_content</para>
                    /// </summary>
                    [NameInMap("bizAlias")]
                    [Validation(Required=false)]
                    public string BizAlias { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>扩展value</para>
                    /// </summary>
                    [NameInMap("extendValue")]
                    [Validation(Required=false)]
                    public string ExtendValue { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>TextareaField-K2U5UJAF</para>
                    /// </summary>
                    [NameInMap("key")]
                    [Validation(Required=false)]
                    public string Key { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>重点跟进</para>
                    /// </summary>
                    [NameInMap("value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>customerId</para>
                /// </summary>
                [NameInMap("followTargetDataId")]
                [Validation(Required=false)]
                public string FollowTargetDataId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>customer</para>
                /// </summary>
                [NameInMap("followTargetType")]
                [Validation(Required=false)]
                public string FollowTargetType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1712629910168</para>
                /// </summary>
                [NameInMap("gmtCreateMilliseconds")]
                [Validation(Required=false)]
                public string GmtCreateMilliseconds { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1712629910168</para>
                /// </summary>
                [NameInMap("gmtModifiedMilliseconds")]
                [Validation(Required=false)]
                public string GmtModifiedMilliseconds { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>manager7617</para>
                /// </summary>
                [NameInMap("modifierUserId")]
                [Validation(Required=false)]
                public string ModifierUserId { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>_aFFogIuRrWlL3hLdvbb5w09951712629910</para>
                /// </summary>
                [NameInMap("recordInstId")]
                [Validation(Required=false)]
                public string RecordInstId { get; set; }

            }

        }

    }

}
