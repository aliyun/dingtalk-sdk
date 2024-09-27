// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkworkflow_1_0.Models
{
    public class GetSpaceWithDownloadAuthRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>8345000</para>
        /// </summary>
        [NameInMap("agentId")]
        [Validation(Required=false)]
        public long? AgentId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>111</para>
        /// </summary>
        [NameInMap("fileId")]
        [Validation(Required=false)]
        public string FileId { get; set; }

        [NameInMap("fileIdList")]
        [Validation(Required=false)]
        public List<string> FileIdList { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>a17444d1-075b-4a4d-xxxx</para>
        /// </summary>
        [NameInMap("processInstanceId")]
        [Validation(Required=false)]
        public string ProcessInstanceId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>user123</para>
        /// </summary>
        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

        /// <summary>
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("withCommentAttatchment")]
        [Validation(Required=false)]
        public bool? WithCommentAttatchment { get; set; }

    }

}
