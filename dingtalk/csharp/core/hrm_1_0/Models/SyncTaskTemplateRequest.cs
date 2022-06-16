// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkhrm_1_0.Models
{
    public class SyncTaskTemplateRequest : TeaModel {
        /// <summary>
        /// 任务模板描述
        /// </summary>
        [NameInMap("des")]
        [Validation(Required=false)]
        public string Des { get; set; }

        /// <summary>
        /// 扩展信息，json串
        /// </summary>
        [NameInMap("ext")]
        [Validation(Required=false)]
        public string Ext { get; set; }

        /// <summary>
        /// 模版名称
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// 任务模版创建人staffId
        /// </summary>
        [NameInMap("optUserId")]
        [Validation(Required=false)]
        public string OptUserId { get; set; }

        /// <summary>
        /// isv对应的任务模版唯一键
        /// </summary>
        [NameInMap("outerId")]
        [Validation(Required=false)]
        public string OuterId { get; set; }

        /// <summary>
        /// 圈人规则
        /// </summary>
        [NameInMap("taskScopeVO")]
        [Validation(Required=false)]
        public SyncTaskTemplateRequestTaskScopeVO TaskScopeVO { get; set; }
        public class SyncTaskTemplateRequestTaskScopeVO : TeaModel {
            [NameInMap("deptIds")]
            [Validation(Required=false)]
            public List<string> DeptIds { get; set; }
            [NameInMap("positionIds")]
            [Validation(Required=false)]
            public List<string> PositionIds { get; set; }
            [NameInMap("roleIds")]
            [Validation(Required=false)]
            public List<string> RoleIds { get; set; }
            [NameInMap("userIds")]
            [Validation(Required=false)]
            public List<string> UserIds { get; set; }
        };

        /// <summary>
        /// 任务模版类型：TRAIN_TASK、PERFORMANCE_TASK
        /// </summary>
        [NameInMap("taskType")]
        [Validation(Required=false)]
        public string TaskType { get; set; }

        [NameInMap("solutionType")]
        [Validation(Required=false)]
        public string SolutionType { get; set; }

    }

}
