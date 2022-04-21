// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkservice_group_1_0.Models
{
    public class GetWordCloudResponseBody : TeaModel {
        /// <summary>
        /// 词列表
        /// </summary>
        [NameInMap("words")]
        [Validation(Required=false)]
        public List<GetWordCloudResponseBodyWords> Words { get; set; }
        public class GetWordCloudResponseBodyWords : TeaModel {
            /// <summary>
            /// 词数量
            /// </summary>
            [NameInMap("count")]
            [Validation(Required=false)]
            public long? Count { get; set; }

            /// <summary>
            /// 词名
            /// </summary>
            [NameInMap("word")]
            [Validation(Required=false)]
            public string Word { get; set; }

        }

    }

}
