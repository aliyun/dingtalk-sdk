// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkproject_1_0.Models
{
    public class CreateOrganizationTaskResponseBody : TeaModel {
        /// <summary>
        /// 返回结果对象
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public CreateOrganizationTaskResponseBodyResult Result { get; set; }
        public class CreateOrganizationTaskResponseBodyResult : TeaModel {
            /// <summary>
            /// 父任务Id
            /// </summary>
            [NameInMap("ancestorIds")]
            [Validation(Required=false)]
            public List<string> AncestorIds { get; set; }

            /// <summary>
            /// 附件数量
            /// </summary>
            [NameInMap("attachmentsCount")]
            [Validation(Required=false)]
            public int? AttachmentsCount { get; set; }

            /// <summary>
            /// 任务标题
            /// </summary>
            [NameInMap("content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            /// <summary>
            /// 创建时间
            /// </summary>
            [NameInMap("created")]
            [Validation(Required=false)]
            public string Created { get; set; }

            /// <summary>
            /// 创建者
            /// </summary>
            [NameInMap("creator")]
            [Validation(Required=false)]
            public CreateOrganizationTaskResponseBodyResultCreator Creator { get; set; }
            public class CreateOrganizationTaskResponseBodyResultCreator : TeaModel {
                /// <summary>
                /// 创建者头像地址
                /// </summary>
                [NameInMap("avatarUrl")]
                [Validation(Required=false)]
                public string AvatarUrl { get; set; }

                /// <summary>
                /// 创建者姓名
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// 创建者id
                /// </summary>
                [NameInMap("userId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

            }

            /// <summary>
            /// 创建者id
            /// </summary>
            [NameInMap("creatorId")]
            [Validation(Required=false)]
            public string CreatorId { get; set; }

            /// <summary>
            /// 任务截止日期
            /// </summary>
            [NameInMap("dueDate")]
            [Validation(Required=false)]
            public string DueDate { get; set; }

            /// <summary>
            /// 执行者
            /// </summary>
            [NameInMap("executor")]
            [Validation(Required=false)]
            public CreateOrganizationTaskResponseBodyResultExecutor Executor { get; set; }
            public class CreateOrganizationTaskResponseBodyResultExecutor : TeaModel {
                /// <summary>
                /// 头像地址
                /// </summary>
                [NameInMap("avatarUrl")]
                [Validation(Required=false)]
                public string AvatarUrl { get; set; }

                /// <summary>
                /// 姓名
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// 执行者id
                /// </summary>
                [NameInMap("userId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

            }

            /// <summary>
            /// 执行者id
            /// </summary>
            [NameInMap("executorId")]
            [Validation(Required=false)]
            public string ExecutorId { get; set; }

            /// <summary>
            /// 是否有提醒
            /// </summary>
            [NameInMap("hasReminder")]
            [Validation(Required=false)]
            public bool? HasReminder { get; set; }

            /// <summary>
            /// 任务id
            /// </summary>
            [NameInMap("id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// 参与者id列表
            /// </summary>
            [NameInMap("involveMembers")]
            [Validation(Required=false)]
            public List<string> InvolveMembers { get; set; }

            /// <summary>
            /// 参与者列表
            /// </summary>
            [NameInMap("involvers")]
            [Validation(Required=false)]
            public List<CreateOrganizationTaskResponseBodyResultInvolvers> Involvers { get; set; }
            public class CreateOrganizationTaskResponseBodyResultInvolvers : TeaModel {
                /// <summary>
                /// 头像
                /// </summary>
                [NameInMap("avatarUrl")]
                [Validation(Required=false)]
                public string AvatarUrl { get; set; }

                /// <summary>
                /// 用户id
                /// </summary>
                [NameInMap("id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// 名字
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            /// <summary>
            /// 是否删除
            /// </summary>
            [NameInMap("isDeleted")]
            [Validation(Required=false)]
            public bool? IsDeleted { get; set; }

            /// <summary>
            /// 是否完成
            /// </summary>
            [NameInMap("isDone")]
            [Validation(Required=false)]
            public string IsDone { get; set; }

            /// <summary>
            /// 任务备注
            /// </summary>
            [NameInMap("note")]
            [Validation(Required=false)]
            public string Note { get; set; }

            /// <summary>
            /// 优先级【-10,0,1,2】中选一个
            /// </summary>
            [NameInMap("priority")]
            [Validation(Required=false)]
            public int? Priority { get; set; }

            /// <summary>
            /// 更新时间
            /// </summary>
            [NameInMap("updated")]
            [Validation(Required=false)]
            public string Updated { get; set; }

            /// <summary>
            /// 任务可见性。involves：仅参与者可见。members:所有人可见
            /// </summary>
            [NameInMap("visible")]
            [Validation(Required=false)]
            public string Visible { get; set; }

        }

    }

}
