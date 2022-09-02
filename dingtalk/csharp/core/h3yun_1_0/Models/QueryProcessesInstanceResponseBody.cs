// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkh3yun_1_0.Models
{
    public class QueryProcessesInstanceResponseBody : TeaModel {
        /// <summary>
        /// 状态码
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// 返回结果
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public List<QueryProcessesInstanceResponseBodyData> Data { get; set; }
        public class QueryProcessesInstanceResponseBodyData : TeaModel {
            /// <summary>
            /// 流程所属的应用编码
            /// </summary>
            [NameInMap("appCode")]
            [Validation(Required=false)]
            public string AppCode { get; set; }

            /// <summary>
            /// 流程关联的业务对象id
            /// </summary>
            [NameInMap("bizObjectId")]
            [Validation(Required=false)]
            public string BizObjectId { get; set; }

            /// <summary>
            /// 创建时间
            /// </summary>
            [NameInMap("createdTimeGMT")]
            [Validation(Required=false)]
            public string CreatedTimeGMT { get; set; }

            /// <summary>
            /// 钉钉流程Id
            /// </summary>
            [NameInMap("dingTalkProcessId")]
            [Validation(Required=false)]
            public string DingTalkProcessId { get; set; }

            /// <summary>
            /// 完成时间
            /// </summary>
            [NameInMap("finishTimeGMT")]
            [Validation(Required=false)]
            public string FinishTimeGMT { get; set; }

            /// <summary>
            /// 流程发起人信息
            /// </summary>
            [NameInMap("originator")]
            [Validation(Required=false)]
            public QueryProcessesInstanceResponseBodyDataOriginator Originator { get; set; }
            public class QueryProcessesInstanceResponseBodyDataOriginator : TeaModel {
                /// <summary>
                /// 所属组织id
                /// </summary>
                [NameInMap("departmentId")]
                [Validation(Required=false)]
                public string DepartmentId { get; set; }

                /// <summary>
                /// 所属组织名称
                /// </summary>
                [NameInMap("departmentName")]
                [Validation(Required=false)]
                public string DepartmentName { get; set; }

                /// <summary>
                /// 用户名称
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// 用户id
                /// </summary>
                [NameInMap("userId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

            }

            /// <summary>
            /// 流程名称
            /// </summary>
            [NameInMap("processDisplayName")]
            [Validation(Required=false)]
            public string ProcessDisplayName { get; set; }

            /// <summary>
            /// 流程实例ID
            /// </summary>
            [NameInMap("processInstanceId")]
            [Validation(Required=false)]
            public string ProcessInstanceId { get; set; }

            /// <summary>
            /// 工作流模板的版本
            /// </summary>
            [NameInMap("processVersion")]
            [Validation(Required=false)]
            public int? ProcessVersion { get; set; }

            /// <summary>
            /// 流程所属的表单编码
            /// </summary>
            [NameInMap("schemaCode")]
            [Validation(Required=false)]
            public string SchemaCode { get; set; }

            /// <summary>
            /// 开始时间
            /// </summary>
            [NameInMap("startTimeGMT")]
            [Validation(Required=false)]
            public string StartTimeGMT { get; set; }

            /// <summary>
            /// 状态。Initiated=初始化完成，Starting=正在启动，Running=正在运行，Finishing=正在结束，Finished=已完成，Canceled=已取
            /// </summary>
            [NameInMap("state")]
            [Validation(Required=false)]
            public string State { get; set; }

        }

        /// <summary>
        /// 提示信息
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

    }

}
