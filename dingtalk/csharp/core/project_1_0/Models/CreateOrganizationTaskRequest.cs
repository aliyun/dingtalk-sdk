// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkproject_1_0.Models
{
    public class CreateOrganizationTaskRequest : TeaModel {
        /// <summary>
        /// 任务标题
        /// </summary>
        [NameInMap("content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        /// <summary>
        /// 任务创建日期
        /// </summary>
        [NameInMap("createTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// 是否禁止动态
        /// </summary>
        [NameInMap("disableActivity")]
        [Validation(Required=false)]
        public bool? DisableActivity { get; set; }

        /// <summary>
        /// 是否禁止通知
        /// </summary>
        [NameInMap("disableNotification")]
        [Validation(Required=false)]
        public bool? DisableNotification { get; set; }

        /// <summary>
        /// 任务截止日期
        /// </summary>
        [NameInMap("dueDate")]
        [Validation(Required=false)]
        public string DueDate { get; set; }

        /// <summary>
        /// 执行者id
        /// </summary>
        [NameInMap("executorId")]
        [Validation(Required=false)]
        public string ExecutorId { get; set; }

        /// <summary>
        /// 参与者id
        /// </summary>
        [NameInMap("involveMembers")]
        [Validation(Required=false)]
        public List<string> InvolveMembers { get; set; }

        /// <summary>
        /// 任务是否完成
        /// </summary>
        [NameInMap("isDone")]
        [Validation(Required=false)]
        public bool? IsDone { get; set; }

        /// <summary>
        /// 任务自定义标记
        /// </summary>
        [NameInMap("label")]
        [Validation(Required=false)]
        public string Label { get; set; }

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
        /// 任务可见性。involves：仅参与者可见。members:所有人可见
        /// </summary>
        [NameInMap("visible")]
        [Validation(Required=false)]
        public string Visible { get; set; }

    }

}
