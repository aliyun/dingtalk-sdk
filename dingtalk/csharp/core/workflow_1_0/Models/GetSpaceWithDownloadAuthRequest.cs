// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkworkflow_1_0.Models
{
    public class GetSpaceWithDownloadAuthRequest : TeaModel {
        /// <summary>
        /// 应用的agentid。
        /// </summary>
        [NameInMap("agentId")]
        [Validation(Required=false)]
        public long? AgentId { get; set; }

        /// <summary>
        /// 审批附件ID。
        /// </summary>
        [NameInMap("fileId")]
        [Validation(Required=false)]
        public string FileId { get; set; }

        /// <summary>
        /// 附件ID列表，支持批量授权，最大列表长度：20。
        /// </summary>
        [NameInMap("fileIdList")]
        [Validation(Required=false)]
        public List<string> FileIdList { get; set; }

        /// <summary>
        /// 实例ID。
        /// 
        /// 企业内部应用
        /// 
        /// 可通过获取审批实例ID列表接口获取。
        /// 
        /// 第三方企业应用
        /// 
        /// 可以通过推送的审批事件中获取，参考biz_type=22。
        /// </summary>
        [NameInMap("processInstanceId")]
        [Validation(Required=false)]
        public string ProcessInstanceId { get; set; }

        /// <summary>
        /// 授权允许预览附件的用户userid。
        /// </summary>
        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
