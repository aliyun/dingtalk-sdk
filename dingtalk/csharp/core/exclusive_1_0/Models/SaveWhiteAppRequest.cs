// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkexclusive_1_0.Models
{
    public class SaveWhiteAppRequest : TeaModel {
        /// <term><b>Obsolete</b></term>
        [NameInMap("agentIdList")]
        [Validation(Required=false)]
        [Obsolete]
        public List<long?> AgentIdList { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;openShareControl&quot;:[123],&quot;openClipboardPaste&quot;:[123]}</para>
        /// </summary>
        [NameInMap("agentIdMap")]
        [Validation(Required=false)]
        public string AgentIdMap { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// 
        /// <b>Example:</b>
        /// <para>add</para>
        /// </summary>
        [NameInMap("operation")]
        [Validation(Required=false)]
        [Obsolete]
        public string Operation { get; set; }

    }

}
