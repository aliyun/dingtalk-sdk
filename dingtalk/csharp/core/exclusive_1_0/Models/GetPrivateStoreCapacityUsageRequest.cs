// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkexclusive_1_0.Models
{
    public class GetPrivateStoreCapacityUsageRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ding1234</para>
        /// </summary>
        [NameInMap("targetCorpId")]
        [Validation(Required=false)]
        public string TargetCorpId { get; set; }

    }

}
