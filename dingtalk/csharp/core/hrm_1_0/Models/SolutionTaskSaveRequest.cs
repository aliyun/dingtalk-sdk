// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkhrm_1_0.Models
{
    public class SolutionTaskSaveRequest : TeaModel {
        /// <summary>
        /// 任务要求的截止时间
        /// </summary>
        [NameInMap("claimTime")]
        [Validation(Required=false)]
        public long? ClaimTime { get; set; }

        /// <summary>
        /// 任务描述
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// 任务完成时间
        /// </summary>
        [NameInMap("finishTime")]
        [Validation(Required=false)]
        public long? FinishTime { get; set; }

        /// <summary>
        /// 外部的任务唯一标识
        /// </summary>
        [NameInMap("outerId")]
        [Validation(Required=false)]
        public string OuterId { get; set; }

        [NameInMap("solutionInstanceId")]
        [Validation(Required=false)]
        public string SolutionInstanceId { get; set; }

        [NameInMap("startTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

        /// <summary>
        /// 任务状态，如running,finished
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// 任务业务模块，如training, performance等
        /// </summary>
        [NameInMap("taskType")]
        [Validation(Required=false)]
        public string TaskType { get; set; }

        [NameInMap("templateOuterId")]
        [Validation(Required=false)]
        public string TemplateOuterId { get; set; }

        /// <summary>
        /// 任务名称
        /// </summary>
        [NameInMap("title")]
        [Validation(Required=false)]
        public string Title { get; set; }

        /// <summary>
        /// 任务执行人userId
        /// </summary>
        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

        /// <summary>
        /// 解决方案类型
        /// </summary>
        [NameInMap("solutionType")]
        [Validation(Required=false)]
        public string SolutionType { get; set; }

    }

}
