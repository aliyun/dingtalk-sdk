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
            [NameInMap("bizCategoryId")]
            [Validation(Required=false)]
            public string BizCategoryId { get; set; }
            [NameInMap("bizType")]
            [Validation(Required=false)]
            public string BizType { get; set; }
            [NameInMap("commentConf")]
            [Validation(Required=false)]
            public GetProcessConfigResponseBodyResultCommentConf CommentConf { get; set; }
            public class GetProcessConfigResponseBodyResultCommentConf : TeaModel {
                /// <summary>
                /// 提示内容
                /// </summary>
                [NameInMap("commentDescription")]
                [Validation(Required=false)]
                public string CommentDescription { get; set; }

                /// <summary>
                /// 评论对发起人不可见
                /// </summary>
                [NameInMap("commentHiddenForProposer")]
                [Validation(Required=false)]
                public bool? CommentHiddenForProposer { get; set; }

                /// <summary>
                /// 评论必填
                /// </summary>
                [NameInMap("commentRequired")]
                [Validation(Required=false)]
                public bool? CommentRequired { get; set; }

            }
            [NameInMap("duplicateRemoval")]
            [Validation(Required=false)]
            public string DuplicateRemoval { get; set; }
            [NameInMap("handSignConf")]
            [Validation(Required=false)]
            public GetProcessConfigResponseBodyResultHandSignConf HandSignConf { get; set; }
            public class GetProcessConfigResponseBodyResultHandSignConf : TeaModel {
                /// <summary>
                /// 开启手写签名
                /// </summary>
                [NameInMap("handSignEnable")]
                [Validation(Required=false)]
                public bool? HandSignEnable { get; set; }

                /// <summary>
                /// 是否使用上次签名
                /// </summary>
                [NameInMap("resignEnable")]
                [Validation(Required=false)]
                public bool? ResignEnable { get; set; }

            }
            [NameInMap("managers")]
            [Validation(Required=false)]
            public List<string> Managers { get; set; }
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }
            [NameInMap("processAppType")]
            [Validation(Required=false)]
            public bool? ProcessAppType { get; set; }
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
                /// <summary>
                /// 是否允许代提交
                /// </summary>
                [NameInMap("enable")]
                [Validation(Required=false)]
                public bool? Enable { get; set; }

                /// <summary>
                /// 代提交人
                /// </summary>
                [NameInMap("submitterList")]
                [Validation(Required=false)]
                public List<GetProcessConfigResponseBodyResultSubstituteSubmitConfSubmitterList> SubmitterList { get; set; }
                public class GetProcessConfigResponseBodyResultSubstituteSubmitConfSubmitterList : TeaModel {
                    /// <summary>
                    /// 名称
                    /// </summary>
                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// 类型
                    /// </summary>
                    [NameInMap("type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                    /// <summary>
                    /// 员工staffId/部门id
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
                /// 规则表达式
                /// </summary>
                [NameInMap("express")]
                [Validation(Required=false)]
                public string Express { get; set; }

                /// <summary>
                /// 规则类型
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public int? Type { get; set; }

            }
            [NameInMap("visibility")]
            [Validation(Required=false)]
            public List<GetProcessConfigResponseBodyResultVisibility> Visibility { get; set; }
            public class GetProcessConfigResponseBodyResultVisibility : TeaModel {
                public int? Type { get; set; }
                public string Value { get; set; }
            }
        };

    }

}
