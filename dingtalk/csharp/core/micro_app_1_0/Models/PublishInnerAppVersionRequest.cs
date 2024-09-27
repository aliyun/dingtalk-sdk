// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkmicro_app_1_0.Models
{
    public class PublishInnerAppVersionRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("appVersionId")]
        [Validation(Required=false)]
        public long? AppVersionId { get; set; }

        [NameInMap("miniAppOnPc")]
        [Validation(Required=false)]
        public bool? MiniAppOnPc { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxx</para>
        /// </summary>
        [NameInMap("opUnionId")]
        [Validation(Required=false)]
        public string OpUnionId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>online</para>
        /// </summary>
        [NameInMap("publishType")]
        [Validation(Required=false)]
        public string PublishType { get; set; }

    }

}
