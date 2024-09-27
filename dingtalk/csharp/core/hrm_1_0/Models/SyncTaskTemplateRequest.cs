// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkhrm_1_0.Models
{
    public class SyncTaskTemplateRequest : TeaModel {
        /// <summary>
        /// <b>if can be null:</b>
        /// <c>false</c>
        /// </summary>
        [NameInMap("delete")]
        [Validation(Required=false)]
        public bool? Delete { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>培训、薪酬任务模版</para>
        /// </summary>
        [NameInMap("des")]
        [Validation(Required=false)]
        public string Des { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{&quot;key&quot;:value}</para>
        /// </summary>
        [NameInMap("ext")]
        [Validation(Required=false)]
        public string Ext { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>培训模版</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>23234</para>
        /// </summary>
        [NameInMap("optUserId")]
        [Validation(Required=false)]
        public string OptUserId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>232332</para>
        /// </summary>
        [NameInMap("outerId")]
        [Validation(Required=false)]
        public string OuterId { get; set; }

        [NameInMap("taskScopeVO")]
        [Validation(Required=false)]
        public SyncTaskTemplateRequestTaskScopeVO TaskScopeVO { get; set; }
        public class SyncTaskTemplateRequestTaskScopeVO : TeaModel {
            [NameInMap("deptIds")]
            [Validation(Required=false)]
            public List<long?> DeptIds { get; set; }

            [NameInMap("positionIds")]
            [Validation(Required=false)]
            public List<string> PositionIds { get; set; }

            [NameInMap("roleIds")]
            [Validation(Required=false)]
            public List<string> RoleIds { get; set; }

            [NameInMap("userIds")]
            [Validation(Required=false)]
            public List<string> UserIds { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PERFORMANCE_TASK、TRAIN_TASK</para>
        /// </summary>
        [NameInMap("taskType")]
        [Validation(Required=false)]
        public string TaskType { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>onboarding</para>
        /// </summary>
        [NameInMap("solutionType")]
        [Validation(Required=false)]
        public string SolutionType { get; set; }

    }

}
