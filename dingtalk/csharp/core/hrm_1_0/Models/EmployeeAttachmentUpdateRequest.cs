// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkhrm_1_0.Models
{
    public class EmployeeAttachmentUpdateRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("appAgentId")]
        [Validation(Required=false)]
        public long? AppAgentId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("fieldCode")]
        [Validation(Required=false)]
        public string FieldCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>.png</para>
        /// </summary>
        [NameInMap("fileSuffix")]
        [Validation(Required=false)]
        public string FileSuffix { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;$iAEKAqNwbmcDBgTNAk&quot;</para>
        /// </summary>
        [NameInMap("mediaId")]
        [Validation(Required=false)]
        public string MediaId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>admin123</para>
        /// </summary>
        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
