// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkworkflow_1_0.Models
{
    public class CreateIntegratedTaskRequest : TeaModel {
        /// <summary>
        /// 待办组ID，调用方提供自定义唯一分组标识
        /// </summary>
        [NameInMap("activityId")]
        [Validation(Required=false)]
        public string ActivityId { get; set; }

        /// <summary>
        /// OA审批实例ID，通过创建实例接口获取。
        /// 
        /// </summary>
        [NameInMap("processInstanceId")]
        [Validation(Required=false)]
        public string ProcessInstanceId { get; set; }

        /// <summary>
        /// 任务列表
        /// </summary>
        [NameInMap("tasks")]
        [Validation(Required=false)]
        public List<CreateIntegratedTaskRequestTasks> Tasks { get; set; }
        public class CreateIntegratedTaskRequestTasks : TeaModel {
            /// <summary>
            /// 用户自定义数据，页面跳转时将通过 url 查询参数回传，格式为 customData=xxxxx
            /// </summary>
            [NameInMap("customData")]
            [Validation(Required=false)]
            public string CustomData { get; set; }

            /// <summary>
            /// 待办事项跳转URL。
            /// 创建审批实例接口里的url，实现的是钉钉审批应用里的审批单跳转。这个接口里的url，实现的是钉钉待办页面，对应的待办卡片的跳转。两种跳转场景不同。需要注意的是，钉钉的待办页面，也同时支持移动端和PC端，所以这个接口里传的url参数，它所对应的页面也要适配好移动端和PC端。
            /// 
            /// </summary>
            [NameInMap("url")]
            [Validation(Required=false)]
            public string Url { get; set; }

            /// <summary>
            /// OA审批任务执行人的用户ID
            /// </summary>
            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

    }

}
