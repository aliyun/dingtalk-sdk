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
            [NameInMap("ancestorIds")]
            [Validation(Required=false)]
            public List<string> AncestorIds { get; set; }
            [NameInMap("attachmentsCount")]
            [Validation(Required=false)]
            public int? AttachmentsCount { get; set; }
            [NameInMap("content")]
            [Validation(Required=false)]
            public string Content { get; set; }
            [NameInMap("created")]
            [Validation(Required=false)]
            public string Created { get; set; }
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
            [NameInMap("creatorId")]
            [Validation(Required=false)]
            public string CreatorId { get; set; }
            [NameInMap("dueDate")]
            [Validation(Required=false)]
            public string DueDate { get; set; }
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
            [NameInMap("executorId")]
            [Validation(Required=false)]
            public string ExecutorId { get; set; }
            [NameInMap("hasReminder")]
            [Validation(Required=false)]
            public bool? HasReminder { get; set; }
            [NameInMap("id")]
            [Validation(Required=false)]
            public string Id { get; set; }
            [NameInMap("involveMembers")]
            [Validation(Required=false)]
            public List<string> InvolveMembers { get; set; }
            [NameInMap("involvers")]
            [Validation(Required=false)]
            public List<CreateOrganizationTaskResponseBodyResultInvolvers> Involvers { get; set; }
            public class CreateOrganizationTaskResponseBodyResultInvolvers : TeaModel {
                public string AvatarUrl { get; set; }
                public string Id { get; set; }
                public string Name { get; set; }
            }
            [NameInMap("isDeleted")]
            [Validation(Required=false)]
            public bool? IsDeleted { get; set; }
            [NameInMap("isDone")]
            [Validation(Required=false)]
            public string IsDone { get; set; }
            [NameInMap("labels")]
            [Validation(Required=false)]
            public List<string> Labels { get; set; }
            [NameInMap("note")]
            [Validation(Required=false)]
            public string Note { get; set; }
            [NameInMap("priority")]
            [Validation(Required=false)]
            public int? Priority { get; set; }
            [NameInMap("tagIds")]
            [Validation(Required=false)]
            public List<string> TagIds { get; set; }
            [NameInMap("updated")]
            [Validation(Required=false)]
            public string Updated { get; set; }
            [NameInMap("visible")]
            [Validation(Required=false)]
            public string Visible { get; set; }
        };

    }

}
