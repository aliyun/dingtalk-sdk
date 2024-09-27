// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkservice_group_1_0.Models
{
    public class GetNegativeWordCloudResponseBody : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("words")]
        [Validation(Required=false)]
        public List<GetNegativeWordCloudResponseBodyWords> Words { get; set; }
        public class GetNegativeWordCloudResponseBodyWords : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("count")]
            [Validation(Required=false)]
            public long? Count { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>销售</para>
            /// </summary>
            [NameInMap("word")]
            [Validation(Required=false)]
            public string Word { get; set; }

        }

    }

}
