// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkexclusive_1_0.Models
{
    public class BanOrOpenGroupWordsRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("banWordsType")]
        [Validation(Required=false)]
        public int? BanWordsType { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("openConverationId")]
        [Validation(Required=false)]
        public string OpenConverationId { get; set; }

    }

}
