// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkexclusive_1_0.Models
{
    public class UpdateMiniAppVersionStatusRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>500000003</para>
        /// </summary>
        [NameInMap("miniAppId")]
        [Validation(Required=false)]
        public string MiniAppId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0.0.5</para>
        /// </summary>
        [NameInMap("version")]
        [Validation(Required=false)]
        public string Version { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0-开发版，1-灰度版，2-发布版，3-体验版</para>
        /// </summary>
        [NameInMap("versionType")]
        [Validation(Required=false)]
        public int? VersionType { get; set; }

    }

}
