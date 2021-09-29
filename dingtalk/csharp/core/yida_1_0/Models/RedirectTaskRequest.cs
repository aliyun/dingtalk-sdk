// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkyida_1_0.Models
{
    public class RedirectTaskRequest : TeaModel {
        /// <summary>
        /// 实例ID
        /// </summary>
        [NameInMap("processInstanceId")]
        [Validation(Required=false)]
        public string ProcessInstanceId { get; set; }

        /// <summary>
        /// 是否应用管理员进行转交; ●
        /// 可选项 : y/n
        /// 
        /// ●
        /// y,则userId必须传应用管理员工号，或者yida_pub_account
        /// 
        /// ●
        /// n, userId必须传任务的当前执行人
        /// </summary>
        [NameInMap("byManager")]
        [Validation(Required=false)]
        public string ByManager { get; set; }

        /// <summary>
        /// 应用ID
        /// </summary>
        [NameInMap("appType")]
        [Validation(Required=false)]
        public string AppType { get; set; }

        /// <summary>
        /// 验权token; 在应用数据中获取。
        /// </summary>
        [NameInMap("systemToken")]
        [Validation(Required=false)]
        public string SystemToken { get; set; }

        /// <summary>
        /// 语言环境; 可选值：zh_CN/en_US
        /// </summary>
        [NameInMap("language")]
        [Validation(Required=false)]
        public string Language { get; set; }

        /// <summary>
        /// 转交备注
        /// </summary>
        [NameInMap("remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

        /// <summary>
        /// 新的任务处理人工号
        /// </summary>
        [NameInMap("nowActionExecutorId")]
        [Validation(Required=false)]
        public string NowActionExecutorId { get; set; }

        /// <summary>
        /// 钉钉的userId
        /// </summary>
        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

        /// <summary>
        /// 任务ID
        /// </summary>
        [NameInMap("taskId")]
        [Validation(Required=false)]
        public long? TaskId { get; set; }

    }

}
