// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalklive_1_0.Models
{
    public class SubscribeLiveRequest : TeaModel {
        /// <summary>
        /// 直播uuid
        /// </summary>
        [NameInMap("liveId")]
        [Validation(Required=false)]
        public string LiveId { get; set; }

        /// <summary>
        /// true:关注 false:取消关注
        /// </summary>
        [NameInMap("subscribe")]
        [Validation(Required=false)]
        public bool? Subscribe { get; set; }

        /// <summary>
        /// 用户id
        /// </summary>
        [NameInMap("unionId")]
        [Validation(Required=false)]
        public string UnionId { get; set; }

    }

}
