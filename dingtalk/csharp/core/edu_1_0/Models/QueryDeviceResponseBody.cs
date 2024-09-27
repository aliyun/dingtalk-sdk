// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkedu_1_0.Models
{
    public class QueryDeviceResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>1680227019000</para>
        /// </summary>
        [NameInMap("gmtExpiry")]
        [Validation(Required=false)]
        public long? GmtExpiry { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>model1</para>
        /// </summary>
        [NameInMap("model")]
        [Validation(Required=false)]
        public string Model { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>三年级1班班牌</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>fada-8008</para>
        /// </summary>
        [NameInMap("sn")]
        [Validation(Required=false)]
        public string Sn { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>VIDEO_CALL</para>
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
