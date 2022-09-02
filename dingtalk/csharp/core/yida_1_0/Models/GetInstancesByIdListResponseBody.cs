// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkyida_1_0.Models
{
    public class GetInstancesByIdListResponseBody : TeaModel {
        /// <summary>
        /// 流程实例列表
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public List<GetInstancesByIdListResponseBodyResult> Result { get; set; }
        public class GetInstancesByIdListResponseBodyResult : TeaModel {
            /// <summary>
            /// 流程实例当前任务执行人列表
            /// </summary>
            [NameInMap("actionExecutor")]
            [Validation(Required=false)]
            public List<GetInstancesByIdListResponseBodyResultActionExecutor> ActionExecutor { get; set; }
            public class GetInstancesByIdListResponseBodyResultActionExecutor : TeaModel {
                /// <summary>
                /// 部门名称
                /// </summary>
                [NameInMap("departmentName")]
                [Validation(Required=false)]
                public string DepartmentName { get; set; }

                /// <summary>
                /// 邮箱
                /// </summary>
                [NameInMap("email")]
                [Validation(Required=false)]
                public string Email { get; set; }

                /// <summary>
                /// 用户名
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public GetInstancesByIdListResponseBodyResultActionExecutorName Name { get; set; }
                public class GetInstancesByIdListResponseBodyResultActionExecutorName : TeaModel {
                    /// <summary>
                    /// 中文名称
                    /// </summary>
                    [NameInMap("nameInChinese")]
                    [Validation(Required=false)]
                    public string NameInChinese { get; set; }

                    /// <summary>
                    /// 英文名称
                    /// </summary>
                    [NameInMap("nameInEnglish")]
                    [Validation(Required=false)]
                    public string NameInEnglish { get; set; }

                    /// <summary>
                    /// 国际化
                    /// </summary>
                    [NameInMap("type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

                /// <summary>
                /// 用户工号
                /// </summary>
                [NameInMap("userId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

            }

            /// <summary>
            /// 流程结束时的审批结论
            /// </summary>
            [NameInMap("approvedResult")]
            [Validation(Required=false)]
            public string ApprovedResult { get; set; }

            /// <summary>
            /// 表单数据
            /// </summary>
            [NameInMap("data")]
            [Validation(Required=false)]
            public Dictionary<string, object> Data { get; set; }

            /// <summary>
            /// 流程表单ID
            /// </summary>
            [NameInMap("formUuid")]
            [Validation(Required=false)]
            public string FormUuid { get; set; }

            /// <summary>
            /// 实例状态
            /// </summary>
            [NameInMap("instanceStatus")]
            [Validation(Required=false)]
            public string InstanceStatus { get; set; }

            /// <summary>
            /// 发起人信息
            /// </summary>
            [NameInMap("originator")]
            [Validation(Required=false)]
            public GetInstancesByIdListResponseBodyResultOriginator Originator { get; set; }
            public class GetInstancesByIdListResponseBodyResultOriginator : TeaModel {
                /// <summary>
                /// 部门名称
                /// </summary>
                [NameInMap("departmentName")]
                [Validation(Required=false)]
                public string DepartmentName { get; set; }

                /// <summary>
                /// 邮箱
                /// </summary>
                [NameInMap("email")]
                [Validation(Required=false)]
                public string Email { get; set; }

                /// <summary>
                /// 用户名
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public GetInstancesByIdListResponseBodyResultOriginatorName Name { get; set; }
                public class GetInstancesByIdListResponseBodyResultOriginatorName : TeaModel {
                    /// <summary>
                    /// 中文名称
                    /// </summary>
                    [NameInMap("nameInChinese")]
                    [Validation(Required=false)]
                    public string NameInChinese { get; set; }

                    /// <summary>
                    /// 英文名称
                    /// </summary>
                    [NameInMap("nameInEnglish")]
                    [Validation(Required=false)]
                    public string NameInEnglish { get; set; }

                    /// <summary>
                    /// 国际化
                    /// </summary>
                    [NameInMap("type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

                /// <summary>
                /// 用户工号
                /// </summary>
                [NameInMap("userId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

            }

            /// <summary>
            /// 流程Code
            /// </summary>
            [NameInMap("processCode")]
            [Validation(Required=false)]
            public string ProcessCode { get; set; }

            /// <summary>
            /// 实例ID
            /// </summary>
            [NameInMap("processInstanceId")]
            [Validation(Required=false)]
            public string ProcessInstanceId { get; set; }

            /// <summary>
            /// 实例标题
            /// </summary>
            [NameInMap("title")]
            [Validation(Required=false)]
            public string Title { get; set; }

        }

    }

}
