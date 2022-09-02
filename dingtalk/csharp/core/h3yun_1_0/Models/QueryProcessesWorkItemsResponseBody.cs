// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkh3yun_1_0.Models
{
    public class QueryProcessesWorkItemsResponseBody : TeaModel {
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
        public List<QueryProcessesWorkItemsResponseBodyData> Data { get; set; }
        public class QueryProcessesWorkItemsResponseBodyData : TeaModel {
            /// <summary>
            /// 活动编码
            /// </summary>
            [NameInMap("activityCode")]
            [Validation(Required=false)]
            public string ActivityCode { get; set; }

            /// <summary>
            /// 当前活动名称
            /// </summary>
            [NameInMap("activityName")]
            [Validation(Required=false)]
            public string ActivityName { get; set; }

            /// <summary>
            /// 应用编码
            /// </summary>
            [NameInMap("appCode")]
            [Validation(Required=false)]
            public string AppCode { get; set; }

            /// <summary>
            /// 工作项所关联的业务对象id
            /// </summary>
            [NameInMap("bizObjectId")]
            [Validation(Required=false)]
            public string BizObjectId { get; set; }

            /// <summary>
            /// 对该工作项的意见
            /// </summary>
            [NameInMap("comment")]
            [Validation(Required=false)]
            public string Comment { get; set; }

            /// <summary>
            /// 显示名称
            /// </summary>
            [NameInMap("displayName")]
            [Validation(Required=false)]
            public string DisplayName { get; set; }

            /// <summary>
            /// 完成时间
            /// </summary>
            [NameInMap("finishTimeGMT")]
            [Validation(Required=false)]
            public string FinishTimeGMT { get; set; }

            /// <summary>
            /// 完成者
            /// </summary>
            [NameInMap("finisher")]
            [Validation(Required=false)]
            public QueryProcessesWorkItemsResponseBodyDataFinisher Finisher { get; set; }
            public class QueryProcessesWorkItemsResponseBodyDataFinisher : TeaModel {
                /// <summary>
                /// 用户直属的部门id
                /// </summary>
                [NameInMap("departmentId")]
                [Validation(Required=false)]
                public string DepartmentId { get; set; }

                /// <summary>
                /// 用户直属的部门名称
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
            /// 对该工作项是否同意
            /// </summary>
            [NameInMap("isApproval")]
            [Validation(Required=false)]
            public bool? IsApproval { get; set; }

            /// <summary>
            /// 是否已完成
            /// </summary>
            [NameInMap("isFinish")]
            [Validation(Required=false)]
            public bool? IsFinish { get; set; }

            /// <summary>
            /// 参与者
            /// </summary>
            [NameInMap("participant")]
            [Validation(Required=false)]
            public QueryProcessesWorkItemsResponseBodyDataParticipant Participant { get; set; }
            public class QueryProcessesWorkItemsResponseBodyDataParticipant : TeaModel {
                /// <summary>
                /// 用户直属的部门id
                /// </summary>
                [NameInMap("departmentId")]
                [Validation(Required=false)]
                public string DepartmentId { get; set; }

                /// <summary>
                /// 用户直属的部门名称
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
            /// 流程实例ID
            /// </summary>
            [NameInMap("processInstanceId")]
            [Validation(Required=false)]
            public string ProcessInstanceId { get; set; }

            /// <summary>
            /// 工作流版本
            /// </summary>
            [NameInMap("processVersion")]
            [Validation(Required=false)]
            public string ProcessVersion { get; set; }

            /// <summary>
            /// 转交工作的接收人。如无转接人，则为空
            /// </summary>
            [NameInMap("receiptor")]
            [Validation(Required=false)]
            public QueryProcessesWorkItemsResponseBodyDataReceiptor Receiptor { get; set; }
            public class QueryProcessesWorkItemsResponseBodyDataReceiptor : TeaModel {
                /// <summary>
                /// 用户直属的部门id
                /// </summary>
                [NameInMap("departmentId")]
                [Validation(Required=false)]
                public string DepartmentId { get; set; }

                /// <summary>
                /// 用户直属的部门名称
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
            /// 接收时间
            /// </summary>
            [NameInMap("receiveTimeGMT")]
            [Validation(Required=false)]
            public string ReceiveTimeGMT { get; set; }

            /// <summary>
            /// 表单编码
            /// </summary>
            [NameInMap("schemaCode")]
            [Validation(Required=false)]
            public string SchemaCode { get; set; }

            /// <summary>
            /// 开始这个任务的时间
            /// </summary>
            [NameInMap("startTimeGMT")]
            [Validation(Required=false)]
            public string StartTimeGMT { get; set; }

            /// <summary>
            /// 状态。Waiting=等待的状态，Working=正在工作中的状态，Finished=处于完成状态，Canceled=已经被取消，Forwarded=已转交状态，Revoked=撤回
            /// </summary>
            [NameInMap("state")]
            [Validation(Required=false)]
            public string State { get; set; }

            /// <summary>
            /// 工作任务Id
            /// </summary>
            [NameInMap("workItemId")]
            [Validation(Required=false)]
            public string WorkItemId { get; set; }

            /// <summary>
            /// 工作项类型。Fill=普通工作项，Approve=审批类型工作项，Circulate=传阅
            /// </summary>
            [NameInMap("workItemType")]
            [Validation(Required=false)]
            public string WorkItemType { get; set; }

        }

        /// <summary>
        /// 提示信息
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

    }

}
