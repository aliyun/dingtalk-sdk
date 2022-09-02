// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalktodo_1_0.Models
{
    public class GetTodoTaskDetailResponseBody : TeaModel {
        /// <summary>
        /// 接入业务应用标识
        /// </summary>
        [NameInMap("bizTag")]
        [Validation(Required=false)]
        public string BizTag { get; set; }

        /// <summary>
        /// 所属分类
        /// </summary>
        [NameInMap("category")]
        [Validation(Required=false)]
        public string Category { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [NameInMap("createdTime")]
        [Validation(Required=false)]
        public long? CreatedTime { get; set; }

        /// <summary>
        /// 创建者id（用户的unionId）
        /// </summary>
        [NameInMap("creatorId")]
        [Validation(Required=false)]
        public string CreatorId { get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// 自定义详情页跳转配置
        /// </summary>
        [NameInMap("detailUrl")]
        [Validation(Required=false)]
        public GetTodoTaskDetailResponseBodyDetailUrl DetailUrl { get; set; }
        public class GetTodoTaskDetailResponseBodyDetailUrl : TeaModel {
            /// <summary>
            /// app端详情页地址
            /// </summary>
            [NameInMap("appUrl")]
            [Validation(Required=false)]
            public string AppUrl { get; set; }

            /// <summary>
            /// pc端详情页地址
            /// </summary>
            [NameInMap("pcUrl")]
            [Validation(Required=false)]
            public string PcUrl { get; set; }

        }

        /// <summary>
        /// 完成状态
        /// </summary>
        [NameInMap("done")]
        [Validation(Required=false)]
        public bool? Done { get; set; }

        /// <summary>
        /// 截止时间
        /// </summary>
        [NameInMap("dueTime")]
        [Validation(Required=false)]
        public long? DueTime { get; set; }

        /// <summary>
        /// 执行者列表（用户的unionId）
        /// </summary>
        [NameInMap("executorIds")]
        [Validation(Required=false)]
        public List<string> ExecutorIds { get; set; }

        /// <summary>
        /// 执行者待办完成状态列表
        /// </summary>
        [NameInMap("executorStatus")]
        [Validation(Required=false)]
        public List<GetTodoTaskDetailResponseBodyExecutorStatus> ExecutorStatus { get; set; }
        public class GetTodoTaskDetailResponseBodyExecutorStatus : TeaModel {
            /// <summary>
            /// 执行者完成状态
            /// </summary>
            [NameInMap("isDone")]
            [Validation(Required=false)]
            public bool? IsDone { get; set; }

            /// <summary>
            /// 执行者id（用户的unionId）
            /// </summary>
            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

        /// <summary>
        /// 完成时间
        /// </summary>
        [NameInMap("finishTime")]
        [Validation(Required=false)]
        public long? FinishTime { get; set; }

        /// <summary>
        /// id
        /// </summary>
        [NameInMap("id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        /// <summary>
        /// 待办是否仅展示在执行人的待办列表中
        /// </summary>
        [NameInMap("isOnlyShowExecutor")]
        [Validation(Required=false)]
        public bool? IsOnlyShowExecutor { get; set; }

        /// <summary>
        /// 更新时间
        /// </summary>
        [NameInMap("modifiedTime")]
        [Validation(Required=false)]
        public long? ModifiedTime { get; set; }

        /// <summary>
        /// 更新者id（用户的unionId）
        /// </summary>
        [NameInMap("modifierId")]
        [Validation(Required=false)]
        public string ModifierId { get; set; }

        /// <summary>
        /// 所属组织信息
        /// </summary>
        [NameInMap("orgInfo")]
        [Validation(Required=false)]
        public GetTodoTaskDetailResponseBodyOrgInfo OrgInfo { get; set; }
        public class GetTodoTaskDetailResponseBodyOrgInfo : TeaModel {
            /// <summary>
            /// 组织corpId
            /// </summary>
            [NameInMap("corpId")]
            [Validation(Required=false)]
            public string CorpId { get; set; }

            /// <summary>
            /// 组织名称
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

        /// <summary>
        /// 参与者列表（用户的unionId）
        /// </summary>
        [NameInMap("participantIds")]
        [Validation(Required=false)]
        public List<string> ParticipantIds { get; set; }

        /// <summary>
        /// 优先级, 较低:10, 普通:20, 紧急:30, 非常紧急:40
        /// </summary>
        [NameInMap("priority")]
        [Validation(Required=false)]
        public int? Priority { get; set; }

        /// <summary>
        /// requestId
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// 业务来源
        /// </summary>
        [NameInMap("source")]
        [Validation(Required=false)]
        public string Source { get; set; }

        /// <summary>
        /// 业务来源id
        /// </summary>
        [NameInMap("sourceId")]
        [Validation(Required=false)]
        public string SourceId { get; set; }

        /// <summary>
        /// 开始时间
        /// </summary>
        [NameInMap("startTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

        /// <summary>
        /// 标题
        /// </summary>
        [NameInMap("subject")]
        [Validation(Required=false)]
        public string Subject { get; set; }

        /// <summary>
        /// 租户id(unionId/orgId/groupId)
        /// </summary>
        [NameInMap("tenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

        /// <summary>
        /// 租户类型（user/org/group）
        /// </summary>
        [NameInMap("tenantType")]
        [Validation(Required=false)]
        public string TenantType { get; set; }

        /// <summary>
        /// 待办卡片视图模型
        /// </summary>
        [NameInMap("todoCardView")]
        [Validation(Required=false)]
        public GetTodoTaskDetailResponseBodyTodoCardView TodoCardView { get; set; }
        public class GetTodoTaskDetailResponseBodyTodoCardView : TeaModel {
            /// <summary>
            /// link, button, 操作区类型，是链接类型，或者按钮类型
            /// </summary>
            [NameInMap("actionType")]
            [Validation(Required=false)]
            public string ActionType { get; set; }

            /// <summary>
            /// 卡片类型
            /// </summary>
            [NameInMap("cardType")]
            [Validation(Required=false)]
            public string CardType { get; set; }

            /// <summary>
            /// 卡片左上角 区域类型是 icon, 或者checkbox 类型的
            /// </summary>
            [NameInMap("circleELType")]
            [Validation(Required=false)]
            public string CircleELType { get; set; }

            /// <summary>
            /// icon, name ,内容区域类型是 icon+value, 或者name+value 类型的
            /// </summary>
            [NameInMap("contentType")]
            [Validation(Required=false)]
            public string ContentType { get; set; }

            /// <summary>
            /// 卡片icon
            /// </summary>
            [NameInMap("icon")]
            [Validation(Required=false)]
            public string Icon { get; set; }

            [NameInMap("todoCardContentList")]
            [Validation(Required=false)]
            public List<GetTodoTaskDetailResponseBodyTodoCardViewTodoCardContentList> TodoCardContentList { get; set; }
            public class GetTodoTaskDetailResponseBodyTodoCardViewTodoCardContentList : TeaModel {
                /// <summary>
                /// 自定义表单内容名字
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// 自定义表单内容值
                /// </summary>
                [NameInMap("value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// 卡片标题
            /// </summary>
            [NameInMap("todoCardTitle")]
            [Validation(Required=false)]
            public string TodoCardTitle { get; set; }

        }

    }

}
