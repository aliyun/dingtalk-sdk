// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkworkflow_1_0.Models
{
    public class PremiumGetFormInstancesResponseBody : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public PremiumGetFormInstancesResponseBodyResult Result { get; set; }
        public class PremiumGetFormInstancesResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("hasMore")]
            [Validation(Required=false)]
            public bool? HasMore { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("maxResults")]
            [Validation(Required=false)]
            public long? MaxResults { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("nextToken")]
            [Validation(Required=false)]
            public string NextToken { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("values")]
            [Validation(Required=false)]
            public List<PremiumGetFormInstancesResponseBodyResultValues> Values { get; set; }
            public class PremiumGetFormInstancesResponseBodyResultValues : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>SWAPP-abcd-example</para>
                /// </summary>
                [NameInMap("appUuid")]
                [Validation(Required=false)]
                public string AppUuid { get; set; }

                [NameInMap("attributes")]
                [Validation(Required=false)]
                public Dictionary<string, object> Attributes { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1635151039000</para>
                /// </summary>
                [NameInMap("createTimestamp")]
                [Validation(Required=false)]
                public long? CreateTimestamp { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>30314512</para>
                /// </summary>
                [NameInMap("creator")]
                [Validation(Required=false)]
                public string Creator { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>PROC-abcd-example</para>
                /// </summary>
                [NameInMap("formCode")]
                [Validation(Required=false)]
                public string FormCode { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// </summary>
                [NameInMap("formInstDataList")]
                [Validation(Required=false)]
                public List<PremiumGetFormInstancesResponseBodyResultValuesFormInstDataList> FormInstDataList { get; set; }
                public class PremiumGetFormInstancesResponseBodyResultValuesFormInstDataList : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>staff_name</para>
                    /// </summary>
                    [NameInMap("bizAlias")]
                    [Validation(Required=false)]
                    public string BizAlias { get; set; }

                    /// <summary>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>具体参见审批控件列表</para>
                    /// </summary>
                    [NameInMap("componentType")]
                    [Validation(Required=false)]
                    public string ComponentType { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>{&quot;key&quot;:&quot;value}</para>
                    /// </summary>
                    [NameInMap("extendValue")]
                    [Validation(Required=false)]
                    public string ExtendValue { get; set; }

                    /// <summary>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>TextField-abcdefg</para>
                    /// </summary>
                    [NameInMap("key")]
                    [Validation(Required=false)]
                    public string Key { get; set; }

                    /// <summary>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>员工姓名</para>
                    /// </summary>
                    [NameInMap("label")]
                    [Validation(Required=false)]
                    public string Label { get; set; }

                    /// <summary>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>张三</para>
                    /// </summary>
                    [NameInMap("value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>abcd-eaf-acde12f</para>
                /// </summary>
                [NameInMap("formInstanceId")]
                [Validation(Required=false)]
                public string FormInstanceId { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>032142312</para>
                /// </summary>
                [NameInMap("modifier")]
                [Validation(Required=false)]
                public string Modifier { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1635151039000</para>
                /// </summary>
                [NameInMap("modifyTimestamp")]
                [Validation(Required=false)]
                public long? ModifyTimestamp { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>abcd</para>
                /// </summary>
                [NameInMap("outBizCode")]
                [Validation(Required=false)]
                public string OutBizCode { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>323</para>
                /// </summary>
                [NameInMap("outInstanceId")]
                [Validation(Required=false)]
                public string OutInstanceId { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>xxx提交的数据</para>
                /// </summary>
                [NameInMap("title")]
                [Validation(Required=false)]
                public string Title { get; set; }

            }

        }

    }

}
