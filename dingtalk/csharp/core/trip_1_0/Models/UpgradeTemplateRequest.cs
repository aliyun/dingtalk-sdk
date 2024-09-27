// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalktrip_1_0.Models
{
    public class UpgradeTemplateRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dingcd2016f425331dc1acaaa37764f94726</para>
        /// </summary>
        [NameInMap("channelCorpId")]
        [Validation(Required=false)]
        public string ChannelCorpId { get; set; }

        [NameInMap("forceUpgrade")]
        [Validation(Required=false)]
        public bool? ForceUpgrade { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dingcd2016f425331dc1acaaa37764f94726</para>
        /// </summary>
        [NameInMap("tmcCorpId")]
        [Validation(Required=false)]
        public string TmcCorpId { get; set; }

    }

}
