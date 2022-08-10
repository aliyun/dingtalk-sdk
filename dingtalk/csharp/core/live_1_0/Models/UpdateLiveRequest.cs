// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalklive_1_0.Models
{
    public class UpdateLiveRequest : TeaModel {
        /// <summary>
        /// 直播封面
        /// </summary>
        [NameInMap("coverUrl")]
        [Validation(Required=false)]
        public string CoverUrl { get; set; }

        /// <summary>
        /// 简介
        /// </summary>
        [NameInMap("introduction")]
        [Validation(Required=false)]
        public string Introduction { get; set; }

        /// <summary>
        /// 直播id
        /// </summary>
        [NameInMap("liveId")]
        [Validation(Required=false)]
        public string LiveId { get; set; }

        /// <summary>
        /// 预计结束时间
        /// </summary>
        [NameInMap("preEndTime")]
        [Validation(Required=false)]
        public long? PreEndTime { get; set; }

        /// <summary>
        /// 预计开播时间
        /// </summary>
        [NameInMap("preStartTime")]
        [Validation(Required=false)]
        public long? PreStartTime { get; set; }

        /// <summary>
        /// 标题
        /// </summary>
        [NameInMap("title")]
        [Validation(Required=false)]
        public string Title { get; set; }

        /// <summary>
        /// 用户id（主播id）
        /// </summary>
        [NameInMap("unionId")]
        [Validation(Required=false)]
        public string UnionId { get; set; }

    }

}
