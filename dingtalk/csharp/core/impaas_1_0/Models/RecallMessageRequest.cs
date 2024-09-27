// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkimpaas_1_0.Models
{
    public class RecallMessageRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("messageId")]
        [Validation(Required=false)]
        public string MessageId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("operatorUid")]
        [Validation(Required=false)]
        public string OperatorUid { get; set; }

        [NameInMap("type")]
        [Validation(Required=false)]
        public int? Type { get; set; }

    }

}
