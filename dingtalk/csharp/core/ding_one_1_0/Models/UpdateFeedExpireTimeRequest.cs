// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkding_one_1_0.Models
{
    public class UpdateFeedExpireTimeRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1772177962000</para>
        /// </summary>
        [NameInMap("expireTime")]
        [Validation(Required=false)]
        public long? ExpireTime { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dd-one-work-eSo869uR9Vhse2sqTw3dDF</para>
        /// </summary>
        [NameInMap("feedId")]
        [Validation(Required=false)]
        public string FeedId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ntThCP2X44FlskVliPIXPUQiEiE</para>
        /// </summary>
        [NameInMap("unionId")]
        [Validation(Required=false)]
        public string UnionId { get; set; }

    }

}
