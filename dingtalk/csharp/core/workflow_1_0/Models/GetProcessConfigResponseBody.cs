// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkworkflow_1_0.Models
{
    public class GetProcessConfigResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public GetProcessConfigResponseBodyResult Result { get; set; }
        public class GetProcessConfigResponseBodyResult : TeaModel {
            [NameInMap("abstractGenRule")]
            [Validation(Required=false)]
            public List<string> AbstractGenRule { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>{&quot;sid_instStart&quot;:[{&quot;fieldId&quot;:&quot;TextField-K2AD4O5B&quot;,&quot;fieldBehavior&quot;:&quot;HIDDEN&quot;,&quot;componentName&quot;:&quot;TextField&quot;,&quot;disableBehaviors&quot;:[]}],&quot;1918_5cd3&quot;:[{&quot;fieldId&quot;:&quot;TextField-K2AD4O5B&quot;,&quot;fieldBehavior&quot;:&quot;HIDDEN&quot;,&quot;componentName&quot;:&quot;TextField&quot;,&quot;disableBehaviors&quot;:[]}],&quot;d01c_a677&quot;:[{&quot;fieldId&quot;:&quot;TextField-K2AD4O5B&quot;,&quot;fieldBehavior&quot;:&quot;NORMAL&quot;,&quot;componentName&quot;:&quot;TextField&quot;,&quot;disableBehaviors&quot;:[]}]}</para>
            /// </summary>
            [NameInMap("activityAuth")]
            [Validation(Required=false)]
            public string ActivityAuth { get; set; }

            [NameInMap("allowRevoke")]
            [Validation(Required=false)]
            public bool? AllowRevoke { get; set; }

            [NameInMap("appendEnable")]
            [Validation(Required=false)]
            public bool? AppendEnable { get; set; }

            [NameInMap("autoExecuteOriginatorTasks")]
            [Validation(Required=false)]
            public bool? AutoExecuteOriginatorTasks { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>alitrip.business</para>
            /// </summary>
            [NameInMap("bizCategoryId")]
            [Validation(Required=false)]
            public string BizCategoryId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>crm_customer</para>
            /// </summary>
            [NameInMap("bizType")]
            [Validation(Required=false)]
            public string BizType { get; set; }

            [NameInMap("commentConf")]
            [Validation(Required=false)]
            public GetProcessConfigResponseBodyResultCommentConf CommentConf { get; set; }
            public class GetProcessConfigResponseBodyResultCommentConf : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>评论描述</para>
                /// </summary>
                [NameInMap("commentDescription")]
                [Validation(Required=false)]
                public string CommentDescription { get; set; }

                [NameInMap("commentHiddenForProposer")]
                [Validation(Required=false)]
                public bool? CommentHiddenForProposer { get; set; }

                [NameInMap("commentRequired")]
                [Validation(Required=false)]
                public bool? CommentRequired { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>continuousFirst</para>
            /// </summary>
            [NameInMap("duplicateRemoval")]
            [Validation(Required=false)]
            public string DuplicateRemoval { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>{&quot;items&quot;:[]}</para>
            /// </summary>
            [NameInMap("formSchema")]
            [Validation(Required=false)]
            public string FormSchema { get; set; }

            [NameInMap("handSignConf")]
            [Validation(Required=false)]
            public GetProcessConfigResponseBodyResultHandSignConf HandSignConf { get; set; }
            public class GetProcessConfigResponseBodyResultHandSignConf : TeaModel {
                [NameInMap("handSignEnable")]
                [Validation(Required=false)]
                public bool? HandSignEnable { get; set; }

                [NameInMap("resignEnable")]
                [Validation(Required=false)]
                public bool? ResignEnable { get; set; }

            }

            [NameInMap("managers")]
            [Validation(Required=false)]
            public List<string> Managers { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>模板名称</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("processAppType")]
            [Validation(Required=false)]
            public bool? ProcessAppType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>{&quot;type&quot;:&quot;&quot;,&quot;properties&quot;:{},&quot;childNode&quot;:{}}</para>
            /// </summary>
            [NameInMap("processConfig")]
            [Validation(Required=false)]
            public string ProcessConfig { get; set; }

            [NameInMap("staticProc")]
            [Validation(Required=false)]
            public bool? StaticProc { get; set; }

            [NameInMap("substituteSubmitConf")]
            [Validation(Required=false)]
            public GetProcessConfigResponseBodyResultSubstituteSubmitConf SubstituteSubmitConf { get; set; }
            public class GetProcessConfigResponseBodyResultSubstituteSubmitConf : TeaModel {
                [NameInMap("enable")]
                [Validation(Required=false)]
                public bool? Enable { get; set; }

                [NameInMap("submitterList")]
                [Validation(Required=false)]
                public List<GetProcessConfigResponseBodyResultSubstituteSubmitConfSubmitterList> SubmitterList { get; set; }
                public class GetProcessConfigResponseBodyResultSubstituteSubmitConfSubmitterList : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>钉三多</para>
                    /// </summary>
                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>approval</para>
                    /// </summary>
                    [NameInMap("type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>manager1234</para>
                    /// </summary>
                    [NameInMap("value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

            }

            [NameInMap("titleGenRule")]
            [Validation(Required=false)]
            public GetProcessConfigResponseBodyResultTitleGenRule TitleGenRule { get; set; }
            public class GetProcessConfigResponseBodyResultTitleGenRule : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>#{originator}#{formName}#{createTime}</para>
                /// </summary>
                [NameInMap("express")]
                [Validation(Required=false)]
                public string Express { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public int? Type { get; set; }

            }

            [NameInMap("visibility")]
            [Validation(Required=false)]
            public List<GetProcessConfigResponseBodyResultVisibility> Visibility { get; set; }
            public class GetProcessConfigResponseBodyResultVisibility : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public int? Type { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>manager345</para>
                /// </summary>
                [NameInMap("value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

        }

    }

}
