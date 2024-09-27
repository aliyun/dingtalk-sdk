// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkexclusive_1_0.Models
{
    public class RollbackMiniAppVersionRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>5000000003</para>
        /// </summary>
        [NameInMap("miniAppId")]
        [Validation(Required=false)]
        public string MiniAppId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0.0.5</para>
        /// </summary>
        [NameInMap("rollbackVersion")]
        [Validation(Required=false)]
        public string RollbackVersion { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0.0.4</para>
        /// </summary>
        [NameInMap("targetVersion")]
        [Validation(Required=false)]
        public string TargetVersion { get; set; }

    }

}
