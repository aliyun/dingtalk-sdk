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
            /// <summary>
            /// 自定义摘要信息
            /// </summary>
            [NameInMap("abstractGenRule")]
            [Validation(Required=false)]
            public List<string> AbstractGenRule { get; set; }

            /// <summary>
            /// 表单节点权限
            /// </summary>
            [NameInMap("activityAuth")]
            [Validation(Required=false)]
            public string ActivityAuth { get; set; }

            /// <summary>
            /// 是否允许撤销
            /// </summary>
            [NameInMap("allowRevoke")]
            [Validation(Required=false)]
            public bool? AllowRevoke { get; set; }

            /// <summary>
            /// 是否允许加签
            /// </summary>
            [NameInMap("appendEnable")]
            [Validation(Required=false)]
            public bool? AppendEnable { get; set; }

            /// <summary>
            /// 如果审批人和发起人是同一个人，则去重
            /// </summary>
            [NameInMap("autoExecuteOriginatorTasks")]
            [Validation(Required=false)]
            public bool? AutoExecuteOriginatorTasks { get; set; }

            /// <summary>
            /// 流程表单业务标识
            /// </summary>
            [NameInMap("bizCategoryId")]
            [Validation(Required=false)]
            public string BizCategoryId { get; set; }

            /// <summary>
            /// 纯表单业务标识
            /// </summary>
            [NameInMap("bizType")]
            [Validation(Required=false)]
            public string BizType { get; set; }

            /// <summary>
            /// 评论配置
            /// </summary>
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

            /// <summary>
            /// 审批人自动去重
            /// </summary>
            [NameInMap("duplicateRemoval")]
            [Validation(Required=false)]
            public string DuplicateRemoval { get; set; }

            /// <summary>
            /// 表单配置
            /// </summary>
            [NameInMap("formSchema")]
            [Validation(Required=false)]
            public string FormSchema { get; set; }

            /// <summary>
            /// 手写签名配置
            /// </summary>
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

            /// <summary>
            /// 表单管理员
            /// </summary>
            [NameInMap("managers")]
            [Validation(Required=false)]
            public List<string> Managers { get; set; }

            /// <summary>
            /// 表单名称
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// 是否流程表单
            /// </summary>
            [NameInMap("processAppType")]
            [Validation(Required=false)]
            public bool? ProcessAppType { get; set; }

            /// <summary>
            /// 流程配置
            /// </summary>
            [NameInMap("processConfig")]
            [Validation(Required=false)]
            public string ProcessConfig { get; set; }

            /// <summary>
            /// 是否静态流程
            /// </summary>
            [NameInMap("staticProc")]
            [Validation(Required=false)]
            public bool? StaticProc { get; set; }

            /// <summary>
            /// 代提交配置
            /// </summary>
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

            /// <summary>
            /// 自定义标题规则
            /// </summary>
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

            /// <summary>
            /// 模板可见性
            /// </summary>
            [NameInMap("visibility")]
            [Validation(Required=false)]
            public List<GetProcessConfigResponseBodyResultVisibility> Visibility { get; set; }
            public class GetProcessConfigResponseBodyResultVisibility : TeaModel {
                /// <summary>
                /// 类型
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public int? Type { get; set; }

                /// <summary>
                /// 员工staffId/部门id
                /// </summary>
                [NameInMap("value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

        }

    }

}
