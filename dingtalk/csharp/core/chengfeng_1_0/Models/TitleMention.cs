// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkchengfeng_1_0.Models
{
    public class TitleMention : TeaModel {
        /// <summary>
        /// 结束位置
        /// </summary>
        [NameInMap("length")]
        [Validation(Required=false)]
        public int? Length { get; set; }

        /// <summary>
        /// 开始位置
        /// </summary>
        [NameInMap("offset")]
        [Validation(Required=false)]
        public int? Offset { get; set; }

        /// <summary>
        /// “@人员”对象信息
        /// </summary>
        [NameInMap("user")]
        [Validation(Required=false)]
        public OpenUserDTO User { get; set; }

    }

}
