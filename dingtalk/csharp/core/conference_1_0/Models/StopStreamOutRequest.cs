// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkconference_1_0.Models
{
    public class StopStreamOutRequest : TeaModel {
        /// <summary>
        /// 流id
        /// </summary>
        [NameInMap("streamId")]
        [Validation(Required=false)]
        public string StreamId { get; set; }

        /// <summary>
        /// 是否停止所有流，为true时，则不理会streamId字段
        /// </summary>
        [NameInMap("stopAllStream")]
        [Validation(Required=false)]
        public bool? StopAllStream { get; set; }

        /// <summary>
        /// 用户id
        /// </summary>
        [NameInMap("unionId")]
        [Validation(Required=false)]
        public string UnionId { get; set; }

    }

}
