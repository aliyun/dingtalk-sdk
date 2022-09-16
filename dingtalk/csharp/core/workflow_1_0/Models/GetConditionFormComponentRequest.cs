// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkworkflow_1_0.Models
{
    public class GetConditionFormComponentRequest : TeaModel {
        /// <summary>
        /// 应用ID (三方应用为AppID)，可在开发者管理后台后台的应用详情页面获取。
        /// </summary>
        [NameInMap("agentId")]
        [Validation(Required=false)]
        public long? AgentId { get; set; }

        /// <summary>
        /// 审批模板ID。
        /// 
        /// processCode需要OA管理后台，在编辑审批表单的URL中获取。
        /// </summary>
        [NameInMap("processCode")]
        [Validation(Required=false)]
        public string ProcessCode { get; set; }

    }

}
